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
    public partial class RCONPwInput : Form
    {
        public string Pw;

        public RCONPwInput()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Pw = textBoxPw.Text;
            Close();
        }
    }
}
