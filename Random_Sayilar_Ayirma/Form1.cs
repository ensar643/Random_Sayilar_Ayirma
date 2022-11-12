using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Sayilar_Ayirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            listBox1.Items.Clear();
            for (int i = 0; i < 21; i++)
            {
                int sayi = rastgele.Next(100);
                listBox1.Items.Add(sayi);

                if (sayi % 2 != 0)
                {
                    listBox2.Items.Add(sayi);
                }

                if (sayi % 2 == 0)
                {
                    listBox3.Items.Add(sayi);
                }
            }
        }
    }
}
