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
    public partial class AnalysisEditForm : Form
    {
        private EvidenceRepository evidenceRepository;
        private LabAnalysis analysis;

        public AnalysisEditForm(LabAnalysis analysis)
        {
            InitializeComponent();
            this.analysis = analysis;

            dateTimePicker1.MinDate = new DateTime(1900, 1, 1);
            dateTimePicker1.MaxDate = DateTime.Today;

            string connectionString = "server=localhost;user=root;database=crimelab";
            evidenceRepository = new EvidenceRepository(connectionString);

            LoadEvidences();

            if (analysis == null || string.IsNullOrWhiteSpace(analysis.Results))
            {
                resultTextBox.Text = "Results of the analysis";
                resultTextBox.ForeColor = Color.Gray;
            }
            else
            {
                resultTextBox.Text = analysis.Results;
                if (analysis.Date != DateTime.MinValue)
                    dateTimePicker1.Value = analysis.Date;

                if (analysis.EvidenceId != 0)
                    evidenceComboBox.SelectedValue = analysis.EvidenceId;
            }
        }

        private void LoadEvidences()
        {
            List<Evidence> evidences = evidenceRepository.GetAllEvidences();

            evidenceComboBox.DisplayMember = "EvidenceId";
            evidenceComboBox.ValueMember = "EvidenceId";
            evidenceComboBox.DataSource = evidences;

            if (analysis.EvidenceId != 0)
                evidenceComboBox.SelectedValue = analysis.EvidenceId;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "Results of the analysis" ||
                string.IsNullOrWhiteSpace(evidenceComboBox.Text))
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            analysis.Results = resultTextBox.Text;
            analysis.Date = dateTimePicker1.Value;
            analysis.EvidenceId = (int)evidenceComboBox.SelectedValue;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //---------------------------------style---------------------------------------------------------

        private void resultTextBox_Enter(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "Results of the analysis")
            {
                resultTextBox.Text = "";
                resultTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void resultTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(resultTextBox.Text))
            {
                resultTextBox.Text = "Results of the analysis";
                resultTextBox.ForeColor = Color.Gray;
            }
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {
            if (resultTextBox.ForeColor == Color.Gray)
            {
                resultTextBox.ForeColor = SystemColors.WindowText;
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
