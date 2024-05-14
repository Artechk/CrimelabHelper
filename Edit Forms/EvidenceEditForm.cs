using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CrimelabHelper.Models;
using CrimelabHelper.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CrimelabHelper.Edit_Forms
{
    public partial class EvidenceEditForm : Form
    {
        private Evidence evidence;
        private CrimeRepository crimeRepository;
        public EvidenceEditForm(Evidence evidence)
        {
            InitializeComponent();
            this.evidence = evidence;

            string connectionString = "server=localhost;user=root;database=crimelab";
            crimeRepository = new CrimeRepository(connectionString);

            LoadCrimes();

            if (string.IsNullOrWhiteSpace(evidence.Description) &&
                string.IsNullOrWhiteSpace(evidence.Type) &&
                string.IsNullOrWhiteSpace(evidence.Status))
            {
                descriptionTextBox.Text = "Description of the evidence";
                descriptionTextBox.ForeColor = Color.Gray;
                typeTextBox.Text = "Type of the evidence";
                typeTextBox.ForeColor = Color.Gray;
                statusTextBox.Text = "Status of the evidence";
                statusTextBox.ForeColor = Color.Gray;
            }
            else
            {
                descriptionTextBox.Text = evidence.Description;
                typeTextBox.Text = evidence.Type;
                statusTextBox.Text = evidence.Status;
                if (evidence.CrimeId != 0)
                {
                    crimeComboBox.SelectedValue = evidence.CrimeId;
                }
            }
        }

        private void LoadCrimes()
        {
            List<Crime> crimes = crimeRepository.GetAllCrimes();

            crimeComboBox.DisplayMember = "CrimeId";
            crimeComboBox.ValueMember = "CrimeId";
            crimeComboBox.DataSource = crimes;

            if (evidence.CrimeId != 0)
            {
                crimeComboBox.SelectedValue = evidence.CrimeId;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text == "Description of the evidence"||
                typeTextBox.Text == "Type of the evidence"||
                statusTextBox.Text == "Status of the evidence")
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            evidence.Description = descriptionTextBox.Text;
            evidence.Type = typeTextBox.Text;
            evidence.Status = statusTextBox.Text;
            evidence.CrimeId = (int)crimeComboBox.SelectedValue;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        //-------------------------------style-------------------------------------------------------------------------


        private void descriptionTextBox_Enter(object sender, EventArgs e)
        {
            
            if (descriptionTextBox.Text == "Description of the evidence")
            {
                descriptionTextBox.Text = "";
                descriptionTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void descriptionTextBox_Leave(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                descriptionTextBox.Text = "Description of the evidence";
                descriptionTextBox.ForeColor = Color.Gray;
            }
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if (descriptionTextBox.ForeColor == Color.Gray)
            {
                descriptionTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void typeTextBox_Enter(object sender, EventArgs e)
        {
            if (typeTextBox.Text == "Type of the evidence")
            {
                typeTextBox.Text = "";
                typeTextBox.ForeColor = SystemColors.WindowText; 
            }
        }

        private void typeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (typeTextBox.ForeColor == Color.Gray)
            {
                typeTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void typeTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(typeTextBox.Text))
            {
                typeTextBox.Text = "Type of the evidence";
                typeTextBox.ForeColor = Color.Gray;
            }
        }

        private void statusTextBox_Enter(object sender, EventArgs e)
        {
            if (statusTextBox.Text == "Status of the evidence")
            {
                statusTextBox.Text = "";
                statusTextBox.ForeColor = SystemColors.WindowText; 
            }
        }

        private void statusTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(statusTextBox.Text))
            {
                statusTextBox.Text = "Status of the evidence";
                statusTextBox.ForeColor = Color.Gray;
            }
        }

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {
            if (statusTextBox.ForeColor == Color.Gray)
            {
                statusTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        Point lastPoint;

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
