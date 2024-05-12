using System;
using System.Windows.Forms;
using CrimelabHelper.Models;

namespace CrimelabHelper
{
    public partial class CrimeEditForm : Form
    {
        private Crime crime;

        public CrimeEditForm(Crime crime)
        {
            InitializeComponent();
            this.crime = crime;

            // Встановлюємо мінімальну дату як 01.01.1900
            dateDateTimePicker.MinDate = new DateTime(1900, 1, 1);
            // Встановлюємо максимальну дату як поточну дату
            dateDateTimePicker.MaxDate = DateTime.Today;

            // Якщо передано преступлення, виведемо його дані у відповідних полях
            if (crime != null)
            {
                descriptionTextBox.Text = crime.Description;
                // Перевіряємо, чи дата не є мінімальною
                if (crime.Date != DateTime.MinValue)
                    dateDateTimePicker.Value = crime.Date;
                typeTextBox.Text = crime.Type;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Зберігаємо дані з полів у преступлення
            crime.Description = descriptionTextBox.Text;
            crime.Date = dateDateTimePicker.Value;
            crime.Type = typeTextBox.Text;

            // Закриваємо форму з результатом DialogResult.OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Закриваємо форму з результатом DialogResult.Cancel
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
