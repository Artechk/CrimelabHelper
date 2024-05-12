using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CrimelabHelper.Edit_Forms;
using CrimelabHelper.Models;
using CrimelabHelper.Repositories;

namespace CrimelabHelper
{
    public partial class Evidenceform : Form
    {
        private int selectedEvidenceId = -1;
        private EvidenceRepository evidenceRepository;

        public Evidenceform()
        {
            InitializeComponent();

            string connectionString = "server=localhost;user=root;database=crimelab";
            evidenceRepository = new EvidenceRepository(connectionString);

            ShowEvidences();
        }

        private void ShowEvidences()
        {
            List<Evidence> evidences = evidenceRepository.GetAllEvidences();

            // Налаштування DataGridView
            evidenceList.AutoGenerateColumns = true;
            evidenceList.DataSource = evidences;
        }


        private void evidenceList_SelectionChanged(object sender, EventArgs e)
        {
            // Отримуємо ID вибраного доказу
            if (evidenceList.SelectedRows.Count > 0)
            {
                selectedEvidenceId = (int)evidenceList.SelectedRows[0].Cells["EvidenceId"].Value;
            }
            else
            {
                selectedEvidenceId = -1;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Створюємо новий доказ з порожніми значеннями
            Evidence newEvidence = new Evidence();

            // Відкриваємо форму для додавання доказу
            EvidenceEditForm editForm = new EvidenceEditForm(newEvidence);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Додаємо новий доказ до бази даних
                evidenceRepository.AddEvidence(newEvidence);

                // Поновлюємо список доказів
                ShowEvidences();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи вибраний доказ у списку
            if (selectedEvidenceId != -1)
            {
                // Отримуємо вибраний доказ з бази даних
                Evidence evidence = evidenceRepository.GetEvidenceById(selectedEvidenceId);

                // Відкриваємо форму для редагування доказу
                EvidenceEditForm editForm = new EvidenceEditForm(evidence);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Зберігаємо змінений доказ у базі даних
                    evidenceRepository.UpdateEvidence(evidence);
                    ShowEvidences();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть доказ для редагування.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи вибраний доказ у списку
            if (selectedEvidenceId != -1)
            {
                // Питаємо користувача про підтвердження видалення
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей доказ?", "Підтвердження видалення", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Видаляємо доказ з бази даних
                    evidenceRepository.DeleteEvidence(selectedEvidenceId);
                    ShowEvidences();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть доказ для видалення.");
            }
        }
    }
}
