namespace CrimelabHelper.Edit_Forms
{
    partial class ExpertEditForm
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
            cancelBtn = new Button();
            saveBtn = new Button();
            contactinfoTextBox = new TextBox();
            specializationTextBox = new TextBox();
            nameTextBox = new TextBox();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.WhiteSmoke;
            cancelBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            cancelBtn.FlatAppearance.BorderSize = 2;
            cancelBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(214, 337);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(84, 33);
            cancelBtn.TabIndex = 12;
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
            saveBtn.Location = new Point(111, 337);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(84, 33);
            saveBtn.TabIndex = 11;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // contactinfoTextBox
            // 
            contactinfoTextBox.Location = new Point(111, 175);
            contactinfoTextBox.Multiline = true;
            contactinfoTextBox.Name = "contactinfoTextBox";
            contactinfoTextBox.Size = new Size(187, 67);
            contactinfoTextBox.TabIndex = 10;
            // 
            // specializationTextBox
            // 
            specializationTextBox.Location = new Point(111, 107);
            specializationTextBox.Name = "specializationTextBox";
            specializationTextBox.Size = new Size(187, 23);
            specializationTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(111, 39);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(187, 23);
            nameTextBox.TabIndex = 8;
            // 
            // ExpertEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 382);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(contactinfoTextBox);
            Controls.Add(specializationTextBox);
            Controls.Add(nameTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExpertEditForm";
            Text = "ExpertEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancelBtn;
        private Button saveBtn;
        private TextBox contactinfoTextBox;
        private TextBox specializationTextBox;
        private TextBox nameTextBox;
    }
}