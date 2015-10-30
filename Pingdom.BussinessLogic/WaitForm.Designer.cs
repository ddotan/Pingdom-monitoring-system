namespace Pingdom.BussinessLogic
{
    partial class WaitForm
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
            this.labelWait = new System.Windows.Forms.Label();
            this.progressBarWait = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // labelWait
            // 
            this.labelWait.AutoSize = true;
            this.labelWait.Font = new System.Drawing.Font("Miriam", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelWait.Location = new System.Drawing.Point(81, 3);
            this.labelWait.Name = "labelWait";
            this.labelWait.Size = new System.Drawing.Size(207, 37);
            this.labelWait.TabIndex = 0;
            this.labelWait.Text = "Please Wait";
            // 
            // progressBarWait
            // 
            this.progressBarWait.Location = new System.Drawing.Point(83, 43);
            this.progressBarWait.Name = "progressBarWait";
            this.progressBarWait.Size = new System.Drawing.Size(205, 23);
            this.progressBarWait.TabIndex = 1;
            // 
            // WaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(363, 78);
            this.Controls.Add(this.progressBarWait);
            this.Controls.Add(this.labelWait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WaitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWait;
        private System.Windows.Forms.ProgressBar progressBarWait;
    }
}