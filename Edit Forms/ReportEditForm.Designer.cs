namespace CrimelabHelper.Edit_Forms
{
    partial class ReportEditForm
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
            crimeComboBox = new ComboBox();
            expertComboBox = new ComboBox();
            descriptionTextBox = new TextBox();
            repConclusionsTextBox = new TextBox();
            reportDateTimePicker = new DateTimePicker();
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
            cancelBtn.Location = new Point(232, 337);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(84, 33);
            cancelBtn.TabIndex = 14;
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
            saveBtn.Location = new Point(71, 337);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(84, 33);
            saveBtn.TabIndex = 13;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // crimeComboBox
            // 
            crimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            crimeComboBox.FormattingEnabled = true;
            crimeComboBox.Location = new Point(11, 42);
            crimeComboBox.Name = "crimeComboBox";
            crimeComboBox.Size = new Size(31, 23);
            crimeComboBox.TabIndex = 15;
            // 
            // expertComboBox
            // 
            expertComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            expertComboBox.FormattingEnabled = true;
            expertComboBox.Location = new Point(217, 305);
            expertComboBox.Name = "expertComboBox";
            expertComboBox.Size = new Size(170, 23);
            expertComboBox.TabIndex = 16;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(48, 42);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(339, 23);
            descriptionTextBox.TabIndex = 17;
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            descriptionTextBox.Enter += descriptionTextBox_Enter;
            descriptionTextBox.Leave += descriptionTextBox_Leave;
            // 
            // repConclusionsTextBox
            // 
            repConclusionsTextBox.Location = new Point(12, 71);
            repConclusionsTextBox.Multiline = true;
            repConclusionsTextBox.Name = "repConclusionsTextBox";
            repConclusionsTextBox.Size = new Size(376, 228);
            repConclusionsTextBox.TabIndex = 18;
            repConclusionsTextBox.TextChanged += repConclusionsTextBox_TextChanged;
            repConclusionsTextBox.Enter += repConclusionsTextBox_Enter;
            repConclusionsTextBox.Leave += repConclusionsTextBox_Leave;
            // 
            // reportDateTimePicker
            // 
            reportDateTimePicker.Location = new Point(11, 305);
            reportDateTimePicker.Name = "reportDateTimePicker";
            reportDateTimePicker.Size = new Size(200, 23);
            reportDateTimePicker.TabIndex = 19;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Teal;
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(400, 36);
            topPanel.TabIndex = 20;
            topPanel.MouseDown += topPanel_MouseDown;
            topPanel.MouseMove += topPanel_MouseMove;
            // 
            // ReportEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 382);
            Controls.Add(topPanel);
            Controls.Add(reportDateTimePicker);
            Controls.Add(repConclusionsTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(expertComboBox);
            Controls.Add(crimeComboBox);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button saveBtn;
        private ComboBox crimeComboBox;
        private ComboBox expertComboBox;
        private TextBox descriptionTextBox;
        private TextBox repConclusionsTextBox;
        private DateTimePicker reportDateTimePicker;
        private Panel topPanel;
    }
}