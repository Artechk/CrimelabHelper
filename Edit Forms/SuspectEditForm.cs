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
    public partial class SuspectEditForm : Form
    {
        private Suspect suspect;
        private CrimeRepository crimeRepository;
        public SuspectEditForm(Suspect suspect)
        {
            InitializeComponent();
            this.suspect = suspect;

            birthDateTimePicker.MinDate = new DateTime(1900, 1, 1);
            birthDateTimePicker.MaxDate = DateTime.Today;

            string connectionString = "server=localhost;user=root;database=crimelab";
            crimeRepository = new CrimeRepository(connectionString);

            LoadCrimes();

            nameTextBox.Text = suspect.Name;
            if (suspect.Birth != DateTime.MinValue)
                birthDateTimePicker.Value = suspect.Birth;
            addressTextBox.Text = suspect.Address;
            statusTextBox.Text = suspect.Status;

            if (suspect.CrimeId != 0)
            {
                crimeComboBox.SelectedValue = suspect.CrimeId;
            }
        }

        private void LoadCrimes()
        {
            List<Crime> crimes = crimeRepository.GetAllCrimes();

            crimeComboBox.DisplayMember = "CrimeId";
            crimeComboBox.ValueMember = "CrimeId";
            crimeComboBox.DataSource = crimes;

            if (suspect.CrimeId != 0)
            {
                crimeComboBox.SelectedValue = suspect.CrimeId;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(statusTextBox.Text) ||
                string.IsNullOrWhiteSpace(crimeComboBox.Text))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            suspect.Name = nameTextBox.Text;
            suspect.Birth = birthDateTimePicker.Value;
            suspect.Address = addressTextBox.Text;
            suspect.Status = statusTextBox.Text;
            suspect.CrimeId = (int)crimeComboBox.SelectedValue;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
