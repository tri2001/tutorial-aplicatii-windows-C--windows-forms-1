namespace AplicatieWindowsForms
{
    partial class FereastraPrincipala
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
            this.lblNume = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.btAdauga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMasculin = new System.Windows.Forms.RadioButton();
            this.rbFeminin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(45, 36);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(102, 33);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 20);
            this.tbNume.TabIndex = 1;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(102, 59);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(100, 20);
            this.tbTelefon.TabIndex = 3;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(45, 62);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon";
            // 
            // btAdauga
            // 
            this.btAdauga.Location = new System.Drawing.Point(102, 115);
            this.btAdauga.Name = "btAdauga";
            this.btAdauga.Size = new System.Drawing.Size(100, 23);
            this.btAdauga.TabIndex = 4;
            this.btAdauga.Text = "Adauga persoana";
            this.btAdauga.UseVisualStyleBackColor = true;
            this.btAdauga.Click += new System.EventHandler(this.LaClickPeAdauga);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gen";
            // 
            // rbMasculin
            // 
            this.rbMasculin.AutoSize = true;
            this.rbMasculin.Checked = true;
            this.rbMasculin.Location = new System.Drawing.Point(102, 89);
            this.rbMasculin.Name = "rbMasculin";
            this.rbMasculin.Size = new System.Drawing.Size(34, 17);
            this.rbMasculin.TabIndex = 6;
            this.rbMasculin.TabStop = true;
            this.rbMasculin.Text = "M";
            this.rbMasculin.UseVisualStyleBackColor = true;
            // 
            // rbFeminin
            // 
            this.rbFeminin.AutoSize = true;
            this.rbFeminin.Location = new System.Drawing.Point(142, 89);
            this.rbFeminin.Name = "rbFeminin";
            this.rbFeminin.Size = new System.Drawing.Size(31, 17);
            this.rbFeminin.TabIndex = 7;
            this.rbFeminin.TabStop = true;
            this.rbFeminin.Text = "F";
            this.rbFeminin.UseVisualStyleBackColor = true;
            // 
            // FereastraPrincipala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 150);
            this.Controls.Add(this.rbFeminin);
            this.Controls.Add(this.rbMasculin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdauga);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.lblNume);
            this.Name = "FereastraPrincipala";
            this.ShowIcon = false;
            this.Text = "Fereastra mea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Button btAdauga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMasculin;
        private System.Windows.Forms.RadioButton rbFeminin;
    }
}

