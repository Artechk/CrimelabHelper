using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            // Загружаем список преступлений и отображаем его в ComboBox
            LoadCrimes();

            // Заполняем поля формы данными доказа
            descriptionTextBox.Text = evidence.Description;
            typeTextBox.Text = evidence.Type;
            statusTextBox.Text = evidence.Status;
            // При добавлении нового доказа crimeId не устанавливаем
            if (evidence.CrimeId != 0)
            {
                crimeComboBox.SelectedValue = evidence.CrimeId;
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
            if (evidence.CrimeId != 0)
            {
                crimeComboBox.SelectedValue = evidence.CrimeId;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Проверяем заполнение полей
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text) ||
                string.IsNullOrWhiteSpace(typeTextBox.Text) ||
                string.IsNullOrWhiteSpace(statusTextBox.Text) ||
                string.IsNullOrWhiteSpace(crimeComboBox.Text))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            // Обновляем поля доказа
            evidence.Description = descriptionTextBox.Text;
            evidence.Type = typeTextBox.Text;
            evidence.Status = statusTextBox.Text;
            evidence.CrimeId = (int)crimeComboBox.SelectedValue;

            // Закрываем форму с результатом DialogResult.OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Закрываем форму с результатом DialogResult.Cancel
            DialogResult = DialogResult.Cancel;
            Close();
        }


        //-------------------------------style-------------------------------------------------------------------------


        private void descriptionTextBox_Enter(object sender, EventArgs e)
        {
            // Проверяем, если текст серого цвета и равен подсказке, то очищаем его
            if (descriptionTextBox.Text == "In the shadowy corner, a lone pineapple slice perched on a murder weapon, the ultimate fruit of deception...")
            {
                descriptionTextBox.Text = "";
                descriptionTextBox.ForeColor = SystemColors.WindowText; // Изменяем цвет на черный
            }
        }

        private void descriptionTextBox_Leave(object sender, EventArgs e)
        {
            // Если текстовое поле пусто, возвращаем подсказку и серый цвет
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                descriptionTextBox.Text = "In the shadowy corner, a lone pineapple slice perched on a murder weapon, the ultimate fruit of deception...";
                descriptionTextBox.ForeColor = Color.Gray;
            }
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            // Меняем цвет текста на черный, когда пользователь начинает вводить текст
            if (descriptionTextBox.ForeColor == Color.Gray)
            {
                descriptionTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void typeTextBox_Enter(object sender, EventArgs e)
        {
            if (typeTextBox.Text == "Instrumental Evidence")
            {
                typeTextBox.Text = "";
                typeTextBox.ForeColor = SystemColors.WindowText; // Изменяем цвет на черный
            }
        }

        private void typeTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(typeTextBox.Text))
            {
                typeTextBox.Text = "Instrumental Evidence";
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

        private void statusTextBox_Enter(object sender, EventArgs e)
        {
            if (statusTextBox.Text == "Under analysis")
            {
                statusTextBox.Text = "";
                statusTextBox.ForeColor = SystemColors.WindowText; // Изменяем цвет на черный
            }
        }

        private void statusTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(statusTextBox.Text))
            {
                statusTextBox.Text = "Under analysis";
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
    }
}
