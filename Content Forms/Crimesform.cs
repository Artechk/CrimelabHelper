using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CrimelabHelper.Models;
using CrimelabHelper.Repositories;
using Org.BouncyCastle.Math;

namespace CrimelabHelper
{
    public partial class Crimesform : Form
    {
        private CrimeRepository crimeRepository;
        private int selectedCrimeId = -1;
        private int firstSelectedCrimeId;
        private int lastSelectedCrimeId;

        public Crimesform()
        {
            InitializeComponent();

            // Ініціалізуємо об'єкт crimeRepository
            string connectionString = "server=localhost;user=root;database=crimelab";
            crimeRepository = new CrimeRepository(connectionString);

            // Відображаємо список crimes у DataGridView
            ShowCrimes();
        }

        private void ShowCrimes()
        {
            // Отримуємо список crimes з бази даних
            List<Crime> crimes = crimeRepository.GetAllCrimes();

            // Налаштування DataGridView
            crimesList.AutoGenerateColumns = true;
            crimesList.DataSource = crimes;
        }

        private void crimesList_SelectionChanged(object sender, EventArgs e)
        {
            // Отримуємо ID вибраного crime
            if (crimesList.SelectedRows.Count == 1)
            {
                selectedCrimeId = (int)crimesList.SelectedRows[0].Cells["CrimeId"].Value;
            }
            else
            {
                selectedCrimeId = -1;
            }

            if (crimesList.SelectedRows.Count > 1)
            {
                firstSelectedCrimeId = (int)crimesList.SelectedRows[0].Cells["CrimeId"].Value;
                lastSelectedCrimeId = (int)crimesList.SelectedRows[crimesList.SelectedRows.Count - 1].Cells["CrimeId"].Value;
            }
        }

        private void addcrimeBtn_Click(object sender, EventArgs e)
        {
            // Створюємо нове злочин з порожніми значеннями
            Crime newCrime = new Crime();

            // Відкриваємо форму для додавання злочин
            CrimeEditForm editForm = new CrimeEditForm(newCrime);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Додаємо нове злочин до бази даних
                crimeRepository.AddCrime(newCrime);

                // Поновлюємо список злочин
                ShowCrimes();
            }
        }
        private void editcrimeBtn_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи вибран злочин у списку
            if (selectedCrimeId != -1)
            {
                // Отримуємо вибране злочин з бази даних
                Crime crime = crimeRepository.GetCrimeById(selectedCrimeId);

                // Відкриваємо форму для редагування злочин
                CrimeEditForm editForm = new CrimeEditForm(crime);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Зберігаємо змінене злочин у базі даних
                    crimeRepository.UpdateCrime(crime);
                    ShowCrimes();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть злочин для редагування.");
            }
        }
        private void deletecrimeBtn_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи вибране злочин у списку
            if (selectedCrimeId != -1)
            {
                // Питаємо користувача про підтвердження видалення
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей злочин?", "Підтвердження видалення", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Видаляємо злочин з бази даних
                    crimeRepository.DeleteCrime(selectedCrimeId);
                    ShowCrimes();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть злочин для видалення.");
            }
        }

        private void betweendtsBtn_Click(object sender, EventArgs e)
        {
            if (firstSelectedCrimeId > 0 && lastSelectedCrimeId > 0)
            {
                // Отримуємо вибрані злочини
                Crime firstCrime = crimeRepository.GetCrimeById(firstSelectedCrimeId);
                Crime lastCrime = crimeRepository.GetCrimeById(lastSelectedCrimeId);

                if (firstCrime != null && lastCrime != null)
                {
                    // Отримуємо список злочинів між датами першого та останнього вибраних злочинів
                    List<Crime> datacrimes = crimeRepository.GetCrimesBetweenDates(firstCrime, lastCrime);

                    // Оновлюємо джерело даних для відображення в списку
                    crimesList.AutoGenerateColumns = true;
                    crimesList.DataSource = datacrimes;
                }
                else
                {
                    MessageBox.Show("Не вдалося знайти злочини з вказаними ID.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть два злочини для пошуку.");
            }
        }

        private void totalBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(crimeRepository.GetTotalCrimes(), "Total crimes");
        }

        private void totaltypeBtn_Click(object sender, EventArgs e)
        {
            // Remove event handler temporarily to prevent unwanted triggers
            crimesList.SelectionChanged -= crimesList_SelectionChanged;

            // Get crime counts by type
            List<(string Type, int TotalCrimes)> crimeCounts = crimeRepository.GetCrimeCountsByType();

            // Create a DataTable to hold the data
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Crime Type", typeof(string));
            dataTable.Columns.Add("Total Crimes", typeof(int));

            // Fill the DataTable with data
            foreach (var crime in crimeCounts)
            {
                dataTable.Rows.Add(crime.Type, crime.TotalCrimes);
            }

            // Assuming you have a DataGridView control named expertsList
            crimesList.DataSource = dataTable;

        }

    }
}
