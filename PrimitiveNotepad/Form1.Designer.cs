namespace PrimitiveNotepad
{
    partial class PrimitiveNotepad
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.newb = new System.Windows.Forms.Button();
            this.saveb = new System.Windows.Forms.Button();
            this.saveasb = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(-1, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(804, 403);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // newb
            // 
            this.newb.Location = new System.Drawing.Point(12, 6);
            this.newb.Name = "newb";
            this.newb.Size = new System.Drawing.Size(43, 37);
            this.newb.TabIndex = 1;
            this.newb.Text = "New";
            this.newb.UseVisualStyleBackColor = true;
            this.newb.Click += new System.EventHandler(this.Button1_Click);
            // 
            // saveb
            // 
            this.saveb.Enabled = false;
            this.saveb.Location = new System.Drawing.Point(61, 6);
            this.saveb.Name = "saveb";
            this.saveb.Size = new System.Drawing.Size(43, 37);
            this.saveb.TabIndex = 2;
            this.saveb.Text = "Save";
            this.saveb.UseVisualStyleBackColor = true;
            this.saveb.Click += new System.EventHandler(this.Saveb_Click);
            // 
            // saveasb
            // 
            this.saveasb.Location = new System.Drawing.Point(110, 6);
            this.saveasb.Name = "saveasb";
            this.saveasb.Size = new System.Drawing.Size(43, 37);
            this.saveasb.TabIndex = 3;
            this.saveasb.Text = "Save As";
            this.saveasb.UseVisualStyleBackColor = true;
            this.saveasb.Click += new System.EventHandler(this.Saveasb_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // PrimitiveNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveasb);
            this.Controls.Add(this.saveb);
            this.Controls.Add(this.newb);
            this.Controls.Add(this.richTextBox1);
            this.Name = "PrimitiveNotepad";
            this.Text = "PrimitiveNotepad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button newb;
        private System.Windows.Forms.Button saveb;
        private System.Windows.Forms.Button saveasb;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

