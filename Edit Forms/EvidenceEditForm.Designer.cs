﻿namespace CrimelabHelper.Edit_Forms
{
    partial class EvidenceEditForm
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
            descriptionTextBox = new TextBox();
            typeTextBox = new TextBox();
            statusTextBox = new TextBox();
            cancelBtn = new Button();
            saveBtn = new Button();
            crimeComboBox = new ComboBox();
            SuspendLayout();
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(12, 12);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(376, 149);
            descriptionTextBox.TabIndex = 0;
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            descriptionTextBox.Enter += descriptionTextBox_Enter;
            descriptionTextBox.Leave += descriptionTextBox_Leave;
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(97, 179);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(187, 23);
            typeTextBox.TabIndex = 1;
            typeTextBox.TextChanged += typeTextBox_TextChanged;
            typeTextBox.Enter += typeTextBox_Enter;
            typeTextBox.Leave += typeTextBox_Leave;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(97, 220);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(187, 23);
            statusTextBox.TabIndex = 2;
            statusTextBox.TextChanged += statusTextBox_TextChanged;
            statusTextBox.Enter += statusTextBox_Enter;
            statusTextBox.Leave += statusTextBox_Leave;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.WhiteSmoke;
            cancelBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            cancelBtn.FlatAppearance.BorderSize = 2;
            cancelBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(200, 337);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(84, 33);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.WhiteSmoke;
            saveBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            saveBtn.FlatAppearance.BorderSize = 2;
            saveBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.Location = new Point(97, 337);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(84, 33);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // crimeComboBox
            // 
            crimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            crimeComboBox.FormattingEnabled = true;
            crimeComboBox.Location = new Point(97, 259);
            crimeComboBox.Name = "crimeComboBox";
            crimeComboBox.Size = new Size(187, 23);
            crimeComboBox.TabIndex = 7;
            // 
            // EvidenceEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 382);
            Controls.Add(crimeComboBox);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(statusTextBox);
            Controls.Add(typeTextBox);
            Controls.Add(descriptionTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EvidenceEditForm";
            Text = "EvidenceEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descriptionTextBox;
        private TextBox typeTextBox;
        private TextBox statusTextBox;
        private Button cancelBtn;
        private Button saveBtn;
        private ComboBox crimeComboBox;
    }
}