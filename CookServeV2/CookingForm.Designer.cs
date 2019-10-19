namespace CookServeV2
{
    partial class CookingForm
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
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.BackColor = System.Drawing.Color.NavajoWhite;
            this.CustomerLabel.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(12, 541);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(901, 127);
            this.CustomerLabel.TabIndex = 4;
            this.CustomerLabel.Text = "ORDER GOES HERE";
            // 
            // CookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 677);
            this.Controls.Add(this.CustomerLabel);
            this.Name = "CookingForm";
            this.Text = "CookingForm";
            this.Load += new System.EventHandler(this.CookingForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CookingForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CustomerLabel;
    }
}