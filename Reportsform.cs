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
    public partial class Reportsform : Form
    {
        private int selectedReportId = -1;
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

        private void reportsList_SelectionChanged(object sender, EventArgs e)
        {
            if (reportsList.SelectedRows.Count > 0)
            {
                selectedReportId = (int)reportsList.SelectedRows[0].Cells["ReportId"].Value;
            }
            else
            {
                selectedReportId = -1;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            InvestigationReport newinvestigationReport = new InvestigationReport();

            ReportEditForm editForm = new ReportEditForm(newinvestigationReport);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                reportRepository.AddReport(newinvestigationReport);

                ShowReports();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (selectedReportId != -1)
            {
                InvestigationReport investigationReport = reportRepository.GetInvestigationReportById(selectedReportId);

                ReportEditForm editForm = new ReportEditForm(investigationReport);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    reportRepository.UpdateReport(investigationReport);
                    ShowReports();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть доказ для редагування.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedReportId != -1)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей доказ?", "Підтвердження видалення", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    reportRepository.DeleteReport(selectedReportId);
                    ShowReports();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть доказ для видалення.");
            }
        }


    }
}
