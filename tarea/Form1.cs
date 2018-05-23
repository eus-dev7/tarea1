using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea
{
    public partial class Form1 : Form
    {
        int[] notas = new int[40];
        int i = 1;
        int sum = 0;
        int baja = 9999;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i <= 5)
            {
                int calf = Convert.ToInt32(textBox1.Text);
                sum = sum + calf;
                if (calf < baja)
                {
                    baja = calf;
                }
                textBox1.Text = "";
                label3.Text = "nota n# " + Convert.ToString(i);
                i++;
            }
            else
            {
                imprimir();
            }
            
                
        }
        void imprimir()
        {
            txtmedia.Text = Convert.ToString(sum / 2);
            txtbaja.Text = Convert.ToString(baja);
            button1.Enabled = false;
        }
    }
}
