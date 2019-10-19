namespace CookServeV2
{
    partial class FoodKey
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
            this.KeyImage = new System.Windows.Forms.PictureBox();
            this.IngredientLabel = new System.Windows.Forms.Label();
            this.FoodKeyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KeyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // KeyImage
            // 
            this.KeyImage.Image = global::CookServeV2.Properties.Resources.foodKeyBackground;
            this.KeyImage.Location = new System.Drawing.Point(0, 0);
            this.KeyImage.Name = "KeyImage";
            this.KeyImage.Size = new System.Drawing.Size(66, 65);
            this.KeyImage.TabIndex = 0;
            this.KeyImage.TabStop = false;
            // 
            // IngredientLabel
            // 
            this.IngredientLabel.AutoSize = true;
            this.IngredientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.IngredientLabel.Location = new System.Drawing.Point(75, 31);
            this.IngredientLabel.Name = "IngredientLabel";
            this.IngredientLabel.Size = new System.Drawing.Size(173, 16);
            this.IngredientLabel.TabIndex = 1;
            this.IngredientLabel.Text = "INGREDIENT GOES HERE";
            // 
            // FoodKeyLabel
            // 
            this.FoodKeyLabel.AutoSize = true;
            this.FoodKeyLabel.BackColor = System.Drawing.Color.Tomato;
            this.FoodKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.FoodKeyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FoodKeyLabel.Location = new System.Drawing.Point(19, 21);
            this.FoodKeyLabel.Name = "FoodKeyLabel";
            this.FoodKeyLabel.Size = new System.Drawing.Size(0, 29);
            this.FoodKeyLabel.TabIndex = 2;
            // 
            // FoodKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FoodKeyLabel);
            this.Controls.Add(this.IngredientLabel);
            this.Controls.Add(this.KeyImage);
            this.Name = "FoodKey";
            this.Size = new System.Drawing.Size(232, 66);
            
            ((System.ComponentModel.ISupportInitialize)(this.KeyImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox KeyImage;
        private System.Windows.Forms.Label IngredientLabel;
        private System.Windows.Forms.Label FoodKeyLabel;
    }
}
