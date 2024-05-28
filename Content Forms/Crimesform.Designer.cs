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
            addBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            betweendtsBtn = new Button();
            totalBtn = new Button();
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
            // addBtn
            // 
            addBtn.BackColor = Color.WhiteSmoke;
            addBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            addBtn.FlatAppearance.BorderSize = 2;
            addBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(986, 12);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(118, 51);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addcrimeBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.WhiteSmoke;
            editBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            editBtn.FlatAppearance.BorderSize = 2;
            editBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editBtn.Location = new Point(986, 100);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(118, 51);
            editBtn.TabIndex = 3;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editcrimeBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.WhiteSmoke;
            deleteBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            deleteBtn.FlatAppearance.BorderSize = 2;
            deleteBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBtn.Location = new Point(986, 190);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(118, 51);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deletecrimeBtn_Click;
            // 
            // betweendtsBtn
            // 
            betweendtsBtn.BackColor = Color.WhiteSmoke;
            betweendtsBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            betweendtsBtn.FlatAppearance.BorderSize = 2;
            betweendtsBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            betweendtsBtn.FlatStyle = FlatStyle.Flat;
            betweendtsBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            betweendtsBtn.Location = new Point(986, 283);
            betweendtsBtn.Name = "betweendtsBtn";
            betweendtsBtn.Size = new Size(118, 51);
            betweendtsBtn.TabIndex = 10;
            betweendtsBtn.Text = "btw";
            betweendtsBtn.UseVisualStyleBackColor = false;
            betweendtsBtn.Click += betweendtsBtn_Click;
            // 
            // totalBtn
            // 
            totalBtn.BackColor = Color.WhiteSmoke;
            totalBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            totalBtn.FlatAppearance.BorderSize = 2;
            totalBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            totalBtn.FlatStyle = FlatStyle.Flat;
            totalBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalBtn.Location = new Point(12, 403);
            totalBtn.Name = "totalBtn";
            totalBtn.Size = new Size(99, 38);
            totalBtn.TabIndex = 11;
            totalBtn.Text = "Total";
            totalBtn.UseVisualStyleBackColor = false;
            totalBtn.Click += totalBtn_Click;
            // 
            // Crimesform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 453);
            Controls.Add(totalBtn);
            Controls.Add(betweendtsBtn);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
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
        private Button addBtn;
        private Button editBtn;
        private Button deleteBtn;
        private Button betweendtsBtn;
        private Button totalBtn;
    }
}