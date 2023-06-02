using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_na_ppW
{
    public partial class formularzZapisu : Form
    {
        private string pathOfFile;
        public formularzZapisu(string path)
        {
            pathOfFile = path;
            InitializeComponent();
            StreamReader dane;
            try
            {
                dane = new StreamReader(pathOfFile);
                richTextBox1.Text = dane.ReadToEnd();
                dane.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }

        }

        private void save_Click(object sender, EventArgs e)
        {


            try
            {
                var plik = new StreamWriter(pathOfFile);
                plik.Write(richTextBox1.Text);
                plik.Close();
                MessageBox.Show("zmiany udało się pomyślnie zapisać, dziękujemy za skorzystanie z naszych usług");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.Close();
        }

        private void reject_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
