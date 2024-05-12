namespace CrimelabHelper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            topPanel = new Panel();
            programName = new Label();
            logo = new PictureBox();
            navigationPanel = new Panel();
            crimeBtn = new Button();
            homeBtn = new Button();
            contentPanel = new Panel();
            exitBtn = new Button();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            navigationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Teal;
            topPanel.Controls.Add(exitBtn);
            topPanel.Controls.Add(programName);
            topPanel.Controls.Add(logo);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1116, 74);
            topPanel.TabIndex = 0;
            // 
            // programName
            // 
            programName.AutoSize = true;
            programName.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            programName.ForeColor = SystemColors.ButtonHighlight;
            programName.Location = new Point(87, 23);
            programName.Name = "programName";
            programName.Size = new Size(143, 34);
            programName.TabIndex = 2;
            programName.Text = "LabHelper";
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(3, 0);
            logo.Name = "logo";
            logo.Size = new Size(78, 71);
            logo.SizeMode = PictureBoxSizeMode.CenterImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // navigationPanel
            // 
            navigationPanel.BackColor = Color.White;
            navigationPanel.Controls.Add(crimeBtn);
            navigationPanel.Controls.Add(homeBtn);
            navigationPanel.Dock = DockStyle.Top;
            navigationPanel.Location = new Point(0, 74);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(1116, 60);
            navigationPanel.TabIndex = 1;
            // 
            // crimeBtn
            // 
            crimeBtn.Location = new Point(127, 3);
            crimeBtn.Name = "crimeBtn";
            crimeBtn.Size = new Size(118, 51);
            crimeBtn.TabIndex = 1;
            crimeBtn.Text = "Crime";
            crimeBtn.UseVisualStyleBackColor = true;
            crimeBtn.Click += crimeBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.Location = new Point(3, 3);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(118, 51);
            homeBtn.TabIndex = 0;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // contentPanel
            // 
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 134);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1116, 453);
            contentPanel.TabIndex = 2;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(1083, 3);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(30, 27);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "X";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1116, 587);
            Controls.Add(contentPanel);
            Controls.Add(navigationPanel);
            Controls.Add(topPanel);
            Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            navigationPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private PictureBox logo;
        private Panel navigationPanel;
        private Label programName;
        private Panel contentPanel;
        private Button homeBtn;
        private Button crimeBtn;
        private Button exitBtn;
    }
}
