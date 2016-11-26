namespace editor_html_e_css
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.HTML = new System.Windows.Forms.RichTextBox();
            this.CSS = new System.Windows.Forms.RichTextBox();
            this.web = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HTML
            // 
            this.HTML.Location = new System.Drawing.Point(212, 59);
            this.HTML.Name = "HTML";
            this.HTML.Size = new System.Drawing.Size(286, 185);
            this.HTML.TabIndex = 0;
            this.HTML.Text = "";
            this.HTML.TextChanged += new System.EventHandler(this.HTML_TextChanged);
            this.HTML.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HTML_KeyUp);
            // 
            // CSS
            // 
            this.CSS.Location = new System.Drawing.Point(212, 267);
            this.CSS.Name = "CSS";
            this.CSS.Size = new System.Drawing.Size(286, 189);
            this.CSS.TabIndex = 1;
            this.CSS.Text = "";
            this.CSS.TextChanged += new System.EventHandler(this.CSS_TextChanged);
            this.CSS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CSS_KeyUp);
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(571, 59);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(293, 399);
            this.web.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(331, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "HTML";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(328, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CSS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(695, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "WEB";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(23, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 79);
            this.button1.TabIndex = 6;
            this.button1.Text = "SALVA PROGETTO SU FILE HTML";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_SalvaSuFile);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(23, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 79);
            this.button2.TabIndex = 7;
            this.button2.Text = "CARICA PROGETTO DA FILE SU HTML";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_CaricaFileHTML);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(52, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "ESCI";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btn_esci);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(23, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 79);
            this.button4.TabIndex = 9;
            this.button4.Text = "CARICA PROGETTO DA FILE SU CSS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_CaricaFileCSS);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(23, 324);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 79);
            this.button5.TabIndex = 10;
            this.button5.Text = "SALVA PROGETTO SU FILE CSS";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Btn_Salva_css);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 468);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.web);
            this.Controls.Add(this.CSS);
            this.Controls.Add(this.HTML);
            this.Name = "Form1";
            this.Text = "Editor HTML & CSS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox HTML;
        private System.Windows.Forms.RichTextBox CSS;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

