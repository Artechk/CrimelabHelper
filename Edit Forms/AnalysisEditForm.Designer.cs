namespace CrimelabHelper.Edit_Forms
{
    partial class AnalysisEditForm
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
            resultTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            evidenceComboBox = new ComboBox();
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
            cancelBtn.Location = new Point(304, 337);
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
            saveBtn.Location = new Point(12, 337);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(84, 33);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(12, 44);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(376, 207);
            resultTextBox.TabIndex = 7;
            resultTextBox.Enter += resultTextBox_Enter;
            resultTextBox.Leave += resultTextBox_Leave;
            resultTextBox.TextChanged += resultTextBox_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 269);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(209, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // evidenceComboBox
            // 
            evidenceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            evidenceComboBox.FormattingEnabled = true;
            evidenceComboBox.Location = new Point(331, 269);
            evidenceComboBox.Name = "evidenceComboBox";
            evidenceComboBox.Size = new Size(57, 23);
            evidenceComboBox.TabIndex = 9;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Teal;
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(400, 38);
            topPanel.TabIndex = 10;
            topPanel.MouseMove += topPanel_MouseMove;
            topPanel.MouseDown += topPanel_MouseDown;
            // 
            // AnalysisEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 382);
            Controls.Add(topPanel);
            Controls.Add(evidenceComboBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(resultTextBox);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnalysisEditForm";
            Text = "AnalysisEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button saveBtn;
        private TextBox resultTextBox;
        private DateTimePicker dateTimePicker1;
        private ComboBox evidenceComboBox;
        private Panel topPanel;
    }
}