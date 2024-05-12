namespace CrimelabHelper
{
    partial class CrimeEditForm
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
            dateDateTimePicker = new DateTimePicker();
            saveBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(82, 41);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(226, 23);
            descriptionTextBox.TabIndex = 0;
            descriptionTextBox.Text = "description";
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(82, 109);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(226, 23);
            typeTextBox.TabIndex = 1;
            typeTextBox.Text = "type";
            // 
            // dateDateTimePicker
            // 
            dateDateTimePicker.Location = new Point(82, 177);
            dateDateTimePicker.Name = "dateDateTimePicker";
            dateDateTimePicker.Size = new Size(226, 23);
            dateDateTimePicker.TabIndex = 2;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.WhiteSmoke;
            saveBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            saveBtn.FlatAppearance.BorderSize = 2;
            saveBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.Location = new Point(82, 260);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(84, 33);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.WhiteSmoke;
            cancelBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            cancelBtn.FlatAppearance.BorderSize = 2;
            cancelBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(224, 260);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(84, 33);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // CrimeEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 382);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(dateDateTimePicker);
            Controls.Add(typeTextBox);
            Controls.Add(descriptionTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CrimeEditForm";
            Text = "CrimeEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descriptionTextBox;
        private TextBox typeTextBox;
        private DateTimePicker dateDateTimePicker;
        private Button saveBtn;
        private Button cancelBtn;
    }
}