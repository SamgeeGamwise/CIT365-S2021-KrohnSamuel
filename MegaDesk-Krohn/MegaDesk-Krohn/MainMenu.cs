using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Krohn
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addQuote_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddQuote addQuote = new AddQuote();
            addQuote.Show();
        }

        private void viewQuotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllQuotes viewQuotes = new ViewAllQuotes();
            viewQuotes.Show();
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
