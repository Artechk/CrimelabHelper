using System;
using System.Windows.Forms;

namespace CrimelabHelper
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.contentPanel.Controls.Count > 0)
                this.contentPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.contentPanel.Controls.Add(f);
            this.contentPanel.Tag = f;
            f.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            loadform(new Homeform());
        }

        private void crimeBtn_Click(object sender, EventArgs e)
        {
            loadform(new Crimesform());
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}