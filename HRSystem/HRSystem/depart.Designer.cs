namespace HRSystem
{
    partial class depart
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
            this.depidLabel = new System.Windows.Forms.Label();
            this.depnameLabel = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // depidLabel
            // 
            this.depidLabel.AutoSize = true;
            this.depidLabel.Location = new System.Drawing.Point(69, 53);
            this.depidLabel.Name = "depidLabel";
            this.depidLabel.Size = new System.Drawing.Size(78, 13);
            this.depidLabel.TabIndex = 0;
            this.depidLabel.Text = "Department ID";
            // 
            // depnameLabel
            // 
            this.depnameLabel.AutoSize = true;
            this.depnameLabel.Location = new System.Drawing.Point(69, 111);
            this.depnameLabel.Name = "depnameLabel";
            this.depnameLabel.Size = new System.Drawing.Size(94, 13);
            this.depnameLabel.TabIndex = 1;
            this.depnameLabel.Text = "Department Name";
            this.depnameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(177, 46);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 20);
            this.idTB.TabIndex = 2;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(177, 104);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(151, 154);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // depart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 262);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.depnameLabel);
            this.Controls.Add(this.depidLabel);
            this.Name = "depart";
            this.Text = "depart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label depidLabel;
        private System.Windows.Forms.Label depnameLabel;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button addButton;
    }
}