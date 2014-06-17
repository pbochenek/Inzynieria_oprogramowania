namespace BibliotekaSQL_v0._2
{
    partial class FormNewWypozyczenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewWypozyczenie));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxCzytelnicy = new System.Windows.Forms.ListBox();
            this.listBoxKsiazka1 = new System.Windows.Forms.ListBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxCzytelnicy);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz czytelnika";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxKsiazka1);
            this.groupBox2.Location = new System.Drawing.Point(238, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wybierz książkę 1";
            // 
            // listBoxCzytelnicy
            // 
            this.listBoxCzytelnicy.FormattingEnabled = true;
            this.listBoxCzytelnicy.Items.AddRange(new object[] {
            "Marek\tKot",
            "Darek\tOtwórz",
            "Derek\tZamknij",
            "Antek\tMichał",
            "Maniek\tŚwięty",
            "Franek\tZaklęty",
            "Doniek\tNiewie"});
            this.listBoxCzytelnicy.Location = new System.Drawing.Point(7, 20);
            this.listBoxCzytelnicy.Name = "listBoxCzytelnicy";
            this.listBoxCzytelnicy.Size = new System.Drawing.Size(206, 69);
            this.listBoxCzytelnicy.TabIndex = 0;
            // 
            // listBoxKsiazka1
            // 
            this.listBoxKsiazka1.FormattingEnabled = true;
            this.listBoxKsiazka1.Items.AddRange(new object[] {
            "\"Autobiografia\"\tMarian\t\tKociniak\t\tNaukowe\t\t2000\t4",
            "\"Zielone kredki\"\tMariusz\t\tZłoty\t\tPWN\t\t1992\t1",
            "\"Czekolada\"\tCzesław\t\tNieśpiewa\tPWN\t\t2003\t2",
            "\"Robin i batman\"\tRobin\t\tHood\t\tUSA Enterprise\t2020\t1"});
            this.listBoxKsiazka1.Location = new System.Drawing.Point(7, 20);
            this.listBoxKsiazka1.Name = "listBoxKsiazka1";
            this.listBoxKsiazka1.Size = new System.Drawing.Size(456, 43);
            this.listBoxKsiazka1.TabIndex = 0;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(13, 120);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(219, 37);
            this.buttonDodaj.TabIndex = 3;
            this.buttonDodaj.Text = "Wypożycz";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(238, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 69);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wybierz książkę 2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "\"Autobiografia\"\tMarian\t\tKociniak\t\tNaukowe\t\t2000\t4",
            "\"Zielone kredki\"\tMariusz\t\tZłoty\t\tPWN\t\t1992\t1",
            "\"Czekolada\"\tCzesław\t\tNieśpiewa\tPWN\t\t2003\t2",
            "\"Robin i batman\"\tRobin\t\tHood\t\tUSA Enterprise\t2020\t1"});
            this.listBox1.Location = new System.Drawing.Point(7, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(456, 43);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox2);
            this.groupBox4.Location = new System.Drawing.Point(238, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(469, 69);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wybierz książkę 3";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "\"Autobiografia\"\tMarian\t\tKociniak\t\tNaukowe\t\t2000\t4",
            "\"Zielone kredki\"\tMariusz\t\tZłoty\t\tPWN\t\t1992\t1",
            "\"Czekolada\"\tCzesław\t\tNieśpiewa\tPWN\t\t2003\t2",
            "\"Robin i batman\"\tRobin\t\tHood\t\tUSA Enterprise\t2020\t1"});
            this.listBox2.Location = new System.Drawing.Point(7, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(456, 43);
            this.listBox2.TabIndex = 0;
            // 
            // FormNewWypozyczenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 242);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNewWypozyczenie";
            this.Text = "BibliotekaSQL - Nowe wypożyczenie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxCzytelnicy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxKsiazka1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox2;


    }
}