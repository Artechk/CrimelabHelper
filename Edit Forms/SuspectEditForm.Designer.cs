namespace CrimelabHelper.Edit_Forms
{
    partial class SuspectEditForm
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
            nameTextBox = new TextBox();
            birthDateTimePicker = new DateTimePicker();
            addressTextBox = new TextBox();
            statusTextBox = new TextBox();
            crimeComboBox = new ComboBox();
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
            cancelBtn.Location = new Point(217, 307);
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
            saveBtn.Location = new Point(75, 307);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(84, 33);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(101, 73);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(188, 23);
            nameTextBox.TabIndex = 7;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            nameTextBox.Enter += nameTextBox_Enter;
            nameTextBox.Leave += nameTextBox_Leave;
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Location = new Point(96, 112);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(200, 23);
            birthDateTimePicker.TabIndex = 8;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(101, 153);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(188, 23);
            addressTextBox.TabIndex = 9;
            addressTextBox.TextChanged += addressTextBox_TextChanged;
            addressTextBox.Enter += addressTextBox_Enter;
            addressTextBox.Leave += addressTextBox_Leave;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(101, 193);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(188, 23);
            statusTextBox.TabIndex = 10;
            statusTextBox.TextChanged += statusTextBox_TextChanged;
            statusTextBox.Enter += statusTextBox_Enter;
            statusTextBox.Leave += statusTextBox_Leave;
            // 
            // crimeComboBox
            // 
            crimeComboBox.FormattingEnabled = true;
            crimeComboBox.Location = new Point(101, 235);
            crimeComboBox.Name = "crimeComboBox";
            crimeComboBox.Size = new Size(188, 23);
            crimeComboBox.TabIndex = 11;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Teal;
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(400, 51);
            topPanel.TabIndex = 12;
            // 
            // SuspectEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 382);
            Controls.Add(topPanel);
            Controls.Add(crimeComboBox);
            Controls.Add(statusTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(birthDateTimePicker);
            Controls.Add(nameTextBox);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuspectEditForm";
            Text = "SuspectEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button saveBtn;
        private TextBox nameTextBox;
        private DateTimePicker birthDateTimePicker;
        private TextBox addressTextBox;
        private TextBox statusTextBox;
        private ComboBox crimeComboBox;
        private Panel topPanel;
    }
}