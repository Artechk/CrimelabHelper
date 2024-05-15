using CrimelabHelper.Edit_Forms;
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

namespace CrimelabHelper
{
    public partial class Suspectsform : Form
    {
        private SuspectRepository suspectsRepository;
        private int selectedSuspectId = -1;
        public Suspectsform()
        {
            InitializeComponent();

            string connectionString = "server=localhost;user=root;database=crimelab";
            suspectsRepository = new SuspectRepository(connectionString);

            ShowSuspects();
        }
        private void ShowSuspects()
        {
            List<Suspect> crimes = suspectsRepository.GetAllSuspects();

            suspectsList.AutoGenerateColumns = true;
            suspectsList.DataSource = crimes;
        }

        private void suspectsList_SelectionChanged(object sender, EventArgs e)
        {
            if (suspectsList.SelectedRows.Count > 0)
            {
                selectedSuspectId = (int)suspectsList.SelectedRows[0].Cells["SuspectId"].Value;
            }
            else
            {
                selectedSuspectId = -1;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Suspect newSuspect = new Suspect();

            SuspectEditForm editForm = new SuspectEditForm(newSuspect);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                suspectsRepository.AddSuspect(newSuspect);

                ShowSuspects();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (selectedSuspectId != -1)
            {
                Suspect suspect = suspectsRepository.GetSuspectById(selectedSuspectId);

                SuspectEditForm editForm = new SuspectEditForm(suspect);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    suspectsRepository.UpdateSuspect(suspect);
                    ShowSuspects();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть злочин для редагування.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedSuspectId != -1)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей злочин?", "Підтвердження видалення", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    suspectsRepository.DeleteSuspect(selectedSuspectId);
                    ShowSuspects();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть злочин для видалення.");
            }
        }

    }
}
