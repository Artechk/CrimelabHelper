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
            cancelBtn = new Button();
            saveBtn = new Button();
            crimeComboBox = new ComboBox();
            topPanel = new Panel();
            SuspendLayout();
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(12, 83);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(376, 149);
            descriptionTextBox.TabIndex = 1;
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            descriptionTextBox.Enter += descriptionTextBox_Enter;
            descriptionTextBox.Leave += descriptionTextBox_Leave;
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(97, 250);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(187, 23);
            typeTextBox.TabIndex = 2;
            typeTextBox.TextChanged += typeTextBox_TextChanged;
            typeTextBox.Enter += typeTextBox_Enter;
            typeTextBox.Leave += typeTextBox_Leave;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(97, 291);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(187, 23);
            statusTextBox.TabIndex = 3;
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
            cancelBtn.Location = new Point(200, 408);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(84, 33);
            cancelBtn.TabIndex = 0;
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
            saveBtn.Location = new Point(97, 408);
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
            crimeComboBox.Location = new Point(97, 330);
            crimeComboBox.Name = "crimeComboBox";
            crimeComboBox.Size = new Size(187, 23);
            crimeComboBox.TabIndex = 4;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Teal;
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(400, 51);
            topPanel.TabIndex = 8;
            topPanel.MouseDown += topPanel_MouseDown;
            topPanel.MouseMove += topPanel_MouseMove;
            // 
            // EvidenceEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 459);
            Controls.Add(topPanel);
            Controls.Add(crimeComboBox);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(statusTextBox);
            Controls.Add(typeTextBox);
            Controls.Add(descriptionTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EvidenceEditForm";
            Text = "In the shadowy corner, a lone pineapple slice perched on a murder weapon, the ultimate fruit of deception...";
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
        private Panel topPanel;
    }
}