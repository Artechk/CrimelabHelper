namespace CrimelabHelper
{
    partial class Reportsform
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
            reportsList = new DataGridView();
            deleteBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)reportsList).BeginInit();
            SuspendLayout();
            // 
            // reportsList
            // 
            reportsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reportsList.BackgroundColor = SystemColors.ControlLight;
            reportsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportsList.Location = new Point(12, 12);
            reportsList.Name = "reportsList";
            reportsList.ReadOnly = true;
            reportsList.Size = new Size(776, 362);
            reportsList.TabIndex = 2;
            reportsList.SelectionChanged += reportsList_SelectionChanged;
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
            deleteBtn.TabIndex = 10;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
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
            editBtn.TabIndex = 9;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
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
            addBtn.TabIndex = 8;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // Reportsform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 453);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(reportsList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reportsform";
            Text = "Reportsform";
            ((System.ComponentModel.ISupportInitialize)reportsList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView reportsList;
        private Button deleteBtn;
        private Button editBtn;
        private Button addBtn;
    }
}