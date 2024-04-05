
namespace Meeting_Bingo
{
    partial class uwuForm
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
            this.uwuLabel = new System.Windows.Forms.Label();
            this.uwuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uwuLabel
            // 
            this.uwuLabel.AutoSize = true;
            this.uwuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uwuLabel.Location = new System.Drawing.Point(24, 62);
            this.uwuLabel.Name = "uwuLabel";
            this.uwuLabel.Size = new System.Drawing.Size(366, 24);
            this.uwuLabel.TabIndex = 0;
            this.uwuLabel.Text = "Yay! UwU pwessed the fwee space button!";
            // 
            // uwuButton
            // 
            this.uwuButton.Location = new System.Drawing.Point(157, 130);
            this.uwuButton.Name = "uwuButton";
            this.uwuButton.Size = new System.Drawing.Size(100, 32);
            this.uwuButton.TabIndex = 1;
            this.uwuButton.Text = " ♥UwU♥";
            this.uwuButton.UseVisualStyleBackColor = true;
            this.uwuButton.Click += new System.EventHandler(this.uwuButton_Click);
            // 
            // uwuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 174);
            this.Controls.Add(this.uwuButton);
            this.Controls.Add(this.uwuLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "uwuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UwU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uwuLabel;
        private System.Windows.Forms.Button uwuButton;
    }
}