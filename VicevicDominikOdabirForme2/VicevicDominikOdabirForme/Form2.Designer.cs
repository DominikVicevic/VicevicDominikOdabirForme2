namespace VicevicDominikOdabirForme
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
            this.btnGoForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoForm1
            // 
            this.btnGoForm1.Location = new System.Drawing.Point(110, 125);
            this.btnGoForm1.Name = "btnGoForm1";
            this.btnGoForm1.Size = new System.Drawing.Size(115, 23);
            this.btnGoForm1.TabIndex = 0;
            this.btnGoForm1.Text = "Mijenjanje Forme";
            this.btnGoForm1.UseVisualStyleBackColor = true;
            this.btnGoForm1.Click += new System.EventHandler(this.btnGoForm1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 302);
            this.Controls.Add(this.btnGoForm1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoForm1;
    }
}