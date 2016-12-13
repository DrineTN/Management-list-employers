namespace Tp4
{
    partial class Recherche
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
            this.label1 = new System.Windows.Forms.Label();
            this.Ville = new System.Windows.Forms.TextBox();
            this.list1 = new System.Windows.Forms.ListBox();
            this.list2 = new System.Windows.Forms.ListBox();
            this.Rue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Vil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ville :";
            // 
            // Ville
            // 
            this.Ville.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ville.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Ville.Location = new System.Drawing.Point(290, 52);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(100, 20);
            this.Ville.TabIndex = 1;
            this.Ville.TextChanged += new System.EventHandler(this.Ville_TextChanged);
            this.Ville.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ville_keyPress);
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.Location = new System.Drawing.Point(50, 116);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(205, 186);
            this.list1.TabIndex = 2;
            // 
            // list2
            // 
            this.list2.FormattingEnabled = true;
            this.list2.Location = new System.Drawing.Point(406, 116);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(216, 186);
            this.list2.TabIndex = 3;
            this.list2.SelectedIndexChanged += new System.EventHandler(this.list2_SelectedIndexChanged);
            // 
            // Rue
            // 
            this.Rue.Location = new System.Drawing.Point(107, 336);
            this.Rue.Name = "Rue";
            this.Rue.ReadOnly = true;
            this.Rue.Size = new System.Drawing.Size(100, 20);
            this.Rue.TabIndex = 5;
            this.Rue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rue";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CP
            // 
            this.CP.Location = new System.Drawing.Point(329, 336);
            this.CP.Name = "CP";
            this.CP.ReadOnly = true;
            this.CP.Size = new System.Drawing.Size(100, 20);
            this.CP.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Code Postal";
            // 
            // Vil
            // 
            this.Vil.Location = new System.Drawing.Point(557, 332);
            this.Vil.Name = "Vil";
            this.Vil.ReadOnly = true;
            this.Vil.Size = new System.Drawing.Size(100, 20);
            this.Vil.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ville :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Les Adresses des Employés";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(403, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Resultat de la recherche";
            // 
            // Recherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 381);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Vil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list2);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.label1);
            this.Name = "Recherche";
            this.Text = "Recherche";
            this.Load += new System.EventHandler(this.Recherche_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ville;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.ListBox list2;
        private System.Windows.Forms.TextBox Rue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Vil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}