using CrimelabHelper.Edit_Forms;
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

namespace CrimelabHelper
{
    public partial class Analysisform : Form
    {
        private int selectedAnalysisId = -1;
        private LabAnalysisRepository analysisRepository;
        public Analysisform()
        {
            InitializeComponent();

            string connectionString = "server=localhost;user=root;database=crimelab";
            analysisRepository = new LabAnalysisRepository(connectionString);

            ShowAnalysis();
        }

        private void ShowAnalysis()
        {
            List<LabAnalysis> analyses = analysisRepository.GetAllLabAnalyses();

            // Налаштування DataGridView
            analysisList.AutoGenerateColumns = true;
            analysisList.DataSource = analyses;
        }

        private void analysisList_SelectionChanged(object sender, EventArgs e)
        {
            if (analysisList.SelectedRows.Count > 0)
            {
                selectedAnalysisId = (int)analysisList.SelectedRows[0].Cells["AnalysisId"].Value;
            }
            else
            {
                selectedAnalysisId = -1;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            LabAnalysis newLabAnalysis = new LabAnalysis();

            AnalysisEditForm editForm = new AnalysisEditForm(newLabAnalysis);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                analysisRepository.AddAnalysis(newLabAnalysis);

                ShowAnalysis();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (selectedAnalysisId != -1)
            {
                LabAnalysis analysis = analysisRepository.GetLabAnalysisById(selectedAnalysisId);

                AnalysisEditForm editForm = new AnalysisEditForm(analysis);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    analysisRepository.UpdateAnalysis(analysis);
                    ShowAnalysis();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть доказ для редагування.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedAnalysisId != -1)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей доказ?", "Підтвердження видалення", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    analysisRepository.DeleteAnalysis(selectedAnalysisId);
                    ShowAnalysis();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть доказ для видалення.");
            }
        }

    }
}
