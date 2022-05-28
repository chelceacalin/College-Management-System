
namespace Proiect_PAW
{
    partial class FormUserControl
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
            this.buttonGetStudenti = new System.Windows.Forms.Button();
            this.userControl11 = new Proiect_PAW.UserControl1();
            this.SuspendLayout();
            // 
            // buttonGetStudenti
            // 
            this.buttonGetStudenti.BackColor = System.Drawing.Color.Snow;
            this.buttonGetStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetStudenti.Location = new System.Drawing.Point(299, 345);
            this.buttonGetStudenti.Name = "buttonGetStudenti";
            this.buttonGetStudenti.Size = new System.Drawing.Size(75, 23);
            this.buttonGetStudenti.TabIndex = 1;
            this.buttonGetStudenti.Text = "Apasa";
            this.buttonGetStudenti.UseVisualStyleBackColor = false;
            this.buttonGetStudenti.Click += new System.EventHandler(this.buttonGetStudenti_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(158, 84);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(369, 245);
            this.userControl11.TabIndex = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // FormUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGetStudenti);
            this.Controls.Add(this.userControl11);
            this.Name = "FormUserControl";
            this.Text = "FormUserControl";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private System.Windows.Forms.Button buttonGetStudenti;
    }
}