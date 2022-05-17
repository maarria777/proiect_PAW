
namespace proiect_PAW
{
    partial class PaginaCoș
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
            this.articoleCosgv = new System.Windows.Forms.DataGridView();
            this.adaugaInCos = new System.Windows.Forms.Button();
            this.ModificaCos = new System.Windows.Forms.Button();
            this.StergeArticol = new System.Windows.Forms.Button();
            this.FinalizComanda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sumaPlata = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.articoleCosgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Articole";
            // 
            // articoleCosgv
            // 
            this.articoleCosgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articoleCosgv.Location = new System.Drawing.Point(52, 98);
            this.articoleCosgv.Name = "articoleCosgv";
            this.articoleCosgv.RowHeadersWidth = 72;
            this.articoleCosgv.RowTemplate.Height = 31;
            this.articoleCosgv.Size = new System.Drawing.Size(922, 130);
            this.articoleCosgv.TabIndex = 1;
            this.articoleCosgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // adaugaInCos
            // 
            this.adaugaInCos.Location = new System.Drawing.Point(52, 356);
            this.adaugaInCos.Name = "adaugaInCos";
            this.adaugaInCos.Size = new System.Drawing.Size(211, 57);
            this.adaugaInCos.TabIndex = 2;
            this.adaugaInCos.Text = "Adauga";
            this.adaugaInCos.UseVisualStyleBackColor = true;
            // 
            // ModificaCos
            // 
            this.ModificaCos.Location = new System.Drawing.Point(415, 356);
            this.ModificaCos.Name = "ModificaCos";
            this.ModificaCos.Size = new System.Drawing.Size(201, 57);
            this.ModificaCos.TabIndex = 3;
            this.ModificaCos.Text = "Modifica";
            this.ModificaCos.UseVisualStyleBackColor = true;
            // 
            // StergeArticol
            // 
            this.StergeArticol.Location = new System.Drawing.Point(792, 356);
            this.StergeArticol.Name = "StergeArticol";
            this.StergeArticol.Size = new System.Drawing.Size(182, 57);
            this.StergeArticol.TabIndex = 4;
            this.StergeArticol.Text = "Sterge";
            this.StergeArticol.UseVisualStyleBackColor = true;
            // 
            // FinalizComanda
            // 
            this.FinalizComanda.Location = new System.Drawing.Point(315, 474);
            this.FinalizComanda.Name = "FinalizComanda";
            this.FinalizComanda.Size = new System.Drawing.Size(406, 57);
            this.FinalizComanda.TabIndex = 5;
            this.FinalizComanda.Text = "Finalizeaza comanda";
            this.FinalizComanda.UseVisualStyleBackColor = true;
            this.FinalizComanda.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total de plata:";
            // 
            // sumaPlata
            // 
            this.sumaPlata.Location = new System.Drawing.Point(829, 270);
            this.sumaPlata.Name = "sumaPlata";
            this.sumaPlata.Size = new System.Drawing.Size(145, 29);
            this.sumaPlata.TabIndex = 7;
            this.sumaPlata.TextChanged += new System.EventHandler(this.sumaPlata_TextChanged);
            // 
            // PaginaCoș
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 625);
            this.Controls.Add(this.sumaPlata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FinalizComanda);
            this.Controls.Add(this.StergeArticol);
            this.Controls.Add(this.ModificaCos);
            this.Controls.Add(this.adaugaInCos);
            this.Controls.Add(this.articoleCosgv);
            this.Controls.Add(this.label1);
            this.Name = "PaginaCoș";
            this.Text = "Coș de cumpărături";
            ((System.ComponentModel.ISupportInitialize)(this.articoleCosgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView articoleCosgv;
        private System.Windows.Forms.Button adaugaInCos;
        private System.Windows.Forms.Button ModificaCos;
        private System.Windows.Forms.Button StergeArticol;
        private System.Windows.Forms.Button FinalizComanda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sumaPlata;
    }
}