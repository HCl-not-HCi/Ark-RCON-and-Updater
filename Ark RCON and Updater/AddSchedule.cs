using Ark_RCON_and_Updater.Management;
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
    public partial class AddSchedule : Form
    {
        public ServerTask Task;

        public AddSchedule()
        {
            InitializeComponent();
            Task = null;
        }

        private void AddSchedule_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void radioBtnRestart_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnRestart.Checked)
            {
                textBoxCommand.Enabled = false;
                groupBox2.Enabled = true;
            }
            else
            {
                textBoxCommand.Enabled = true;
                groupBox2.Enabled = false;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Typ des Tasks herausfinden
            TaskType type = TaskType.Broadcast;

            if (radioBtnBroadcast.Checked)
                type = TaskType.Broadcast;
            else if (radioBtnChatMessage.Checked)
                type = TaskType.ChatMessage;
            else if (radioBtnCommand.Checked)
                type = TaskType.Command;
            else if (radioBtnRestart.Checked)
                type = TaskType.Restart;

            //Zeitintervall des Tasks herausfinden
            Interval interval = Interval.Minutes;
            DateTime time = new DateTime();

            if (radioBtnInterval.Checked)
            {
                interval = Interval.Minutes;
                time = new DateTime(1, 1, 1, 0, (int)numericUpDownMinutes.Value, 0, DateTimeKind.Unspecified);
            }
            else if (radioBtnMinuteofHour.Checked)
            {
                interval = Interval.MinuteOfHour;
                time = dateTimeMinuteOfHour.Value;
            }
            else if (radioBtnTimeOfDay.Checked)
            {
                interval = Interval.TimeOfDay;
                time = dateTimeTimeOfDay.Value;
            }

            //Id des Tasks festlegen
            int id;

            if (Helper.Instance.loadedServer.Tasks.Count == 0)
                id = 0;
            else
                id = Helper.Instance.loadedServer.Tasks[Helper.Instance.loadedServer.Tasks.Count - 1].Id + 1;

            if (type != TaskType.Restart)
                Task = new ServerTask(id, type, textBoxName.Text, textBoxCommand.Text, interval, time);
            else
            {
                Task = new ServerTask(id, type, textBoxName.Text, interval, time);
                Task.DelaySaveWorld = (int)numericUpDownRestartSavePause.Value;
                Task.UpdateCheck = checkBoxRestartUpdate.Checked;
            }

            Task.Enabled = true;

            Close();
        }
    }
}
