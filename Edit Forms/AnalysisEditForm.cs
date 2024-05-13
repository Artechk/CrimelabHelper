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

            resultTextBox.Text = analysis.Results;
            if (analysis.Date != DateTime.MinValue)
                dateTimePicker1.Value = analysis.Date;

            if (analysis.EvidenceId != 0)
            {
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
            {
                evidenceComboBox.SelectedValue = analysis.EvidenceId;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Проверяем заполнение полей
            if (string.IsNullOrWhiteSpace(resultTextBox.Text) ||
                string.IsNullOrWhiteSpace(evidenceComboBox.Text))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            // Обновляем поля доказа
            analysis.Results = resultTextBox.Text;
            analysis.Date = dateTimePicker1.Value;
            analysis.EvidenceId = (int)evidenceComboBox.SelectedValue;

            // Закрываем форму с результатом DialogResult.OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Закрываем форму с результатом DialogResult.Cancel
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
