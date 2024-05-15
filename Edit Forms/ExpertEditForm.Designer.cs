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
            topPanel = new Panel();
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
            contactinfoTextBox.Location = new Point(111, 233);
            contactinfoTextBox.Multiline = true;
            contactinfoTextBox.Name = "contactinfoTextBox";
            contactinfoTextBox.Size = new Size(187, 67);
            contactinfoTextBox.TabIndex = 10;
            contactinfoTextBox.TextChanged += contactinfoTextBox_TextChanged;
            contactinfoTextBox.Enter += contactinfoTextBox_Enter;
            contactinfoTextBox.Leave += contactinfoTextBox_Leave;
            // 
            // specializationTextBox
            // 
            specializationTextBox.Location = new Point(111, 142);
            specializationTextBox.Multiline = true;
            specializationTextBox.Name = "specializationTextBox";
            specializationTextBox.Size = new Size(187, 67);
            specializationTextBox.TabIndex = 9;
            specializationTextBox.TextChanged += specializationTextBox_TextChanged;
            specializationTextBox.Enter += specializationTextBox_Enter;
            specializationTextBox.Leave += specializationTextBox_Leave;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(111, 81);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(187, 23);
            nameTextBox.TabIndex = 8;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            nameTextBox.Enter += nameTextBox_Enter;
            nameTextBox.Leave += nameTextBox_Leave;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Teal;
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(400, 51);
            topPanel.TabIndex = 13;
            topPanel.MouseMove += topPanel_MouseMove;
            topPanel.MouseDown += topPanel_MouseDown;
            // 
            // ExpertEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 382);
            Controls.Add(topPanel);
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
        private Panel topPanel;
    }
}