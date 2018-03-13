namespace VicevicDominikOdabirForme
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
            this.btnGoForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoForm2
            // 
            this.btnGoForm2.Location = new System.Drawing.Point(111, 125);
            this.btnGoForm2.Name = "btnGoForm2";
            this.btnGoForm2.Size = new System.Drawing.Size(125, 23);
            this.btnGoForm2.TabIndex = 0;
            this.btnGoForm2.Text = "Mijenjanje Forme";
            this.btnGoForm2.UseVisualStyleBackColor = true;
            this.btnGoForm2.Click += new System.EventHandler(this.btnGoForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 295);
            this.Controls.Add(this.btnGoForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoForm2;
    }
}

