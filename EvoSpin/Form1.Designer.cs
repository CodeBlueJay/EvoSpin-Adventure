namespace EvoSpin
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
            this.roll = new System.Windows.Forms.Button();
            this.lblroll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roll
            // 
            this.roll.Location = new System.Drawing.Point(248, 58);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(130, 43);
            this.roll.TabIndex = 0;
            this.roll.Text = "Roll";
            this.roll.UseVisualStyleBackColor = true;
            this.roll.Click += new System.EventHandler(this.Roll_Click);
            // 
            // lblroll
            // 
            this.lblroll.AutoSize = true;
            this.lblroll.Location = new System.Drawing.Point(286, 123);
            this.lblroll.Name = "lblroll";
            this.lblroll.Size = new System.Drawing.Size(51, 20);
            this.lblroll.TabIndex = 1;
            this.lblroll.Text = "label1";
            this.lblroll.Click += new System.EventHandler(this.Lblroll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.lblroll);
            this.Controls.Add(this.roll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button roll;
        private System.Windows.Forms.Label lblroll;
    }
}

