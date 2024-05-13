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

            if (expert != null)
            {
                nameTextBox.Text = expert.Name;
                specializationTextBox.Text = expert.Specialization;
                contactinfoTextBox.Text = expert.Contact;
            }
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Зберігаємо дані з полів у преступлення
            expert.Name = nameTextBox.Text;
            expert.Specialization = specializationTextBox.Text;
            expert.Contact = contactinfoTextBox.Text;

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
