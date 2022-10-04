namespace ZeichnenFunktion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnZeichnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnZeichnen
            // 
            this.BtnZeichnen.Location = new System.Drawing.Point(315, 236);
            this.BtnZeichnen.Name = "BtnZeichnen";
            this.BtnZeichnen.Size = new System.Drawing.Size(75, 23);
            this.BtnZeichnen.TabIndex = 0;
            this.BtnZeichnen.Text = "Zeichnen";
            this.BtnZeichnen.UseVisualStyleBackColor = true;
            this.BtnZeichnen.Click += new System.EventHandler(this.BtnZeichnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 271);
            this.Controls.Add(this.BtnZeichnen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnZeichnen;
    }
}