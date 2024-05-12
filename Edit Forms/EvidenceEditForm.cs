using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrimelabHelper.Models;

namespace CrimelabHelper.Edit_Forms
{
    public partial class EvidenceEditForm : Form
    {
        private Evidence evidence;
        public EvidenceEditForm(Evidence evidence)
        {
            InitializeComponent();
            this.evidence = evidence;

            // Заполняем поля формы данными доказа
            descriptionTextBox.Text = evidence.Description;
            typeTextBox.Text = evidence.Type;
            statusTextBox.Text = evidence.Status;
            // При добавлении нового доказа crimeId не устанавливаем
            if (evidence.CrimeId != 0)
            {
                crimeIdTextBox.Text = evidence.CrimeId.ToString();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Проверяем заполнение полей
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text) ||
                string.IsNullOrWhiteSpace(typeTextBox.Text) ||
                string.IsNullOrWhiteSpace(statusTextBox.Text))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            // Обновляем поля доказа
            evidence.Description = descriptionTextBox.Text;
            evidence.Type = typeTextBox.Text;
            evidence.Status = statusTextBox.Text;
            // При добавлении нового доказа устанавливаем crimeId, если указан
            if (!string.IsNullOrWhiteSpace(crimeIdTextBox.Text))
            {
                evidence.CrimeId = int.Parse(crimeIdTextBox.Text);
            }

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
