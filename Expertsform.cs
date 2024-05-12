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
    public partial class Expertsform : Form
    {
        private ExpertRepository expertRepository;
        public Expertsform()
        {
            InitializeComponent();

            string connectionString = "server=localhost;user=root;database=crimelab";
            expertRepository = new ExpertRepository(connectionString);

            ShowExperts();
        }

        private void ShowExperts()
        {
            List<Expert> experts = expertRepository.GetAllExperts();

            expertsList.AutoGenerateColumns = true;
            expertsList.DataSource = experts;
        }
    }
}
