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
    public partial class Expertsform : Form
    {
        private ExpertRepository expertRepository;
        private int selectedExpertId = -1;
        public Expertsform()
        {
            InitializeComponent();

            string connectionString = "server=localhost;user=root;database=crimelab";
            expertRepository = new ExpertRepository(connectionString);

            ShowExperts();
        }

        private void expertsList_SelectionChanged(object sender, EventArgs e)
        {
            if (expertsList.SelectedRows.Count > 0)
            {
                selectedExpertId = (int)expertsList.SelectedRows[0].Cells["ExpertId"].Value;
            }
            else
            {
                selectedExpertId = -1;
            }
        }

        private void ShowExperts()
        {
            List<Expert> experts = expertRepository.GetAllExperts();

            expertsList.AutoGenerateColumns = true;
            expertsList.DataSource = experts;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Створюємо нове злочин з порожніми значеннями
            Expert newExpert = new Expert();

            // Відкриваємо форму для додавання злочин
            ExpertEditForm editForm = new ExpertEditForm(newExpert);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Додаємо нове злочин до бази даних
                expertRepository.AddExpert(newExpert);

                // Поновлюємо список злочин
                ShowExperts();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (selectedExpertId != -1)
            {
                // Отримуємо вибране злочин з бази даних
                Expert expert = expertRepository.GetExpertById(selectedExpertId);

                // Відкриваємо форму для редагування злочин
                ExpertEditForm editForm = new ExpertEditForm(expert);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Зберігаємо змінене злочин у базі даних
                    expertRepository.UpdateExpert(expert);
                    ShowExperts();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть злочин для редагування.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи вибране злочин у списку
            if (selectedExpertId != -1)
            {
                // Питаємо користувача про підтвердження видалення
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей злочин?", "Підтвердження видалення", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Видаляємо злочин з бази даних
                    expertRepository.DeleteExpert(selectedExpertId);
                    ShowExperts();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть злочин для видалення.");
            }
        }

        private void totalrepBtn_Click(object sender, EventArgs e)
        {
            expertsList.SelectionChanged -= expertsList_SelectionChanged;

            // Get all experts
            List<Expert> allExperts = expertRepository.GetAllExperts();

            // Get report counts by expert
            List<(string ExpertName, int TotalReports)> reportCounts = expertRepository.GetReportCountsByExpert();

            // Create a dictionary to store report counts by expert name
            Dictionary<string, int> reportCountDictionary = new Dictionary<string, int>();
            foreach (var report in reportCounts)
            {
                reportCountDictionary[report.ExpertName] = report.TotalReports;
            }

            // Create a DataTable to hold the data
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Expert Name", typeof(string));
            dataTable.Columns.Add("Total Reports", typeof(int));

            // Fill the DataTable with data
            foreach (var expert in allExperts)
            {
                int totalReports = reportCountDictionary.ContainsKey(expert.Name) ? reportCountDictionary[expert.Name] : 0;
                dataTable.Rows.Add(expert.Name, totalReports);
            }

            // Assuming you have a DataGridView control named dataGridView1
            expertsList.DataSource = dataTable;
        }

    }
}
