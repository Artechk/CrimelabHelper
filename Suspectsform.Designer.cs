namespace CrimelabHelper
{
    partial class Suspectsform
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
            suspectsList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)suspectsList).BeginInit();
            SuspendLayout();
            // 
            // suspectsList
            // 
            suspectsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            suspectsList.BackgroundColor = SystemColors.ControlLight;
            suspectsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suspectsList.Location = new Point(12, 12);
            suspectsList.Name = "suspectsList";
            suspectsList.ReadOnly = true;
            suspectsList.Size = new Size(776, 362);
            suspectsList.TabIndex = 2;
            // 
            // Suspectsform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 453);
            Controls.Add(suspectsList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Suspectsform";
            Text = "Suspectsform";
            ((System.ComponentModel.ISupportInitialize)suspectsList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView suspectsList;
    }
}