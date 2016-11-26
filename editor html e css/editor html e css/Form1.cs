using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace editor_html_e_css
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.DarkOrange;
        }
        private void UpdateBrowser()
        {
            web.DocumentText = HTML.Text.Replace("@RenderCSS", CSS.Text);
        }
        private void HTML_TextChanged(object sender, EventArgs e)
        {
            UpdateBrowser();
        }

        private void CSS_TextChanged(object sender, EventArgs e)
        {
            UpdateBrowser();
        }

        private void HTML_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateBrowser();
        }

        private void CSS_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateBrowser();
        }

       

        private void btn_CaricaFileHTML(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog ofd1 = new OpenFileDialog();
            if(ofd1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if((myStream=ofd1.OpenFile()) !=null)
                {
                    string strfilename = ofd1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    HTML.Text = filetext;
                }
            }
        }

        private void btn_CaricaFileCSS(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog ofd1 = new OpenFileDialog();
            if (ofd1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = ofd1.OpenFile()) != null)
                {
                    string strfilename = ofd1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    CSS.Text = filetext;
                }
            }
        }

        private void btn_SalvaSuFile(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt Files (*.txt)|*.txt|all files(*.*)|*.*|html(*.html)|*.html";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(HTML.Text);
                }

            }
        }

        private void Btn_Salva_css(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt Files (*.txt)|*.txt|all files(*.*)|*.*|html(*.html)|*.html";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(CSS.Text);
                }

            }
        }
        private void btn_esci(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
