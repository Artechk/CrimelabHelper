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

            dateDateTimePicker.MinDate = new DateTime(1900, 1, 1);
            dateDateTimePicker.MaxDate = DateTime.Today;

            if (crime == null || string.IsNullOrWhiteSpace(crime.Description) &&
                string.IsNullOrWhiteSpace(crime.Type))
            {
                descriptionTextBox.Text = "Description of the crime";
                descriptionTextBox.ForeColor = Color.Gray;
                typeTextBox.Text = "Type of the crime";
                typeTextBox.ForeColor = Color.Gray;
            }
            else
            {
                descriptionTextBox.Text = crime.Description;
                if (crime.Date != DateTime.MinValue)
                    dateDateTimePicker.Value = crime.Date;
                typeTextBox.Text = crime.Type;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text == "Description of the crime" ||
                typeTextBox.Text == "Type of the crime")
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            crime.Description = descriptionTextBox.Text;
            crime.Date = dateDateTimePicker.Value;
            crime.Type = typeTextBox.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //---------------------------------style---------------------------------------------------------

        private void descriptionTextBox_Enter(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text == "Description of the crime")
            {
                descriptionTextBox.Text = "";
                descriptionTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void descriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                descriptionTextBox.Text = "Description of the crime";
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
            if (typeTextBox.Text == "Type of the crime")
            {
                typeTextBox.Text = "";
                typeTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void typeTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(typeTextBox.Text))
            {
                typeTextBox.Text = "Type of the crime";
                typeTextBox.ForeColor = Color.Gray;
            }
        }

        private void typeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (typeTextBox.ForeColor == Color.Gray)
            {
                typeTextBox.ForeColor = SystemColors.WindowText;
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
