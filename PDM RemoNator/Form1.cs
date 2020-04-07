using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDM_RemoNator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = ofTodos.FileName;
            //read txt file
        }


        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            ofTodos.Multiselect = false;
            ofTodos.InitialDirectory = @"C:\";
            ofTodos.ShowDialog();
        }

        private void btnLoadSubs_Click(object sender, EventArgs e)
        {
            ofSubs.Multiselect = false;
            ofSubs.InitialDirectory = @"C:\";
            ofSubs.ShowDialog();
        }

        private void ofSubs_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnCreditar_Click(object sender, EventArgs e)
        {

        }
    }
}
