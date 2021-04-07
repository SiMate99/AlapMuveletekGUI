
namespace AlapMuveletek
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.műveletekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.összeadásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kivonásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szorzásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osztásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbFeladat = new System.Windows.Forms.TextBox();
            this.tbValasz = new System.Windows.Forms.TextBox();
            this.lbStatisztika = new System.Windows.Forms.ListBox();
            this.btEllenoriz = new System.Windows.Forms.Button();
            this.btUjKerdes = new System.Windows.Forms.Button();
            this.btMegoldas = new System.Windows.Forms.Button();
            this.tbEredmeny = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feladat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eredmény:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Statisztika:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Válaszod:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.műveletekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(346, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // műveletekToolStripMenuItem
            // 
            this.műveletekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.összeadásToolStripMenuItem,
            this.kivonásToolStripMenuItem,
            this.szorzásToolStripMenuItem,
            this.osztásToolStripMenuItem});
            this.műveletekToolStripMenuItem.Name = "műveletekToolStripMenuItem";
            this.műveletekToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.műveletekToolStripMenuItem.Text = "Műveletek";
            // 
            // összeadásToolStripMenuItem
            // 
            this.összeadásToolStripMenuItem.Name = "összeadásToolStripMenuItem";
            this.összeadásToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.összeadásToolStripMenuItem.Text = "Összeadás";
            // 
            // kivonásToolStripMenuItem
            // 
            this.kivonásToolStripMenuItem.Name = "kivonásToolStripMenuItem";
            this.kivonásToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.kivonásToolStripMenuItem.Text = "Kivonás";
            // 
            // szorzásToolStripMenuItem
            // 
            this.szorzásToolStripMenuItem.Name = "szorzásToolStripMenuItem";
            this.szorzásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.szorzásToolStripMenuItem.Text = "Szorzás";
            this.szorzásToolStripMenuItem.Click += new System.EventHandler(this.szorzásToolStripMenuItem_Click);
            // 
            // osztásToolStripMenuItem
            // 
            this.osztásToolStripMenuItem.Name = "osztásToolStripMenuItem";
            this.osztásToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.osztásToolStripMenuItem.Text = "Osztás";
            this.osztásToolStripMenuItem.Click += new System.EventHandler(this.osztásToolStripMenuItem_Click);
            // 
            // tbFeladat
            // 
            this.tbFeladat.Location = new System.Drawing.Point(16, 59);
            this.tbFeladat.Name = "tbFeladat";
            this.tbFeladat.ReadOnly = true;
            this.tbFeladat.Size = new System.Drawing.Size(100, 20);
            this.tbFeladat.TabIndex = 5;
            // 
            // tbValasz
            // 
            this.tbValasz.Location = new System.Drawing.Point(16, 129);
            this.tbValasz.Name = "tbValasz";
            this.tbValasz.Size = new System.Drawing.Size(100, 20);
            this.tbValasz.TabIndex = 6;
            // 
            // lbStatisztika
            // 
            this.lbStatisztika.FormattingEnabled = true;
            this.lbStatisztika.Items.AddRange(new object[] {
            "Összeadás: 0/0",
            "Kivonás: 0/0",
            "Szorzás: 0/0",
            "Osztás: 0/0"});
            this.lbStatisztika.Location = new System.Drawing.Point(16, 231);
            this.lbStatisztika.Name = "lbStatisztika";
            this.lbStatisztika.Size = new System.Drawing.Size(120, 95);
            this.lbStatisztika.TabIndex = 7;
            // 
            // btEllenoriz
            // 
            this.btEllenoriz.Location = new System.Drawing.Point(16, 156);
            this.btEllenoriz.Name = "btEllenoriz";
            this.btEllenoriz.Size = new System.Drawing.Size(75, 23);
            this.btEllenoriz.TabIndex = 8;
            this.btEllenoriz.Text = "Ellenőrzés";
            this.btEllenoriz.UseVisualStyleBackColor = true;
            this.btEllenoriz.Click += new System.EventHandler(this.btEllenoriz_Click);
            // 
            // btUjKerdes
            // 
            this.btUjKerdes.Location = new System.Drawing.Point(178, 346);
            this.btUjKerdes.Name = "btUjKerdes";
            this.btUjKerdes.Size = new System.Drawing.Size(75, 23);
            this.btUjKerdes.TabIndex = 9;
            this.btUjKerdes.Text = "Új kérdés";
            this.btUjKerdes.UseVisualStyleBackColor = true;
            // 
            // btMegoldas
            // 
            this.btMegoldas.Location = new System.Drawing.Point(259, 346);
            this.btMegoldas.Name = "btMegoldas";
            this.btMegoldas.Size = new System.Drawing.Size(75, 23);
            this.btMegoldas.TabIndex = 10;
            this.btMegoldas.Text = "Megoldas";
            this.btMegoldas.UseVisualStyleBackColor = true;
            this.btMegoldas.Click += new System.EventHandler(this.btMegoldas_Click);
            // 
            // tbEredmeny
            // 
            this.tbEredmeny.Location = new System.Drawing.Point(221, 129);
            this.tbEredmeny.Name = "tbEredmeny";
            this.tbEredmeny.ReadOnly = true;
            this.tbEredmeny.Size = new System.Drawing.Size(100, 20);
            this.tbEredmeny.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 381);
            this.Controls.Add(this.tbEredmeny);
            this.Controls.Add(this.btMegoldas);
            this.Controls.Add(this.btUjKerdes);
            this.Controls.Add(this.btEllenoriz);
            this.Controls.Add(this.lbStatisztika);
            this.Controls.Add(this.tbValasz);
            this.Controls.Add(this.tbFeladat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Alap Műveletek";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox tbFeladat;
        private System.Windows.Forms.TextBox tbValasz;
        private System.Windows.Forms.ListBox lbStatisztika;
        private System.Windows.Forms.Button btEllenoriz;
        private System.Windows.Forms.Button btUjKerdes;
        private System.Windows.Forms.Button btMegoldas;
        private System.Windows.Forms.TextBox tbEredmeny;
        private System.Windows.Forms.ToolStripMenuItem műveletekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem összeadásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kivonásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szorzásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osztásToolStripMenuItem;
    }
}

