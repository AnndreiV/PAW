namespace SubiectEngleza___ListView
{
    partial class EditForm
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
            this.numericNrZbor = new System.Windows.Forms.NumericUpDown();
            this.numericCapacitate = new System.Windows.Forms.NumericUpDown();
            this.textBoxDestinatie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericNrZbor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericNrZbor
            // 
            this.numericNrZbor.Location = new System.Drawing.Point(249, 68);
            this.numericNrZbor.Name = "numericNrZbor";
            this.numericNrZbor.Size = new System.Drawing.Size(120, 22);
            this.numericNrZbor.TabIndex = 0;
            this.numericNrZbor.Validating += new System.ComponentModel.CancelEventHandler(this.numericNrZbor_Validating);
            this.numericNrZbor.Validated += new System.EventHandler(this.numericNrZbor_Validated);
            // 
            // numericCapacitate
            // 
            this.numericCapacitate.Location = new System.Drawing.Point(249, 167);
            this.numericCapacitate.Name = "numericCapacitate";
            this.numericCapacitate.Size = new System.Drawing.Size(120, 22);
            this.numericCapacitate.TabIndex = 1;
            this.numericCapacitate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCapacitate.Validating += new System.ComponentModel.CancelEventHandler(this.numericCapacitate_Validating);
            this.numericCapacitate.Validated += new System.EventHandler(this.numericCapacitate_Validated);
            // 
            // textBoxDestinatie
            // 
            this.textBoxDestinatie.Location = new System.Drawing.Point(249, 117);
            this.textBoxDestinatie.Name = "textBoxDestinatie";
            this.textBoxDestinatie.Size = new System.Drawing.Size(120, 22);
            this.textBoxDestinatie.TabIndex = 2;
            this.textBoxDestinatie.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDestinatie_Validating);
            this.textBoxDestinatie.Validated += new System.EventHandler(this.textBoxDestinatie_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numar zbor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destinatie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Capacitate:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.Location = new System.Drawing.Point(538, 314);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(160, 97);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(92, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 97);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDestinatie);
            this.Controls.Add(this.numericCapacitate);
            this.Controls.Add(this.numericNrZbor);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericNrZbor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericNrZbor;
        private System.Windows.Forms.NumericUpDown numericCapacitate;
        private System.Windows.Forms.TextBox textBoxDestinatie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}