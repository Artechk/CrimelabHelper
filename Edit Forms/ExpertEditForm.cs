using CrimelabHelper.Models;
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
    public partial class ExpertEditForm : Form
    {
        private Expert expert;

        public ExpertEditForm(Expert expert)
        {
            InitializeComponent();
            this.expert = expert;

            if (expert == null || string.IsNullOrWhiteSpace(expert.Name) &&
                string.IsNullOrWhiteSpace(expert.Specialization) &&
                string.IsNullOrWhiteSpace(expert.Contact))
            {
                nameTextBox.Text = "Name of the expert";
                nameTextBox.ForeColor = Color.Gray;
                specializationTextBox.Text = "Expert's specialization";
                specializationTextBox.ForeColor = Color.Gray;
                contactinfoTextBox.Text = "Contact information";
                contactinfoTextBox.ForeColor = Color.Gray;
            }
            else
            {
                nameTextBox.Text = expert.Name;
                specializationTextBox.Text = expert.Specialization;
                contactinfoTextBox.Text = expert.Contact;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Name of the expert" ||
                specializationTextBox.Text == "Expert's specialization" ||
                contactinfoTextBox.Text == "Contact information")
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            expert.Name = nameTextBox.Text;
            expert.Specialization = specializationTextBox.Text;
            expert.Contact = contactinfoTextBox.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //---------------------------------style---------------------------------------------------------

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Name of the expert")
            {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameTextBox.Text = "Name of the expert";
                nameTextBox.ForeColor = Color.Gray;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.ForeColor == Color.Gray)
            {
                nameTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void specializationTextBox_Enter(object sender, EventArgs e)
        {
            if (specializationTextBox.Text == "Expert's specialization")
            {
                specializationTextBox.Text = "";
                specializationTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void specializationTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(specializationTextBox.Text))
            {
                specializationTextBox.Text = "Expert's specialization";
                specializationTextBox.ForeColor = Color.Gray;
            }
        }

        private void specializationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (specializationTextBox.ForeColor == Color.Gray)
            {
                specializationTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void contactinfoTextBox_Enter(object sender, EventArgs e)
        {
            if (contactinfoTextBox.Text == "Contact information")
            {
                contactinfoTextBox.Text = "";
                contactinfoTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void contactinfoTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contactinfoTextBox.Text))
            {
                contactinfoTextBox.Text = "Contact information";
                contactinfoTextBox.ForeColor = Color.Gray;
            }
        }

        private void contactinfoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (contactinfoTextBox.ForeColor == Color.Gray)
            {
                contactinfoTextBox.ForeColor = SystemColors.WindowText;
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
