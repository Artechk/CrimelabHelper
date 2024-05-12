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
    }
}
