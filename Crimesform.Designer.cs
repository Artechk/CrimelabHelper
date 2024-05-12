namespace CrimelabHelper
{
    partial class Crimesform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            crimesList = new DataGridView();
            crimeRepositoryBindingSource = new BindingSource(components);
            addcrimeBtn = new Button();
            editcrimeBtn = new Button();
            deletecrimeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)crimesList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)crimeRepositoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // crimesList
            // 
            crimesList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            crimesList.BackgroundColor = SystemColors.ControlLight;
            crimesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            crimesList.Location = new Point(12, 12);
            crimesList.Name = "crimesList";
            crimesList.ReadOnly = true;
            crimesList.Size = new Size(776, 362);
            crimesList.TabIndex = 0;
            crimesList.SelectionChanged += crimesList_SelectionChanged;
            // 
            // crimeRepositoryBindingSource
            // 
            crimeRepositoryBindingSource.DataSource = typeof(Repositories.CrimeRepository);
            // 
            // addcrimeBtn
            // 
            addcrimeBtn.BackColor = Color.WhiteSmoke;
            addcrimeBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            addcrimeBtn.FlatAppearance.BorderSize = 2;
            addcrimeBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            addcrimeBtn.FlatStyle = FlatStyle.Flat;
            addcrimeBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addcrimeBtn.Location = new Point(986, 12);
            addcrimeBtn.Name = "addcrimeBtn";
            addcrimeBtn.Size = new Size(118, 51);
            addcrimeBtn.TabIndex = 2;
            addcrimeBtn.Text = "Add";
            addcrimeBtn.UseVisualStyleBackColor = false;
            addcrimeBtn.Click += addcrimeBtn_Click;
            // 
            // editcrimeBtn
            // 
            editcrimeBtn.BackColor = Color.WhiteSmoke;
            editcrimeBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            editcrimeBtn.FlatAppearance.BorderSize = 2;
            editcrimeBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            editcrimeBtn.FlatStyle = FlatStyle.Flat;
            editcrimeBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editcrimeBtn.Location = new Point(986, 100);
            editcrimeBtn.Name = "editcrimeBtn";
            editcrimeBtn.Size = new Size(118, 51);
            editcrimeBtn.TabIndex = 3;
            editcrimeBtn.Text = "Edit";
            editcrimeBtn.UseVisualStyleBackColor = false;
            editcrimeBtn.Click += editcrimeBtn_Click;
            // 
            // deletecrimeBtn
            // 
            deletecrimeBtn.BackColor = Color.WhiteSmoke;
            deletecrimeBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            deletecrimeBtn.FlatAppearance.BorderSize = 2;
            deletecrimeBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            deletecrimeBtn.FlatStyle = FlatStyle.Flat;
            deletecrimeBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletecrimeBtn.Location = new Point(986, 190);
            deletecrimeBtn.Name = "deletecrimeBtn";
            deletecrimeBtn.Size = new Size(118, 51);
            deletecrimeBtn.TabIndex = 4;
            deletecrimeBtn.Text = "Delete";
            deletecrimeBtn.UseVisualStyleBackColor = false;
            deletecrimeBtn.Click += deletecrimeBtn_Click;
            // 
            // Crimesform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 453);
            Controls.Add(deletecrimeBtn);
            Controls.Add(editcrimeBtn);
            Controls.Add(addcrimeBtn);
            Controls.Add(crimesList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Crimesform";
            Text = "Crimesform";
            ((System.ComponentModel.ISupportInitialize)crimesList).EndInit();
            ((System.ComponentModel.ISupportInitialize)crimeRepositoryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView crimesList;
        private BindingSource crimeRepositoryBindingSource;
        private Button addcrimeBtn;
        private Button editcrimeBtn;
        private Button deletecrimeBtn;
    }
}