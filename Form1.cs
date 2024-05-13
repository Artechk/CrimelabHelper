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

        private void evidenceBtn_Click(object sender, EventArgs e)
        {
            loadform(new Evidenceform());
        }

        private void expertsBtn_Click(object sender, EventArgs e)
        {
            loadform(new Expertsform());
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            loadform(new Reportsform());
        }

        private void analysisBtn_Click(object sender, EventArgs e)
        {
            loadform(new Analysisform());
        }

        private void suspectsBtn_Click(object sender, EventArgs e)
        {
            loadform(new Suspectsform());
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}