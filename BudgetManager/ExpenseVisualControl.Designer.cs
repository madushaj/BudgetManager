namespace BudgetManager
{
    partial class ExpenseVisualControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categoryLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.newProgressBar1 = new BudgetManager.NewProgressBar();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(33, 17);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(0, 20);
            this.categoryLabel.TabIndex = 1;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.Location = new System.Drawing.Point(399, 32);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(0, 17);
            this.valueLabel.TabIndex = 2;
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newProgressBar1
            // 
            this.newProgressBar1.Location = new System.Drawing.Point(37, 52);
            this.newProgressBar1.Name = "newProgressBar1";
            this.newProgressBar1.Size = new System.Drawing.Size(510, 16);
            this.newProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.newProgressBar1.TabIndex = 0;
            // 
            // ExpenseVisualControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.newProgressBar1);
            this.Name = "ExpenseVisualControl";
            this.Size = new System.Drawing.Size(587, 99);
            this.Load += new System.EventHandler(this.loadControl);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label categoryLabel;
        public System.Windows.Forms.Label valueLabel;
        public NewProgressBar newProgressBar1;
    }
}
