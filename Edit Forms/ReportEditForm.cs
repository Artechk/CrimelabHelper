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
    public partial class ReportEditForm : Form
    {
        private InvestigationReport report;
        private CrimeRepository crimeRepository;
        private ExpertRepository expertRepository;
        public ReportEditForm(InvestigationReport report)
        {
            InitializeComponent();
            this.report = report;

            // Встановлюємо мінімальну дату як 01.01.1900
            reportDateTimePicker.MinDate = new DateTime(1900, 1, 1);
            // Встановлюємо максимальну дату як поточну дату
            reportDateTimePicker.MaxDate = DateTime.Today;

            string connectionString = "server=localhost;user=root;database=crimelab";
            crimeRepository = new CrimeRepository(connectionString);
            expertRepository = new ExpertRepository(connectionString);

            LoadCrimes();
            LoadExperts();

            descriptionTextBox.Text = report.Description;
            repConclusionsTextBox.Text = report.Conclusions;
            if (report.Date != DateTime.MinValue)
                reportDateTimePicker.Value = report.Date;

            if (report.CrimeId != 0)
            {
                crimeComboBox.SelectedValue = report.CrimeId;
            }

            if (report.ExpertId != 0)
            {
                expertComboBox.SelectedValue = report.ExpertId;
            }
        }

        private void LoadCrimes()
        {
            // Получаем список преступлений из базы данных
            List<Crime> crimes = crimeRepository.GetAllCrimes();

            // Заполняем ComboBox списком преступлений
            crimeComboBox.DisplayMember = "CrimeId"; // Отображаемое значение - описание преступления
            crimeComboBox.ValueMember = "CrimeId"; // Значение элемента - идентификатор преступления
            crimeComboBox.DataSource = crimes;

            // Если доказательство уже связано с каким-то преступлением, выбираем это преступление в ComboBox
            if (report.CrimeId != 0)
            {
                crimeComboBox.SelectedValue = report.CrimeId;
            }
        }

        private void LoadExperts()
        {
            // Получаем список преступлений из базы данных
            List<Expert> experts = expertRepository.GetAllExperts();

            // Заполняем ComboBox списком преступлений
            expertComboBox.DisplayMember = "ExpertId"; // Отображаемое значение - описание преступления
            expertComboBox.ValueMember = "ExpertId"; // Значение элемента - идентификатор преступления
            expertComboBox.DataSource = experts;

            // Если доказательство уже связано с каким-то преступлением, выбираем это преступление в ComboBox
            if (report.ExpertId != 0)
            {
                expertComboBox.SelectedValue = report.ExpertId;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text) ||
                string.IsNullOrWhiteSpace(repConclusionsTextBox.Text) ||
                string.IsNullOrWhiteSpace(expertComboBox.Text) ||
                string.IsNullOrWhiteSpace(crimeComboBox.Text))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            // Обновляем поля доказа
            report.CrimeId = (int)crimeComboBox.SelectedValue;
            report.Description = descriptionTextBox.Text;
            report.Conclusions = repConclusionsTextBox.Text;
            report.ExpertId = (int)expertComboBox.SelectedValue;
            report.Date = reportDateTimePicker.Value;

            // Закрываем форму с результатом DialogResult.OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
