namespace CrimelabHelper.Edit_Forms
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
            crimeIdTextBox = new TextBox();
            cancelBtn = new Button();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(97, 25);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(187, 23);
            descriptionTextBox.TabIndex = 0;
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(97, 65);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(187, 23);
            typeTextBox.TabIndex = 1;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(97, 107);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(187, 23);
            statusTextBox.TabIndex = 2;
            // 
            // crimeIdTextBox
            // 
            crimeIdTextBox.Location = new Point(97, 147);
            crimeIdTextBox.Name = "crimeIdTextBox";
            crimeIdTextBox.Size = new Size(187, 23);
            crimeIdTextBox.TabIndex = 3;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.WhiteSmoke;
            cancelBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            cancelBtn.FlatAppearance.BorderSize = 2;
            cancelBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(214, 226);
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
            saveBtn.Location = new Point(72, 226);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(84, 33);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // EvidenceEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 382);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(crimeIdTextBox);
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
        private TextBox crimeIdTextBox;
        private Button cancelBtn;
        private Button saveBtn;
    }
}