namespace CrimelabHelper
{
    partial class Evidenceform
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
            evidenceList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)evidenceList).BeginInit();
            SuspendLayout();
            // 
            // evidenceList
            // 
            evidenceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            evidenceList.BackgroundColor = SystemColors.ControlLight;
            evidenceList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            evidenceList.Location = new Point(12, 12);
            evidenceList.Name = "evidenceList";
            evidenceList.Size = new Size(776, 362);
            evidenceList.TabIndex = 1;
            evidenceList.CellContentClick += evidenceList_CellContentClick;
            // 
            // Evidenceform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 453);
            Controls.Add(evidenceList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Evidenceform";
            Text = "Evidenceform";
            ((System.ComponentModel.ISupportInitialize)evidenceList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView evidenceList;
    }
}