using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDecimal_18007979
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_ReplaceBooks_Click(object sender, EventArgs e)
        {
            ReplacingBooks replacingBooks = new ReplacingBooks();
            this.Hide();
            replacingBooks.Show();
        }

        private void Btn_AreaIdentify_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!!!");
            //IdentifyingArea_s identifyingArea_S = new IdentifyingArea_s();
            //this.Hide();
            //identifyingArea_S.Show();
        }

        private void Btn_FindCallNumbers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!!!");
            //FindingCallNumbers findingCallNumbers = new FindingCallNumbers();
            //this.Hide();
            //findingCallNumbers.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
