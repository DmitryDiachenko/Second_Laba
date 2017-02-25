using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private string Zam = "";
		private string Two_commit = "Hello World!";
        // Формирование строки заказов
        public string Zamov(string c_box)
        {
            return Zam += c_box + "\n";
        }
		
		public string Commit(string c_box)
        {
            return c_box;
        }

        //Вывод заказов
        public void Show(string show)
        {
            if (show == "") show = "Ви нічого не замовили.";
            MessageBox.Show(show, "Замовлення");
        }
        // Очистка всех заказов
        public void Clear_Zam()
        {
           
            С1.Checked = false;
            С1.Enabled = true;

            C2.Checked = false;
            C2.Enabled = true;

            C3.Checked = false;
            C3.Enabled = true;

            C4.Checked = false;
            C4.Enabled = true;

            C5.Checked = false;
            C5.Enabled = true;

            C6.Checked = false;
            C6.Enabled = true;

            С7.Checked = false;
            С7.Enabled = true;

            C8.Checked = false;
            C8.Enabled = true;

            Zam = "";
        }
        private void С1_CheckedChanged(object sender, EventArgs e)
        {
            Zamov(С1.Text.ToString());
            С1.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Clear_Zam();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show(Zam);
        }

        private void C2_CheckedChanged(object sender, EventArgs e)
        {
            Zamov(C2.Text.ToString());
            C2.Enabled = false;
        }

        private void C3_CheckedChanged(object sender, EventArgs e)
        {
            Zamov(C3.Text.ToString());
            C3.Enabled = false;
        }

        private void C4_CheckedChanged(object sender, EventArgs e)
        {
            Zamov(C4.Text.ToString());
            C4.Enabled = false;
        }

        private void C5_CheckedChanged(object sender, EventArgs e)
        {
            Zamov(C5.Text.ToString());
            C5.Enabled = false;

        }

        private void C6_CheckedChanged(object sender, EventArgs e)
        {
            Zamov(C6.Text.ToString());
            C6.Enabled = false;
        }

        private void С7_CheckedChanged(object sender, EventArgs e)
        {
            Zamov(С7.Text.ToString());
            С7.Enabled = false;
        }

        private void C8_CheckedChanged(object sender, EventArgs e)
        {
            Zamov(C8.Text.ToString());
            C8.Enabled = false;
        }




    }
}
