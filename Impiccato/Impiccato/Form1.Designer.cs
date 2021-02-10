
namespace Impiccato
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_info = new System.Windows.Forms.Label();
            this.txt_ins = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_try = new System.Windows.Forms.Button();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lbl_info.Location = new System.Drawing.Point(34, 268);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(430, 37);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "Inserisci la lettera o la parola";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_info.Visible = false;
            // 
            // txt_ins
            // 
            this.txt_ins.Enabled = false;
            this.txt_ins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txt_ins.Location = new System.Drawing.Point(34, 319);
            this.txt_ins.Name = "txt_ins";
            this.txt_ins.Size = new System.Drawing.Size(430, 38);
            this.txt_ins.TabIndex = 1;
            this.txt_ins.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ins_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(550, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 350);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_try
            // 
            this.btn_try.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_try.Location = new System.Drawing.Point(34, 375);
            this.btn_try.Name = "btn_try";
            this.btn_try.Size = new System.Drawing.Size(430, 75);
            this.btn_try.TabIndex = 3;
            this.btn_try.Text = "INIZIA";
            this.btn_try.UseVisualStyleBackColor = true;
            this.btn_try.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_parola
            // 
            this.txt_parola.Enabled = false;
            this.txt_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txt_parola.Location = new System.Drawing.Point(41, 139);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.ReadOnly = true;
            this.txt_parola.Size = new System.Drawing.Size(423, 35);
            this.txt_parola.TabIndex = 4;
            this.txt_parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_error
            // 
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_error.Location = new System.Drawing.Point(41, 205);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(423, 41);
            this.lbl_error.TabIndex = 5;
            this.lbl_error.Text = "Premi il pulsante per continuare";
            this.lbl_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "L\'IMPICCATO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.txt_parola);
            this.Controls.Add(this.btn_try);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_ins);
            this.Controls.Add(this.lbl_info);
            this.Name = "Form1";
            this.Text = "Impiccato";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.TextBox txt_ins;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_try;
        private System.Windows.Forms.TextBox txt_parola;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label label1;
    }
}

