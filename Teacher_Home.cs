using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChatBot
{
    public partial class Teacher_Home : Form
    {
        public Teacher_Home()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Startup obj = new Startup();
            obj.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            aimlwriter obj = new aimlwriter();
            obj.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            botcheck obj = new botcheck();
            obj.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Teacher_students obj = new Teacher_students();
            obj.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Chatuser obj = new Chatuser();
            obj.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Chatinbox obj = new Chatinbox();
            obj.Show();
        }
    }
}
