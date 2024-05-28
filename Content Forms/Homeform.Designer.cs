namespace CrimelabHelper
{
    partial class Homeform
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
            homeList = new DataGridView();
            betweendtsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)homeList).BeginInit();
            SuspendLayout();
            // 
            // homeList
            // 
            homeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            homeList.BackgroundColor = SystemColors.ControlLight;
            homeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            homeList.Location = new Point(12, 12);
            homeList.Name = "homeList";
            homeList.ReadOnly = true;
            homeList.Size = new Size(776, 362);
            homeList.TabIndex = 3;
            // 
            // betweendtsBtn
            // 
            betweendtsBtn.BackColor = Color.WhiteSmoke;
            betweendtsBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            betweendtsBtn.FlatAppearance.BorderSize = 2;
            betweendtsBtn.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            betweendtsBtn.FlatStyle = FlatStyle.Flat;
            betweendtsBtn.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            betweendtsBtn.Location = new Point(986, 12);
            betweendtsBtn.Name = "betweendtsBtn";
            betweendtsBtn.Size = new Size(118, 51);
            betweendtsBtn.TabIndex = 9;
            betweendtsBtn.Text = "Add";
            betweendtsBtn.UseVisualStyleBackColor = false;
            betweendtsBtn.Click += betweendtsBtn_Click;
            // 
            // Homeform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 453);
            Controls.Add(betweendtsBtn);
            Controls.Add(homeList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Homeform";
            Text = "Homeform";
            ((System.ComponentModel.ISupportInitialize)homeList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView homeList;
        private Button betweendtsBtn;
    }
}