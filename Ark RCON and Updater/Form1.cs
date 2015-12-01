using Ark_RCON_and_Updater.Management;
using QueryMaster;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ark_RCON_and_Updater
{
    public partial class Form1 : Form
    {
        ChooseServer formChooseServer;
        EditServerManagementSettings formEditServerSettings;
        AddSchedule formAddSchedule;

        Server server;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            toolStripBtnDisconnect.Visible = false;
            toolStripBtnServerSettings.Visible = false;
            toolStripSeparator1.Visible = false;

            //Unnötige Elemente im Toolstrip, Reiter Aufgaben ausblenden
            toolStripSeparatorSchedules.Visible = false;
            toolStripBtnDeleteTask.Visible = false;
        }

        private void toolStripBtnConnect_Click(object sender, EventArgs e)
        {
            formChooseServer = new ChooseServer();
            formChooseServer.Show();
            formChooseServer.FormClosing += FormChooseServer_FormClosing;
            Enabled = false;
            
        }

        private void FormChooseServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Helper.Instance.loadedServer = formChooseServer.Server;

            if (Helper.Instance.loadedServer != null)
            {
                server = ServerQuery.GetServerInstance(EngineType.Source, Helper.Instance.loadedServer.getQueryIPEndPoint());
                Helper.Instance.rcon = ServerQuery.GetServerInstance(EngineType.Source, Helper.Instance.loadedServer.getRCONIPEndPoint()).GetControl(Helper.Instance.loadedServer.RCONpw);
                panelMain.Visible = true;
                toolStripBtnConnect.Visible = false;
                toolStripBtnDisconnect.Visible = true;
                toolStripBtnServerSettings.Visible = true;
                toolStripSeparator1.Visible = true;

                //Elemente im Toolstrip, Reiter Aufgaben einblenden
                toolStripSchedules.Visible = true;
                toolStripBtnDeleteTask.Visible = true;

                loadTasks();

                toolStripStatusLabelStatus.Text = "Connected";
            }

            Enabled = true;
        }

        private void toolStripBtnDisconnect_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            toolStripBtnConnect.Visible = true;
            toolStripBtnDisconnect.Visible = false;
            toolStripBtnServerSettings.Visible = false;
            toolStripSeparator1.Visible = false;

            foreach (ServerTask task in Helper.Instance.loadedServer.Tasks)
            {
                task.AllowScheduling = false;
            }

            Helper.Instance.loadedServer = null;
            Helper.Instance.rcon = null;

            toolStripStatusLabelStatus.Text = "Disconnected";
        }

        private void toolStripBtnServerSettings_Click(object sender, EventArgs e)
        {
            formEditServerSettings = new EditServerManagementSettings();
            formEditServerSettings.Show();
            formEditServerSettings.FormClosing += FormEditServerSettings_FormClosing;
            Enabled = false;
        }

        private void FormEditServerSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formEditServerSettings.RemotePath != null)
                Helper.Instance.loadedServer.ArkRemotePath = formEditServerSettings.RemotePath;
            if (formEditServerSettings.ServerPath != null)
                Helper.Instance.loadedServer.ArkServerPath = formEditServerSettings.ServerPath;
            if (formEditServerSettings.SteamCMDPath != null)
                Helper.Instance.loadedServer.SteamCMDPath = formEditServerSettings.SteamCMDPath;

            Helper.Instance.SaveConfig();

            Enabled = true;
        }

        private void toolstripBtnAddTask_Click(object sender, EventArgs e)
        {
            formAddSchedule = new AddSchedule();
            formAddSchedule.Show();
            formAddSchedule.FormClosing += FormAddSchedule_FormClosing;
            Enabled = false;
        }

        private void FormAddSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formAddSchedule.Task != null)
            {
                Helper.Instance.loadedServer.Tasks.Add(formAddSchedule.Task);
                Helper.Instance.SaveConfig();
                loadTasks();

                //Elemente im Toolstrip, Reiter Aufgaben einblenden
                toolStripSchedules.Visible = true;
                toolStripBtnDeleteTask.Visible = true;
            }

            Enabled = true;
        }

        private void loadTasks()
        {
            listViewTasks.Items.Clear();

            foreach (ServerTask task in Helper.Instance.loadedServer.Tasks)
            {
                task.StatusChange += Task_StatusChange;

                string[] arrTasks = new string[4];
                arrTasks[0] = task.Type.ToString();
                arrTasks[1] = task.Name;

                //String für Spalte Uhrzeit erstellen
                if (task.Interval == Interval.Minutes)
                    arrTasks[2] = "Every " + task.Time.Minute.ToString() + " Minutes";
                else if (task.Interval == Interval.MinuteOfHour)
                    arrTasks[2] = "Hourly after " + task.Time.Minute.ToString() + ":" + task.Time.Second.ToString() + "Minutes";
                else
                    arrTasks[2] = "Daily at " + task.Time.Hour.ToString() + ":" + task.Time.Minute.ToString() + ":" + task.Time.Second.ToString() + " o' clock";
                arrTasks[3] = task.Command;

                ListViewItem item = new ListViewItem(arrTasks);
                item.Tag = task.Id;
                listViewTasks.Items.Add(item);

                task.AllowScheduling = true;
            }

            listViewTasks.Sorting = SortOrder.Ascending;
            listViewTasks.Sort();
        }

        private void Task_StatusChange(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text =  (sender as ServerTask).Status;
        }

        private void toolStripBtnExecuteTask_Click(object sender, EventArgs e)
        {
            Helper.Instance.loadedServer.Tasks.Find(x => x.Id == (int)listViewTasks.SelectedItems[0].Tag).ExecuteTask(null);
        }

        private void toolStripBtnDeleteTask_Click(object sender, EventArgs e)
        {
            Helper.Instance.loadedServer.Tasks.RemoveAt(Helper.Instance.loadedServer.Tasks.FindIndex(x => x.Id == (int)listViewTasks.SelectedItems[0].Tag));
            Helper.Instance.SaveConfig();
            loadTasks();
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            About formAbout = new About();
            formAbout.ShowDialog();
        }
    }
}
