namespace HRSystem
{
    partial class display
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
            this.depLabel = new System.Windows.Forms.Label();
            this.depTB = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // depLabel
            // 
            this.depLabel.AutoSize = true;
            this.depLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depLabel.Location = new System.Drawing.Point(12, 106);
            this.depLabel.Name = "depLabel";
            this.depLabel.Size = new System.Drawing.Size(241, 23);
            this.depLabel.TabIndex = 0;
            this.depLabel.Text = "Enter Department Name";
            // 
            // depTB
            // 
            this.depTB.Location = new System.Drawing.Point(315, 106);
            this.depTB.Name = "depTB";
            this.depTB.Size = new System.Drawing.Size(182, 20);
            this.depTB.TabIndex = 1;
            this.depTB.TextChanged += new System.EventHandler(this.depTB_TextChanged);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(226, 227);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 262);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.depTB);
            this.Controls.Add(this.depLabel);
            this.Name = "display";
            this.Text = "display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label depLabel;
        private System.Windows.Forms.TextBox depTB;
        private System.Windows.Forms.Button displayButton;
    }
}