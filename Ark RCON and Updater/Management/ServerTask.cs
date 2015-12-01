using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SteamKit2;
using System.Xml.Serialization;
using System.Diagnostics;
using System.IO;

namespace Ark_RCON_and_Updater.Management
{

    public enum TaskType
    {
        Broadcast,
        ChatMessage,
        Command,
        Restart
    }

    public enum Interval
    {
        Minutes,
        MinuteOfHour,
        TimeOfDay
    }

    public class ServerTask
    {
        public int Id;
        public TaskType Type;
        public string Name;
        public string Command;
        public Interval Interval;
        public DateTime Time;
        public int DelaySaveWorld;
        public bool UpdateCheck;
        public bool Enabled
        {
            get
            {
                return enabled;
            }

            set
            {
                enabled = value;
                if (allowScheduling && value)
                    Activate();
                else
                    Deactivate();
            }

        }

        /// <summary>
        /// Gibt an, ob Task gestarted werden darf
        /// </summary>
        [XmlIgnore]
        public bool AllowScheduling
        {
            get { return allowScheduling; }
            set
            {
                allowScheduling = value;
                if (Enabled && value)
                    Activate();
                else
                    Deactivate();
            }
        }


        [XmlIgnore]
        public string Status { get; private set; }
        public event EventHandler StatusChange;

        Timer timer;

        bool allowScheduling;
        bool enabled;

        public ServerTask()
        {
            timer = new Timer(new TimerCallback(ExecuteTask), null, Timeout.Infinite, Timeout.Infinite);
        }

        /// <summary>
        /// Hinzufügen von Broadcast, ChatMessage oder Command.
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Name"></param>
        /// <param name="Command"></param>
        /// <param name="Interval"></param>
        /// <param name="Time"></param>
        public ServerTask(int Id, TaskType Type, string Name, string Command, Interval Interval , DateTime Time)
        {
            this.Id = Id;
            this.Type = Type;
            this.Name = Name;
            this.Command = Command;
            this.Interval = Interval;
            this.Time = Time;

            timer = new Timer(new TimerCallback(ExecuteTask), null, Timeout.Infinite, Timeout.Infinite);
        }

        /// <summary>
        /// Hinzufügen von Restart.
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Name"></param>
        /// <param name="Interval"></param>
        /// <param name="Time"></param>
        public ServerTask(int Id, TaskType Type, string Name, Interval Interval, DateTime Time)
        {
            this.Id = Id;
            this.Type = Type;
            this.Name = Name;
            this.Interval = Interval;
            this.Time = Time;

            timer = new Timer(new TimerCallback(ExecuteTask), null, Timeout.Infinite, Timeout.Infinite);
        }

        private void Activate()
        {
            int dueTime;
            
            switch (Interval)
            {
                case Interval.Minutes:
                    timer.Change(Time.Minute * 60 * 1000, Time.Minute * 60 * 1000);
                    break;

                case Interval.MinuteOfHour:
                    dueTime = (Time.Minute - DateTime.Now.Minute) * 60 * 1000 + (Time.Second - DateTime.Now.Second) * 1000;
                    if (dueTime < 0)
                        dueTime += 3600000;

                    timer.Change(dueTime, 3600000);
                    break;

                case Interval.TimeOfDay:
                    dueTime = (Time.Hour - DateTime.Now.Hour) * 60 * 60 * 1000 + (Time.Minute - DateTime.Now.Minute) * 60 * 1000 + (Time.Second - DateTime.Now.Second) * 1000;
                    if (dueTime < 0)
                        dueTime += 86400000;
                    timer.Change(dueTime, 86400000);
                    break;
            }
        }

        private void Deactivate()
        {
            timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        /// <summary>
        /// Startet den Task.
        /// </summary>
        public void ExecuteTask(Object StateInfo)
        {
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    switch (Type)
                    {
                        case TaskType.Broadcast:
                            Helper.Instance.rcon.SendCommand("Broadcast " + Command);
                            Helper.Instance.WriteLog("Broadcast: " + Command);
                            break;
                        case TaskType.ChatMessage:
                            Helper.Instance.rcon.SendCommand("ServerChat [" + Helper.Instance.loadedServer.Username + "] " + Command);
                            Helper.Instance.WriteLog("ChatMessage: " + Command);
                            break;
                        case TaskType.Command:
                            Helper.Instance.rcon.SendCommand(Command);
                            Helper.Instance.WriteLog("Command: " + Command);
                            break;
                        case TaskType.Restart:
                            Helper.Instance.WriteLog("Restart started" + Command);
                            Thread restartThread = new Thread(restartServer);
                            restartThread.Start();
                            break;
                    }

                    break;
                }
                catch
                {
                    if (i == 0)
                    {
                        Helper.Instance.ConnectRCON();
                    }
                    else
                    {
                        //Mögliche Ausgabe in Statusstrip oder Log
                        Helper.Instance.WriteLog("Error executing task " + Name + " with type " + Type.ToString() + " and command " + Command);
                        Status = "Fehler bei Task " + Name + ".";
                        StatusChange(this, EventArgs.Empty);
                    }
                }
            }
            

            Status = "Verbunden";
            StatusChange(this, EventArgs.Empty);
        }

        private void restartServer()
        {
            try
            {
                Helper.Instance.rcon.SendCommand("SaveWorld");
                System.Threading.Thread.Sleep(DelaySaveWorld * 1000);
            }
            catch
            {
                Status = "Speichern fehlgeschlagen...";
                StatusChange(this, EventArgs.Empty);
                Helper.Instance.WriteLog("Restart: World saving failed");
            }
            string path;
            //Ark-Server beenden
            try
            {
                path = Path.GetFileNameWithoutExtension(Helper.Instance.loadedServer.ArkServerPath);
                Process.GetProcessesByName(path)[0].Kill();
            }
            catch
            {
                //Mögliche Ausgabe in Statusstrip oder Log
                Helper.Instance.WriteLog("Closing Ark-Server failed");
            }
            //ArkRemote beenden
            try
            {
                path = Path.GetFileNameWithoutExtension(Path.GetFileName(Helper.Instance.loadedServer.ArkRemotePath));
                Process.GetProcessesByName(path)[0].Kill();
            }
            catch
            {
                //Mögliche Ausgabe in Statusstrip oder Log
                Helper.Instance.WriteLog("Closing ArkRemote failed");
            }


            System.Threading.Thread.Sleep(500);

            try
            {
                if (UpdateCheck)
                {
                    ProcessStartInfo steamCMDinfo = new ProcessStartInfo();
                    steamCMDinfo.Arguments = "+login anonymous +force_install_dir " + Directory.GetParent(Helper.Instance.loadedServer.ArkServerPath).Parent.Parent.Parent.FullName + " +app_update 346110 +quit";
                    steamCMDinfo.CreateNoWindow = false; //true
                    steamCMDinfo.UseShellExecute = false;
                    steamCMDinfo.RedirectStandardInput = false; //true
                    steamCMDinfo.RedirectStandardOutput = false; //true
                    steamCMDinfo.FileName = Helper.Instance.loadedServer.SteamCMDPath;

                    Process ProcSteamCMD = new Process();
                    ProcSteamCMD.StartInfo = steamCMDinfo;
                    ProcSteamCMD.Start();

                    Status = "Updaten...";
                    StatusChange(this, EventArgs.Empty);

                    do
                    {
                        //string output = ProcSteamCMD.StandardOutput.ReadToEnd();

                        //buildWorker.ReportProgress(0, System.Environment.NewLine + output);
                    }
                    while (!ProcSteamCMD.HasExited);
                }
            }
            catch
            {
                //Mögliche Ausgabe in Statusstrip oder Log
                Helper.Instance.WriteLog("Error starting SteamCMD");
            }

            Process[] tempP = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Path.GetFileName(Helper.Instance.loadedServer.ArkRemotePath)));
            if (tempP.Length == 0)
            {
                //ArkRemote starten
                ProcessStartInfo remoteInfo = new ProcessStartInfo();
                remoteInfo.FileName = Helper.Instance.loadedServer.ArkRemotePath;
                remoteInfo.WorkingDirectory = Directory.GetParent(Helper.Instance.loadedServer.ArkRemotePath).FullName;
                Process arkRemote = new Process();
                arkRemote.StartInfo = remoteInfo;
                arkRemote.Start();
            }

            Status = "Server gestartet...";
            StatusChange(this, EventArgs.Empty);

            System.Threading.Thread.Sleep(20000);
            Status = "Verbunden";
            StatusChange(this, EventArgs.Empty);

            Helper.Instance.WriteLog("Server restarted/updated.");
        }
    }
}
