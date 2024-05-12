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
    public partial class Reportsform : Form
    {
        private InvestigationReportRepository reportRepository;
        public Reportsform()
        {
            InitializeComponent();

            string connectionString = "server=localhost;user=root;database=crimelab";
            reportRepository = new InvestigationReportRepository(connectionString);

            ShowReports();
        }
        private void ShowReports()
        {
            List<InvestigationReport> crimes = reportRepository.GetAllInvestigationReports();

            reportsList.AutoGenerateColumns = true;
            reportsList.DataSource = crimes;
        }
    }
}
