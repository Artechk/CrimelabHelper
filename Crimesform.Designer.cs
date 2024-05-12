namespace CrimelabHelper
{
    partial class Crimesform
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
            crimeLabel = new Label();
            SuspendLayout();
            // 
            // crimeLabel
            // 
            crimeLabel.AutoSize = true;
            crimeLabel.Font = new Font("Unispace", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crimeLabel.Location = new Point(222, 180);
            crimeLabel.Name = "crimeLabel";
            crimeLabel.Size = new Size(291, 42);
            crimeLabel.TabIndex = 0;
            crimeLabel.Text = "i hate crimes";
            // 
            // Crimesform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(crimeLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Crimesform";
            Text = "Crimesform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label crimeLabel;
    }
}