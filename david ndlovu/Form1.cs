using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace david_ndlovu
{
    public partial class Form1 : Form
    {
        private ControllerReplication ctrlReplication = new ControllerReplication();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReplicate_Click(object sender, EventArgs e)
        {
                
                ctrlReplication.PostForBackUp(txtSource.Text, txtDestination.Text,chkSubDirectories.Checked);
        }
        
        private void btnSource_Click(object sender, EventArgs e)
        {
            string path= openBrowser("source");
            txtSource.Text = path;
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            string path= openBrowser("destination");
            txtDestination.Text = path;
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                txtDestination.Text = null;
            }
           
        }
        

        private void btnReplicate_Click_1(object sender, EventArgs e)
        {

        }

        private string openBrowser(string type)
        {
            if (type=="source") 
            {
                //-->Sour selction of a file
                DialogResult path = ofdSource.ShowDialog();
                if (path == DialogResult.OK)
                {
                    return ofdSource.FileName.ToString();
                }
            }else if (type=="destination")
            {
                //-->Folder selction destination
                DialogResult path = fbdDestination.ShowDialog();
                if (path == DialogResult.OK)
                {
                    return fbdDestination.SelectedPath.ToString();
                }
            }
            return null;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void errorDestination(object sender, CancelEventArgs e)
        {
            string tempSource = ctrlReplication.GetPath(txtSource.Text);
            if(txtDestination.Text == tempSource)
            {
                e.Cancel = true;
                btnDestination.Focus();
                errorpDestination.SetError(txtDestination, "Destination path can not be the same as Source path");
            }
        }

        private void btnViewLog_Click(object sender, EventArgs e)
        {
            //-->Default path to read logs
            Process.Start(@"C:\ReplicationLog\log.txt");
        }
    }
}
