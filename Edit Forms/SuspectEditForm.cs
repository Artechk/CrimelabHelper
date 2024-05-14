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

            if (string.IsNullOrWhiteSpace(suspect.Name) &&
                string.IsNullOrWhiteSpace(suspect.Address) &&
                string.IsNullOrWhiteSpace(suspect.Status))
            {
                nameTextBox.Text = "Name of the suspect";
                nameTextBox.ForeColor = Color.Gray;
                addressTextBox.Text = "Suspect's known addresses";
                addressTextBox.ForeColor = Color.Gray;
                statusTextBox.Text = "Status of the suspect";
                statusTextBox.ForeColor = Color.Gray;
            }
            else
            {
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
            if (nameTextBox.Text == "Name of the suspect" ||
                addressTextBox.Text == "Suspect's known addresses" ||
                statusTextBox.Text == "Status of the suspect") 
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

        //-------------------------------style-------------------------------------------------------------------------

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Name of the suspect")
            {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.ForeColor == Color.Gray)
            {
                nameTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameTextBox.Text = "Name of the suspect";
                nameTextBox.ForeColor = Color.Gray;
            }
        }

        private void addressTextBox_Enter(object sender, EventArgs e)
        {
            if (addressTextBox.Text == "Suspect's known addresses")
            {
                addressTextBox.Text = "";
                addressTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addressTextBox.ForeColor == Color.Gray)
            {
                addressTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void addressTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                addressTextBox.Text = "Suspect's known addresses";
                addressTextBox.ForeColor = Color.Gray;
            }
        }

        private void statusTextBox_Enter(object sender, EventArgs e)
        {
            if (statusTextBox.Text == "Status of the suspect")
            {
                statusTextBox.Text = "";
                statusTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {
            if (statusTextBox.ForeColor == Color.Gray)
            {
                statusTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void statusTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(statusTextBox.Text))
            {
                statusTextBox.Text = "Status of the suspect";
                statusTextBox.ForeColor = Color.Gray;
            }
        }
    }
}
