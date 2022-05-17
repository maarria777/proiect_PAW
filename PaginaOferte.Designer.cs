
namespace proiect_PAW
{
    partial class PaginaOferte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaOferte));
            this.ofertabGridView1 = new System.Windows.Forms.DataGridView();
            this.adaugaInCos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ofertabGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ofertabGridView1
            // 
            this.ofertabGridView1.AllowUserToAddRows = false;
            this.ofertabGridView1.AllowUserToDeleteRows = false;
            this.ofertabGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ofertabGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ofertabGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ofertabGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.ofertabGridView1.Location = new System.Drawing.Point(29, 89);
            this.ofertabGridView1.Name = "ofertabGridView1";
            this.ofertabGridView1.ReadOnly = true;
            this.ofertabGridView1.RowHeadersWidth = 72;
            this.ofertabGridView1.RowTemplate.Height = 31;
            this.ofertabGridView1.Size = new System.Drawing.Size(1397, 611);
            this.ofertabGridView1.TabIndex = 0;
            // 
            // adaugaInCos
            // 
            this.adaugaInCos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.adaugaInCos.Location = new System.Drawing.Point(282, 762);
            this.adaugaInCos.Name = "adaugaInCos";
            this.adaugaInCos.Size = new System.Drawing.Size(887, 78);
            this.adaugaInCos.TabIndex = 3;
            this.adaugaInCos.Text = "Adauga in cos";
            this.adaugaInCos.UseVisualStyleBackColor = false;
            this.adaugaInCos.Click += new System.EventHandler(this.adaugaInCos_Click);
            // 
            // PaginaOferte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1473, 893);
            this.Controls.Add(this.adaugaInCos);
            this.Controls.Add(this.ofertabGridView1);
            this.Name = "PaginaOferte";
            this.Text = "PaginaOferte";
            ((System.ComponentModel.ISupportInitialize)(this.ofertabGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ofertabGridView1;
        private System.Windows.Forms.Button adaugaInCos;
    }
}

