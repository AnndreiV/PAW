namespace Subiect_PAW_engleza
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
            this.components = new System.ComponentModel.Container();
            this.zborTv = new System.Windows.Forms.TreeView();
            this.adaugaBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializareBinaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareBinaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zborTv
            // 
            this.zborTv.Location = new System.Drawing.Point(41, 49);
            this.zborTv.Name = "zborTv";
            this.zborTv.Size = new System.Drawing.Size(540, 272);
            this.zborTv.TabIndex = 0;
            this.zborTv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.zborTv_MouseDoubleClick);
            // 
            // adaugaBtn
            // 
            this.adaugaBtn.Location = new System.Drawing.Point(543, 334);
            this.adaugaBtn.Name = "adaugaBtn";
            this.adaugaBtn.Size = new System.Drawing.Size(208, 73);
            this.adaugaBtn.TabIndex = 1;
            this.adaugaBtn.Text = "Adauga un nou zbor";
            this.adaugaBtn.UseVisualStyleBackColor = true;
            this.adaugaBtn.Click += new System.EventHandler(this.adaugaBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareBinaraToolStripMenuItem,
            this.deserializareBinaraToolStripMenuItem,
            this.serializareXMLToolStripMenuItem,
            this.deserializareXMLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 128);
            // 
            // serializareBinaraToolStripMenuItem
            // 
            this.serializareBinaraToolStripMenuItem.Name = "serializareBinaraToolStripMenuItem";
            this.serializareBinaraToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.serializareBinaraToolStripMenuItem.Text = "Serializare Binara";
            this.serializareBinaraToolStripMenuItem.Click += new System.EventHandler(this.serializareBinaraToolStripMenuItem_Click);
            // 
            // deserializareBinaraToolStripMenuItem
            // 
            this.deserializareBinaraToolStripMenuItem.Name = "deserializareBinaraToolStripMenuItem";
            this.deserializareBinaraToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deserializareBinaraToolStripMenuItem.Text = "Deserializare Binara";
            this.deserializareBinaraToolStripMenuItem.Click += new System.EventHandler(this.deserializareBinaraToolStripMenuItem_Click);
            // 
            // serializareXMLToolStripMenuItem
            // 
            this.serializareXMLToolStripMenuItem.Name = "serializareXMLToolStripMenuItem";
            this.serializareXMLToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.serializareXMLToolStripMenuItem.Text = "Serializare XML";
            this.serializareXMLToolStripMenuItem.Click += new System.EventHandler(this.serializareXMLToolStripMenuItem_Click);
            // 
            // deserializareXMLToolStripMenuItem
            // 
            this.deserializareXMLToolStripMenuItem.Name = "deserializareXMLToolStripMenuItem";
            this.deserializareXMLToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deserializareXMLToolStripMenuItem.Text = "Deserializare XML";
            this.deserializareXMLToolStripMenuItem.Click += new System.EventHandler(this.deserializareXMLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.adaugaBtn);
            this.Controls.Add(this.zborTv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView zborTv;
        private System.Windows.Forms.Button adaugaBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializareBinaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareBinaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareXMLToolStripMenuItem;
    }
}

