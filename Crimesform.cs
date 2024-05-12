using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CrimelabHelper.Models;
using CrimelabHelper.Repositories;

namespace CrimelabHelper
{
    public partial class Crimesform : Form
    {
        private CrimeRepository crimeRepository;
        private int selectedCrimeId = -1;

        public Crimesform()
        {
            InitializeComponent();

            // Ініціалізуємо об'єкт crimeRepository
            string connectionString = "server=localhost;user=root;database=crimelab";
            crimeRepository = new CrimeRepository(connectionString);

            // Відображаємо список преступлень у DataGridView
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
            if (crimesList.SelectedRows.Count > 0)
            {
                selectedCrimeId = (int)crimesList.SelectedRows[0].Cells["CrimeId"].Value;
            }
            else
            {
                selectedCrimeId = -1;
            }
        }

        private void addcrimeBtn_Click(object sender, EventArgs e)
        {
            // Створюємо нове преступлення з порожніми значеннями
            Crime newCrime = new Crime();

            // Відкриваємо форму для додавання преступлення
            CrimeEditForm editForm = new CrimeEditForm(newCrime);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Додаємо нове преступлення до бази даних
                crimeRepository.AddCrime(newCrime);

                // Поновлюємо список преступлень
                ShowCrimes();
            }
        }
        private void editcrimeBtn_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи вибране преступлення у списку
            if (selectedCrimeId != -1)
            {
                // Отримуємо вибране преступлення з бази даних
                Crime crime = crimeRepository.GetCrimeById(selectedCrimeId);

                // Відкриваємо форму для редагування преступлення
                CrimeEditForm editForm = new CrimeEditForm(crime);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Зберігаємо змінене преступлення у базі даних
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
            // Перевіряємо, чи вибране преступлення у списку
            if (selectedCrimeId != -1)
            {
                // Питаємо користувача про підтвердження видалення
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей злочин?", "Підтвердження видалення", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Видаляємо преступлення з бази даних
                    crimeRepository.DeleteCrime(selectedCrimeId);
                    ShowCrimes();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть злочин для видалення.");
            }
        }

    }
}
