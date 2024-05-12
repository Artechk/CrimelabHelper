using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CrimelabHelper.Models;
using CrimelabHelper.Repositories;

namespace CrimelabHelper
{
    public partial class Evidenceform : Form
    {
        private EvidenceRepository evidenceRepository;

        public Evidenceform()
        {
            InitializeComponent();

            // Ініціалізуємо об'єкт crimeRepository
            string connectionString = "server=localhost;user=root;database=crimelab";
            evidenceRepository = new EvidenceRepository(connectionString);

            // Відображаємо список преступлень у DataGridView
            ShowCrimes();
        }

        private void ShowCrimes()
        {
            // Отримуємо список crimes з бази даних
            List<Evidence> evidences = evidenceRepository.GetAllEvidences();

            // Налаштування DataGridView
            evidenceList.AutoGenerateColumns = true;
            evidenceList.DataSource = evidences;
        }

        private void evidenceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
