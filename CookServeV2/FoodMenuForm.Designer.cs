namespace CookServeV2
{
    partial class FoodMenuForm
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
            this.tbdButton4 = new System.Windows.Forms.Button();
            this.tbdButton3 = new System.Windows.Forms.Button();
            this.tbdButton2 = new System.Windows.Forms.Button();
            this.tbdButton = new System.Windows.Forms.Button();
            this.burgerButton = new System.Windows.Forms.Button();
            this.pizzaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbdButton4
            // 
            this.tbdButton4.Enabled = false;
            this.tbdButton4.Location = new System.Drawing.Point(549, 279);
            this.tbdButton4.Name = "tbdButton4";
            this.tbdButton4.Size = new System.Drawing.Size(183, 143);
            this.tbdButton4.TabIndex = 5;
            this.tbdButton4.Text = "coming soon";
            this.tbdButton4.UseVisualStyleBackColor = true;
            // 
            // tbdButton3
            // 
            this.tbdButton3.Enabled = false;
            this.tbdButton3.Location = new System.Drawing.Point(311, 279);
            this.tbdButton3.Name = "tbdButton3";
            this.tbdButton3.Size = new System.Drawing.Size(183, 143);
            this.tbdButton3.TabIndex = 6;
            this.tbdButton3.Text = "coming soon";
            this.tbdButton3.UseVisualStyleBackColor = true;
            // 
            // tbdButton2
            // 
            this.tbdButton2.Enabled = false;
            this.tbdButton2.Location = new System.Drawing.Point(68, 279);
            this.tbdButton2.Name = "tbdButton2";
            this.tbdButton2.Size = new System.Drawing.Size(183, 143);
            this.tbdButton2.TabIndex = 7;
            this.tbdButton2.Text = "coming soon";
            this.tbdButton2.UseVisualStyleBackColor = true;
            // 
            // tbdButton
            // 
            this.tbdButton.Enabled = false;
            this.tbdButton.Location = new System.Drawing.Point(549, 86);
            this.tbdButton.Name = "tbdButton";
            this.tbdButton.Size = new System.Drawing.Size(183, 143);
            this.tbdButton.TabIndex = 8;
            this.tbdButton.Text = "coming soon";
            this.tbdButton.UseVisualStyleBackColor = true;
            // 
            // burgerButton
            // 
            this.burgerButton.Enabled = false;
            this.burgerButton.Location = new System.Drawing.Point(311, 86);
            this.burgerButton.Name = "burgerButton";
            this.burgerButton.Size = new System.Drawing.Size(183, 143);
            this.burgerButton.TabIndex = 9;
            this.burgerButton.Text = "coming soon";
            this.burgerButton.UseVisualStyleBackColor = true;
            // 
            // pizzaButton
            // 
            this.pizzaButton.Image = global::CookServeV2.Properties.Resources.MenuPizza;
            this.pizzaButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pizzaButton.Location = new System.Drawing.Point(68, 86);
            this.pizzaButton.Name = "pizzaButton";
            this.pizzaButton.Size = new System.Drawing.Size(183, 143);
            this.pizzaButton.TabIndex = 4;
            this.pizzaButton.UseVisualStyleBackColor = true;
            this.pizzaButton.Click += new System.EventHandler(this.pizzaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "MENU";
            // 
            // FoodMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbdButton4);
            this.Controls.Add(this.tbdButton3);
            this.Controls.Add(this.tbdButton2);
            this.Controls.Add(this.tbdButton);
            this.Controls.Add(this.burgerButton);
            this.Controls.Add(this.pizzaButton);
            this.Controls.Add(this.label1);
            this.Name = "FoodMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbdButton4;
        private System.Windows.Forms.Button tbdButton3;
        private System.Windows.Forms.Button tbdButton2;
        private System.Windows.Forms.Button tbdButton;
        private System.Windows.Forms.Button burgerButton;
        private System.Windows.Forms.Button pizzaButton;
        private System.Windows.Forms.Label label1;
    }
}

