namespace BibliotekaSQL_v0._1
{
    partial class main_menu
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
            this.pokaz_wypozyczenia = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pokaz_czytelnikow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pokaz_wypozyczenia
            // 
            this.pokaz_wypozyczenia.Location = new System.Drawing.Point(12, 12);
            this.pokaz_wypozyczenia.Name = "pokaz_wypozyczenia";
            this.pokaz_wypozyczenia.Size = new System.Drawing.Size(138, 35);
            this.pokaz_wypozyczenia.TabIndex = 0;
            this.pokaz_wypozyczenia.Text = "Pokaż Wypożyczenia";
            this.pokaz_wypozyczenia.UseVisualStyleBackColor = true;
            this.pokaz_wypozyczenia.Click += new System.EventHandler(this.pokaz_wypozyczenia_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(554, 265);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pokaz_czytelnikow
            // 
            this.pokaz_czytelnikow.Location = new System.Drawing.Point(156, 12);
            this.pokaz_czytelnikow.Name = "pokaz_czytelnikow";
            this.pokaz_czytelnikow.Size = new System.Drawing.Size(138, 35);
            this.pokaz_czytelnikow.TabIndex = 2;
            this.pokaz_czytelnikow.Text = "Pokaż Czytelników";
            this.pokaz_czytelnikow.UseVisualStyleBackColor = true;
            this.pokaz_czytelnikow.Click += new System.EventHandler(this.pokaz_czytelnikow_Click);
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(578, 330);
            this.Controls.Add(this.pokaz_czytelnikow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pokaz_wypozyczenia);
            this.Name = "main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BibliotekaSQL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pokaz_wypozyczenia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button pokaz_czytelnikow;
    }
}

