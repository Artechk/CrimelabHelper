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
            exitBtn = new Button();
            programName = new Label();
            logo = new PictureBox();
            navigationPanel = new Panel();
            suspectsBtn = new Button();
            analysisBtn = new Button();
            reportsBtn = new Button();
            expertsBtn = new Button();
            evidenceBtn = new Button();
            crimeBtn = new Button();
            homeBtn = new Button();
            contentPanel = new Panel();
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
            topPanel.MouseDown += topPanel_MouseDown;
            topPanel.MouseMove += topPanel_MouseMove;
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
            // programName
            // 
            programName.AutoSize = true;
            programName.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            programName.ForeColor = SystemColors.ButtonHighlight;
            programName.Location = new Point(87, 23);
            programName.Name = "programName";
            programName.Size = new Size(159, 33);
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
            navigationPanel.BackColor = Color.WhiteSmoke;
            navigationPanel.Controls.Add(suspectsBtn);
            navigationPanel.Controls.Add(analysisBtn);
            navigationPanel.Controls.Add(reportsBtn);
            navigationPanel.Controls.Add(expertsBtn);
            navigationPanel.Controls.Add(evidenceBtn);
            navigationPanel.Controls.Add(crimeBtn);
            navigationPanel.Controls.Add(homeBtn);
            navigationPanel.Dock = DockStyle.Top;
            navigationPanel.Location = new Point(0, 74);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(1116, 60);
            navigationPanel.TabIndex = 1;
            // 
            // suspectsBtn
            // 
            suspectsBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            suspectsBtn.FlatAppearance.BorderSize = 2;
            suspectsBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            suspectsBtn.FlatStyle = FlatStyle.Flat;
            suspectsBtn.Font = new Font("Georgia", 12F);
            suspectsBtn.Location = new Point(986, 3);
            suspectsBtn.Name = "suspectsBtn";
            suspectsBtn.Size = new Size(118, 51);
            suspectsBtn.TabIndex = 2;
            suspectsBtn.Text = "Suspects";
            suspectsBtn.UseVisualStyleBackColor = true;
            suspectsBtn.Click += suspectsBtn_Click;
            // 
            // analysisBtn
            // 
            analysisBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            analysisBtn.FlatAppearance.BorderSize = 2;
            analysisBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            analysisBtn.FlatStyle = FlatStyle.Flat;
            analysisBtn.Font = new Font("Georgia", 12F);
            analysisBtn.Location = new Point(862, 3);
            analysisBtn.Name = "analysisBtn";
            analysisBtn.Size = new Size(118, 51);
            analysisBtn.TabIndex = 2;
            analysisBtn.Text = "Analysis";
            analysisBtn.UseVisualStyleBackColor = true;
            analysisBtn.Click += analysisBtn_Click;
            // 
            // reportsBtn
            // 
            reportsBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            reportsBtn.FlatAppearance.BorderSize = 2;
            reportsBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            reportsBtn.FlatStyle = FlatStyle.Flat;
            reportsBtn.Font = new Font("Georgia", 12F);
            reportsBtn.Location = new Point(738, 3);
            reportsBtn.Name = "reportsBtn";
            reportsBtn.Size = new Size(118, 51);
            reportsBtn.TabIndex = 2;
            reportsBtn.Text = "Reports";
            reportsBtn.UseVisualStyleBackColor = true;
            reportsBtn.Click += reportsBtn_Click;
            // 
            // expertsBtn
            // 
            expertsBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            expertsBtn.FlatAppearance.BorderSize = 2;
            expertsBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            expertsBtn.FlatStyle = FlatStyle.Flat;
            expertsBtn.Font = new Font("Georgia", 12F);
            expertsBtn.Location = new Point(614, 3);
            expertsBtn.Name = "expertsBtn";
            expertsBtn.Size = new Size(118, 51);
            expertsBtn.TabIndex = 2;
            expertsBtn.Text = "Experts";
            expertsBtn.UseVisualStyleBackColor = true;
            expertsBtn.Click += expertsBtn_Click;
            // 
            // evidenceBtn
            // 
            evidenceBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            evidenceBtn.FlatAppearance.BorderSize = 2;
            evidenceBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            evidenceBtn.FlatStyle = FlatStyle.Flat;
            evidenceBtn.Font = new Font("Georgia", 12F);
            evidenceBtn.Location = new Point(490, 3);
            evidenceBtn.Name = "evidenceBtn";
            evidenceBtn.Size = new Size(118, 51);
            evidenceBtn.TabIndex = 2;
            evidenceBtn.Text = "Evidence";
            evidenceBtn.UseVisualStyleBackColor = true;
            evidenceBtn.Click += evidenceBtn_Click;
            // 
            // crimeBtn
            // 
            crimeBtn.BackColor = Color.WhiteSmoke;
            crimeBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            crimeBtn.FlatAppearance.BorderSize = 2;
            crimeBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            crimeBtn.FlatStyle = FlatStyle.Flat;
            crimeBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crimeBtn.Location = new Point(366, 3);
            crimeBtn.Name = "crimeBtn";
            crimeBtn.Size = new Size(118, 51);
            crimeBtn.TabIndex = 1;
            crimeBtn.Text = "Crime";
            crimeBtn.UseVisualStyleBackColor = false;
            crimeBtn.Click += crimeBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            homeBtn.FlatAppearance.BorderSize = 2;
            homeBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Font = new Font("Georgia", 12F);
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
        private Button suspectsBtn;
        private Button analysisBtn;
        private Button reportsBtn;
        private Button expertsBtn;
        private Button evidenceBtn;
    }
}
