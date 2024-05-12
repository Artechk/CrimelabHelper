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
        private LabAnalysisRepository AnalysisRepository;
        public Analysisform()
        {
            InitializeComponent();

            string connectionString = "server=localhost;user=root;database=crimelab";
            AnalysisRepository = new LabAnalysisRepository(connectionString);

            ShowAnalysis();
        }

        private void ShowAnalysis()
        {
            // Отримуємо список crimes з бази даних
            List<LabAnalysis> crimes = AnalysisRepository.GetAllLabAnalyses();

            // Налаштування DataGridView
            analysisList.AutoGenerateColumns = true;
            analysisList.DataSource = crimes;
        }
    }
}
