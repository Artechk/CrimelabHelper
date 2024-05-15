using CrimelabHelper.Models;
using CrimelabHelper.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimelabHelper.Edit_Forms
{
    public partial class ReportEditForm : Form
    {
        private InvestigationReport report;
        private CrimeRepository crimeRepository;
        private ExpertRepository expertRepository;

        public ReportEditForm(InvestigationReport report)
        {
            InitializeComponent();
            this.report = report;

            reportDateTimePicker.MinDate = new DateTime(1900, 1, 1);
            reportDateTimePicker.MaxDate = DateTime.Today;

            string connectionString = "server=localhost;user=root;database=crimelab";
            crimeRepository = new CrimeRepository(connectionString);
            expertRepository = new ExpertRepository(connectionString);

            LoadCrimes();
            LoadExperts();

            if (report == null || string.IsNullOrWhiteSpace(report.Description) &&
                string.IsNullOrWhiteSpace(report.Conclusions))
            {
                descriptionTextBox.Text = "Description of the report";
                descriptionTextBox.ForeColor = Color.Gray;
                repConclusionsTextBox.Text = "Conclusions of the report";
                repConclusionsTextBox.ForeColor = Color.Gray;
            }
            else
            {
                descriptionTextBox.Text = report.Description;
                repConclusionsTextBox.Text = report.Conclusions;
                if (report.Date != DateTime.MinValue)
                    reportDateTimePicker.Value = report.Date;

                if (report.CrimeId != 0)
                    crimeComboBox.SelectedValue = report.CrimeId;

                if (report.ExpertId != 0)
                    expertComboBox.SelectedValue = report.ExpertId;
            }
        }

        private void LoadCrimes()
        {
            List<Crime> crimes = crimeRepository.GetAllCrimes();

            crimeComboBox.DisplayMember = "CrimeId";
            crimeComboBox.ValueMember = "CrimeId";
            crimeComboBox.DataSource = crimes;

            if (report.CrimeId != 0)
                crimeComboBox.SelectedValue = report.CrimeId;
        }

        private void LoadExperts()
        {
            List<Expert> experts = expertRepository.GetAllExperts();

            expertComboBox.DisplayMember = "ExpertId";
            expertComboBox.ValueMember = "ExpertId";
            expertComboBox.DataSource = experts;

            if (report.ExpertId != 0)
                expertComboBox.SelectedValue = report.ExpertId;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text == "Description of the report" ||
                repConclusionsTextBox.Text == "Conclusions of the report" ||
                string.IsNullOrWhiteSpace(expertComboBox.Text) ||
                string.IsNullOrWhiteSpace(crimeComboBox.Text))
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            report.CrimeId = (int)crimeComboBox.SelectedValue;
            report.Description = descriptionTextBox.Text;
            report.Conclusions = repConclusionsTextBox.Text;
            report.ExpertId = (int)expertComboBox.SelectedValue;
            report.Date = reportDateTimePicker.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //---------------------------------style---------------------------------------------------------

        private void descriptionTextBox_Enter(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text == "Description of the report")
            {
                descriptionTextBox.Text = "";
                descriptionTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void descriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                descriptionTextBox.Text = "Description of the report";
                descriptionTextBox.ForeColor = Color.Gray;
            }
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (descriptionTextBox.ForeColor == Color.Gray)
            {
                descriptionTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void repConclusionsTextBox_Enter(object sender, EventArgs e)
        {
            if (repConclusionsTextBox.Text == "Conclusions of the report")
            {
                repConclusionsTextBox.Text = "";
                repConclusionsTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void repConclusionsTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(repConclusionsTextBox.Text))
            {
                repConclusionsTextBox.Text = "Conclusions of the report";
                repConclusionsTextBox.ForeColor = Color.Gray;
            }
        }

        private void repConclusionsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (repConclusionsTextBox.ForeColor == Color.Gray)
            {
                repConclusionsTextBox.ForeColor = SystemColors.WindowText;
            }
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
