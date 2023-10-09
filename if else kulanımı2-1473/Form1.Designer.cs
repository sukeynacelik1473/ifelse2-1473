namespace if_else_kulanımı2_1473
{
    partial class Form1
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
            this.cbRed = new System.Windows.Forms.CheckBox();
            this.cbBlack = new System.Windows.Forms.CheckBox();
            this.cbBule = new System.Windows.Forms.CheckBox();
            this.cbPurple = new System.Windows.Forms.CheckBox();
            this.cbBrown = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbRed
            // 
            this.cbRed.AutoSize = true;
            this.cbRed.Location = new System.Drawing.Point(35, 56);
            this.cbRed.Name = "cbRed";
            this.cbRed.Size = new System.Drawing.Size(66, 17);
            this.cbRed.TabIndex = 0;
            this.cbRed.Text = "KIRMIZI";
            this.cbRed.UseVisualStyleBackColor = true;
            this.cbRed.CheckedChanged += new System.EventHandler(this.cbKırmızı_CheckedChanged);
            this.cbRed.Click += new System.EventHandler(this.cbKırmızı_Click);
            // 
            // cbBlack
            // 
            this.cbBlack.AutoSize = true;
            this.cbBlack.Location = new System.Drawing.Point(35, 102);
            this.cbBlack.Name = "cbBlack";
            this.cbBlack.Size = new System.Drawing.Size(58, 17);
            this.cbBlack.TabIndex = 1;
            this.cbBlack.Text = "SİYAH";
            this.cbBlack.UseVisualStyleBackColor = true;
            this.cbBlack.Click += new System.EventHandler(this.cbSıyah_Click);
            // 
            // cbBule
            // 
            this.cbBule.AutoSize = true;
            this.cbBule.Location = new System.Drawing.Point(35, 142);
            this.cbBule.Name = "cbBule";
            this.cbBule.Size = new System.Drawing.Size(52, 17);
            this.cbBule.TabIndex = 2;
            this.cbBule.Text = "MAVİ";
            this.cbBule.UseVisualStyleBackColor = true;
            this.cbBule.Click += new System.EventHandler(this.cbMavı_Click);
            // 
            // cbPurple
            // 
            this.cbPurple.AutoSize = true;
            this.cbPurple.Location = new System.Drawing.Point(35, 177);
            this.cbPurple.Name = "cbPurple";
            this.cbPurple.Size = new System.Drawing.Size(51, 17);
            this.cbPurple.TabIndex = 3;
            this.cbPurple.Text = "MOR";
            this.cbPurple.UseVisualStyleBackColor = true;
            this.cbPurple.CheckedChanged += new System.EventHandler(this.cbMor_CheckedChanged);
            // 
            // cbBrown
            // 
            this.cbBrown.AutoSize = true;
            this.cbBrown.Location = new System.Drawing.Point(35, 222);
            this.cbBrown.Name = "cbBrown";
            this.cbBrown.Size = new System.Drawing.Size(79, 17);
            this.cbBrown.TabIndex = 4;
            this.cbBrown.Text = "kahverengi";
            this.cbBrown.UseVisualStyleBackColor = true;
            this.cbBrown.CheckedChanged += new System.EventHandler(this.cbKahverengi_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbBrown);
            this.Controls.Add(this.cbPurple);
            this.Controls.Add(this.cbBule);
            this.Controls.Add(this.cbBlack);
            this.Controls.Add(this.cbRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbRed;
        private System.Windows.Forms.CheckBox cbBlack;
        private System.Windows.Forms.CheckBox cbBule;
        private System.Windows.Forms.CheckBox cbPurple;
        private System.Windows.Forms.CheckBox cbBrown;
    }
}

