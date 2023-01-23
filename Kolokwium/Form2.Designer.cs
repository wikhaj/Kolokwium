namespace Kolokwium
{
    partial class Form2
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
            this.Matematyka = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Matematyka
            // 
            this.Matematyka.AutoSize = true;
            this.Matematyka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Matematyka.Location = new System.Drawing.Point(38, 60);
            this.Matematyka.Name = "Matematyka";
            this.Matematyka.Size = new System.Drawing.Size(121, 28);
            this.Matematyka.TabIndex = 0;
            this.Matematyka.Text = "Matematyka";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "kalkulator prosty";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Matematyka);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Matematyka;
        private Button button1;
    }
}