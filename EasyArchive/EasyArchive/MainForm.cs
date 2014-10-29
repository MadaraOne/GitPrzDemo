using EasyArchive.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyArchive
{
    public partial class MainForm : Form
    {
        ActivityLogger _activityLogger;

        public MainForm()
        {
            InitializeComponent();
            _activityLogger = new ActivityLogger(new LabelDisplay(lbl_Status));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _activityLogger.Show("btn_Cancel clicked");
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            _activityLogger.Show("btnOK clicked");
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                MessageBox.Show("Login should be filled");
                return;
            }

            if (!CheckLoginUniqness())
            {
                MessageBox.Show("Login should be unique");
                return;
            }

        }

        private bool CheckLoginUniqness()
        {
            return false;
        }
    }

}
