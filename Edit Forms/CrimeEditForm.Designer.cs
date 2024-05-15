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
            topPanel = new Panel();
            SuspendLayout();
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(84, 78);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(226, 23);
            descriptionTextBox.TabIndex = 1;
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            descriptionTextBox.Enter += descriptionTextBox_Enter;
            descriptionTextBox.Leave += descriptionTextBox_Leave;
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(84, 146);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(226, 23);
            typeTextBox.TabIndex = 2;
            typeTextBox.TextChanged += typeTextBox_TextChanged;
            typeTextBox.Enter += typeTextBox_Enter;
            typeTextBox.Leave += typeTextBox_Leave;
            // 
            // dateDateTimePicker
            // 
            dateDateTimePicker.Location = new Point(84, 214);
            dateDateTimePicker.Name = "dateDateTimePicker";
            dateDateTimePicker.Size = new Size(226, 23);
            dateDateTimePicker.TabIndex = 3;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.WhiteSmoke;
            saveBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            saveBtn.FlatAppearance.BorderSize = 2;
            saveBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.Location = new Point(84, 297);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(84, 33);
            saveBtn.TabIndex = 4;
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
            cancelBtn.Location = new Point(226, 297);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(84, 33);
            cancelBtn.TabIndex = 0;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Teal;
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(400, 51);
            topPanel.TabIndex = 9;
            topPanel.MouseDown += topPanel_MouseDown;
            topPanel.MouseMove += topPanel_MouseMove;
            // 
            // CrimeEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 382);
            Controls.Add(topPanel);
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
        private Panel topPanel;
    }
}