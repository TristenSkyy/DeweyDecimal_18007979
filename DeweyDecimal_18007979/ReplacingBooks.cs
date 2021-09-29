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
    public partial class ReplacingBooks : Form
    {
        List<string> callnumbers;
       
        public ReplacingBooks()
        {
            InitializeComponent();
            this.listBox1.AllowDrop = true;
            
        }

        private void ReplacingBooks_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.SelectAll();

            listBox1.DoDragDrop(textBox1.Text, DragDropEffects.All);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

            listBox1.Items.Add(e.Data.GetData(DataFormats.Text));

            if (listBox1.Items.Count == 10)
            {
                this.listBox1.AllowDrop = false;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Replacing_Books_Load(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.SelectAll();

            listBox1.DoDragDrop(textBox2.Text, DragDropEffects.All);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox3.SelectAll();

            listBox1.DoDragDrop(textBox3.Text, DragDropEffects.All);
        }

        private void textBox9_MouseDown(object sender, MouseEventArgs e)
        {
            textBox9.SelectAll();

            listBox1.DoDragDrop(textBox9.Text, DragDropEffects.All);
        }

        private void textBox8_MouseDown(object sender, MouseEventArgs e)
        {
            textBox8.SelectAll();

            listBox1.DoDragDrop(textBox8.Text, DragDropEffects.All);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_MouseDown(object sender, MouseEventArgs e)
        {
            textBox6.SelectAll();

            listBox1.DoDragDrop(textBox6.Text, DragDropEffects.All);
        }

        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {
            textBox4.SelectAll();

            listBox1.DoDragDrop(textBox4.Text, DragDropEffects.All);
        }

        private void textBox5_MouseDown(object sender, MouseEventArgs e)
        {
            textBox5.SelectAll();

            listBox1.DoDragDrop(textBox5.Text, DragDropEffects.All);
        }

        private void textBox10_MouseDown(object sender, MouseEventArgs e)
        {
            textBox10.SelectAll();

            listBox1.DoDragDrop(textBox10.Text, DragDropEffects.All);
        }

        private void textBox7_MouseDown(object sender, MouseEventArgs e)
        {
            textBox7.SelectAll();

            listBox1.DoDragDrop(textBox7.Text, DragDropEffects.All);
        }

       

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Answer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Generate_Click_1(object sender, EventArgs e)
        {
            GenerateNumbers CN = new GenerateNumbers();
            callnumbers = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                callnumbers.Add(CN.generates_call_numbers());
            }

            textBox1.Text = callnumbers[0];
            textBox2.Text = callnumbers[1];
            textBox3.Text = callnumbers[2];
            textBox4.Text = callnumbers[3];
            textBox5.Text = callnumbers[4];
            textBox6.Text = callnumbers[5];
            textBox7.Text = callnumbers[6];
            textBox8.Text = callnumbers[7];
            textBox9.Text = callnumbers[8];
            textBox10.Text = callnumbers[9];
        }

        private void Btn_Instructions_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("To play this game, drag the generated call numbers that appear on the right , " +
                "and add the numbers in the empty box shown on the left to sort the call numbers. ");
        }

        private void Btn_Enter_Click_1(object sender, EventArgs e)
        {
            callnumbers.Sort();
            List<string> answers = new List<string>();

            for (int loop = 0; loop < listBox1.Items.Count; loop++)

            {
                answers.Add(listBox1.Items[loop].ToString());
            }

            bool equal = true;
            for (int i = 0; i < callnumbers.Count && equal; i++)
            {
                if (!callnumbers[i].Equals(answers[i]))
                {
                    equal = false;
                }
            }

            if (equal)
            {
                MessageBox.Show("Well done! The order is correct", "WOW!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please try again", "Order incorrect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listBox1.Items.Clear();
                Btn_Generate_Click_1(sender, e);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
    

