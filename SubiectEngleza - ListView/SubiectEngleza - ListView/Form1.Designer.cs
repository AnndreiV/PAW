namespace SubiectEngleza___ListView
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
            this.zboruriLv = new System.Windows.Forms.ListView();
            this.colNumar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.collDestinatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.collCapacitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adgBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareBinaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareBinaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zboruriLv
            // 
            this.zboruriLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNumar,
            this.collDestinatie,
            this.collCapacitate});
            this.zboruriLv.FullRowSelect = true;
            this.zboruriLv.HideSelection = false;
            this.zboruriLv.Location = new System.Drawing.Point(46, 98);
            this.zboruriLv.MultiSelect = false;
            this.zboruriLv.Name = "zboruriLv";
            this.zboruriLv.Size = new System.Drawing.Size(578, 261);
            this.zboruriLv.TabIndex = 0;
            this.zboruriLv.UseCompatibleStateImageBehavior = false;
            this.zboruriLv.View = System.Windows.Forms.View.Details;
            this.zboruriLv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.zboruriLv_MouseDoubleClick);
            // 
            // colNumar
            // 
            this.colNumar.Text = "nrZbor";
            this.colNumar.Width = 155;
            // 
            // collDestinatie
            // 
            this.collDestinatie.Text = "destinatie";
            this.collDestinatie.Width = 136;
            // 
            // collCapacitate
            // 
            this.collCapacitate.Text = "capacitate";
            this.collCapacitate.Width = 129;
            // 
            // adgBtn
            // 
            this.adgBtn.Location = new System.Drawing.Point(643, 238);
            this.adgBtn.Name = "adgBtn";
            this.adgBtn.Size = new System.Drawing.Size(136, 105);
            this.adgBtn.TabIndex = 1;
            this.adgBtn.Text = "Adauga Zbor";
            this.adgBtn.UseVisualStyleBackColor = true;
            this.adgBtn.Click += new System.EventHandler(this.adgBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareBinaraToolStripMenuItem,
            this.deserializareBinaraToolStripMenuItem,
            this.serializareXMLToolStripMenuItem,
            this.deserializareXMLToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // serializareBinaraToolStripMenuItem
            // 
            this.serializareBinaraToolStripMenuItem.Name = "serializareBinaraToolStripMenuItem";
            this.serializareBinaraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serializareBinaraToolStripMenuItem.Text = "Serializare binara";
            this.serializareBinaraToolStripMenuItem.Click += new System.EventHandler(this.serializareBinaraToolStripMenuItem_Click);
            // 
            // deserializareBinaraToolStripMenuItem
            // 
            this.deserializareBinaraToolStripMenuItem.Name = "deserializareBinaraToolStripMenuItem";
            this.deserializareBinaraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deserializareBinaraToolStripMenuItem.Text = "Deserializare binara";
            this.deserializareBinaraToolStripMenuItem.Click += new System.EventHandler(this.deserializareBinaraToolStripMenuItem_Click);
            // 
            // serializareXMLToolStripMenuItem
            // 
            this.serializareXMLToolStripMenuItem.Name = "serializareXMLToolStripMenuItem";
            this.serializareXMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serializareXMLToolStripMenuItem.Text = "Serializare XML";
            this.serializareXMLToolStripMenuItem.Click += new System.EventHandler(this.serializareXMLToolStripMenuItem_Click);
            // 
            // deserializareXMLToolStripMenuItem
            // 
            this.deserializareXMLToolStripMenuItem.Name = "deserializareXMLToolStripMenuItem";
            this.deserializareXMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deserializareXMLToolStripMenuItem.Text = "Deserializare XML";
            this.deserializareXMLToolStripMenuItem.Click += new System.EventHandler(this.deserializareXMLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adgBtn);
            this.Controls.Add(this.zboruriLv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView zboruriLv;
        private System.Windows.Forms.ColumnHeader colNumar;
        private System.Windows.Forms.ColumnHeader collDestinatie;
        private System.Windows.Forms.ColumnHeader collCapacitate;
        private System.Windows.Forms.Button adgBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareBinaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareBinaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareXMLToolStripMenuItem;
    }
}

