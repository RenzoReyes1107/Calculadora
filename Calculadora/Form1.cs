using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           //this.TxtResultado.SelectionLength = 0;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = TxBxResultado.Text + ".";
            //punto
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = TxBxResultado.Text + "0";
            //numero 0
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = TxBxResultado.Text + "1";
            //numero 1
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = TxBxResultado.Text + "2";
            //numero 2
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = TxBxResultado.Text + "3";
            //numero 3
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = TxBxResultado.Text + "4";
            //numero 4
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = TxBxResultado.Text + "5";
            //numero 5
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = TxBxResultado.Text + "6";
            //numero 6
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            TxBxResultado.Text = TxBxResultado.Text+"7";

            //numero 7
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = TxBxResultado.Text + "8";
            //numero 8
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //numero 9
            TxBxResultado.Text = TxBxResultado.Text + "9";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //borrar
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = (""); //borrar todo
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            //division
            //MessageBox.Show(TxBxResultado.Text);

            int longitud = TxBxResultado.TextLength;
            
            char []caracter=TxBxResultado.Text.ToCharArray();
            char vf;
           

            if (caracter[longitud-1] == '.')
            {
                
                for (int i=0;i<=(longitud - 2);i++)
                {
                    vf=caracter[i];

                    TxBxResultado.AppendText(Convert.ToString(vf));
                    
                }
               
                
                
            }
   
        
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            //multiplicacion
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //Resta
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //Suma
        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
