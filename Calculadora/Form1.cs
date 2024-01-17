using System;
using System.Windows.Forms;

namespace Calculadora
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //VARIABLE GLOBAL
        public class Operaciones
        {
            public static double div;
            public static double mult;
            public static double sum;
            public static double resta;
            


        }
        string validar;


        private void button16_Click(object sender, EventArgs e)
        {




        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.TxtResultado.SelectionLength = 0;

            TxBxResultado.Text="0";
            

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

            int longitud = TxBxResultado.TextLength;

            char[] caracter = TxBxResultado.Text.ToCharArray();
            string[] quitar = new string[] { "0" };
            string a = TxBxResultado.Text;

            foreach (var c in quitar)
            {
                if (caracter[0] == '0')
                {
                    a = a.Replace(c, string.Empty);
                    TxBxResultado.Text = a;
                }
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = TxBxResultado.Text + "1";
            //numero 1

            int longitud = TxBxResultado.TextLength;

            char[] caracter = TxBxResultado.Text.ToCharArray();
            string[] quitar = new string[] { "0" };
            string a = TxBxResultado.Text;

            foreach (var c in quitar)
            {
                if (caracter[0] == '0')
                {
                    a = a.Replace(c, string.Empty);
                    TxBxResultado.Text = a;
                }
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = TxBxResultado.Text + "2";
            //numero 2
            int longitud = TxBxResultado.TextLength;

            char[] caracter = TxBxResultado.Text.ToCharArray();
            string[] quitar = new string[] { "0" };
            string a = TxBxResultado.Text;

            foreach (var c in quitar)
            {
                if (caracter[0] == '0')
                {
                    a = a.Replace(c, string.Empty);
                    TxBxResultado.Text = a;
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = TxBxResultado.Text + "3";
            //numero 3

            int longitud = TxBxResultado.TextLength;

            char[] caracter = TxBxResultado.Text.ToCharArray();
            string[] quitar = new string[] { "0" };
            string a = TxBxResultado.Text;

            foreach (var c in quitar)
            {
                if (caracter[0] == '0')
                {
                    a = a.Replace(c, string.Empty);
                    TxBxResultado.Text = a;
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = TxBxResultado.Text + "4";
            //numero 4
            int longitud = TxBxResultado.TextLength;

            char[] caracter = TxBxResultado.Text.ToCharArray();
            string[] quitar = new string[] { "0" };
            string a = TxBxResultado.Text;

            foreach (var c in quitar)
            {
                if (caracter[0] == '0')
                {
                    a = a.Replace(c, string.Empty);
                    TxBxResultado.Text = a;
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = TxBxResultado.Text + "5";
            //numero 5
            int longitud = TxBxResultado.TextLength;

            char[] caracter = TxBxResultado.Text.ToCharArray();
            string[] quitar = new string[] { "0" };
            string a = TxBxResultado.Text;

            foreach (var c in quitar)
            {
                if (caracter[0] == '0')
                {
                    a = a.Replace(c, string.Empty);
                    TxBxResultado.Text = a;
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = TxBxResultado.Text + "6";
            //numero 6

            int longitud = TxBxResultado.TextLength;

            char[] caracter = TxBxResultado.Text.ToCharArray();
            string[] quitar = new string[] { "0" };
            string a = TxBxResultado.Text;

            foreach (var c in quitar)
            {
                if (caracter[0] == '0')
                {
                    a = a.Replace(c, string.Empty);
                    TxBxResultado.Text = a;
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            TxBxResultado.Text = TxBxResultado.Text + "7";

            //numero 7
            int longitud = TxBxResultado.TextLength;

            char[] caracter = TxBxResultado.Text.ToCharArray();
            string[] quitar = new string[] { "0" };
            string a = TxBxResultado.Text;

            foreach (var c in quitar)
            {
                if (caracter[0] == '0')
                {
                    a = a.Replace(c, string.Empty);
                    TxBxResultado.Text = a;
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text = TxBxResultado.Text + "8";
            //numero 8
            int longitud = TxBxResultado.TextLength;

            char[] caracter = TxBxResultado.Text.ToCharArray();
            string[] quitar = new string[] { "0" };
            string a = TxBxResultado.Text;

            foreach (var c in quitar)
            {
                if (caracter[0] == '0')
                {
                    a = a.Replace(c, string.Empty);
                    TxBxResultado.Text = a;
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //numero 9
            TxBxResultado.Text = TxBxResultado.Text + "9";

            int longitud = TxBxResultado.TextLength;

            char[] caracter = TxBxResultado.Text.ToCharArray();
            string[] quitar = new string[] { "0" };
            string a = TxBxResultado.Text;

            foreach (var c in quitar)
            {
                if (caracter[0] == '0')
                {
                    a = a.Replace(c, string.Empty);
                    TxBxResultado.Text = a;
                }
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (TxBxResultado.Text.Length >1)
            //borrar
            {
                TxBxResultado.Text = TxBxResultado.Text.Substring(0,TxBxResultado.Text.Length - 1);
            }
            else
            {
                TxBxResultado.Text = "";
            }
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            TxBxResultado.Text="0"; //borrar todo
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
           

            //division
            //MessageBox.Show(TxBxResultado.Text);
            validar ="/";
            int longitud = TxBxResultado.TextLength;
            
            char[] caracter = TxBxResultado.Text.ToCharArray();
            string[] quitar= new string[] { "."};
            string a = TxBxResultado.Text;

          
                foreach (var c in quitar){

                if (caracter[longitud - 1] == '.')
                {

                    a = a.Replace(c, string.Empty);
                    TxBxResultado.Text = a;
                  
                }
               
                }

            Operaciones.div=Convert.ToDouble(TxBxResultado.Text);
            TxBxResultado.Clear();


            //public double num1;
            //MessageBox.Show(Convert.ToString(num1));




            //if (caracter[longitud-1]== '.')
            //{
            //    String f = Convert.ToString(caracter);
            //    MessageBox.Show(f);
            //    //for (int i = 0; i <= (longitud - 2); i++)
            //    //{
            //    //    vf = caracter[i];
            //    //    TxBxResultado.Text = (Convert.ToString(vf));

            //    //}

            //}


        }
        
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
           
            //multiplicacion
            validar ="x";
            int longitud = TxBxResultado.TextLength;

            char[] caracter = TxBxResultado.Text.ToCharArray();
            string[] quitar = new string[] { "." };
            string a = TxBxResultado.Text;


            foreach (var c in quitar)
            {

                if (caracter[longitud - 1] == '.')
                {

                    a = a.Replace(c, string.Empty);
                    TxBxResultado.Text = a;

                }

            }

            Operaciones.mult = Convert.ToDouble(TxBxResultado.Text);
            TxBxResultado.Clear();


        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            
            //Resta
            validar ="-";
            int longitud = TxBxResultado.TextLength;

            char[] caracter = TxBxResultado.Text.ToCharArray();
            string[] quitar = new string[] { "." };
            string a = TxBxResultado.Text;


            foreach (var c in quitar)
            {

                if (caracter[longitud - 1] == '.')
                {

                    a = a.Replace(c, string.Empty);
                    TxBxResultado.Text = a;

                }

            }
            Operaciones.resta = Convert.ToDouble(TxBxResultado.Text);
            TxBxResultado.Clear();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            
            //Suma
            validar ="+";
            int longitud = TxBxResultado.TextLength;

            char[] caracter = TxBxResultado.Text.ToCharArray();
            string[] quitar = new string[] { "." };
            string a = TxBxResultado.Text;


            foreach (var c in quitar)
            {

                if (caracter[longitud - 1] == '.')
                {

                    a = a.Replace(c, string.Empty);
                    TxBxResultado.Text = a;

                }

            }
            Operaciones.sum = Convert.ToDouble(TxBxResultado.Text);
            TxBxResultado.Clear();

        }

      

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double div, mult, sum, resta, resultado;


            switch (validar)
            {
                case "/":
                    div = Operaciones.div;

                    resultado = div / Convert.ToDouble(TxBxResultado.Text);

                    TxBxResultado.Text = Convert.ToString(resultado);
                    break;

                case "x":
                    mult = Operaciones.mult;
                    resultado = mult * Convert.ToDouble(TxBxResultado.Text);
                    TxBxResultado.Text = Convert.ToString(resultado);
                    break;

                case "+":
                    sum = Operaciones.sum;
                    resultado = sum + Convert.ToDouble(TxBxResultado.Text);
                    TxBxResultado.Text = Convert.ToString(resultado);
                    break;

                case "-":
                    resta = Operaciones.resta;
                    resultado = resta - Convert.ToDouble(TxBxResultado.Text);
                    TxBxResultado.Text = Convert.ToString(resultado);
                    break;

            }



            //if (btnDivision.Text == "/")
            //{
            //    div = Operaciones.div;

            //    resultado = div / Convert.ToDouble(TxBxResultado.Text);

            //    TxBxResultado.Text = Convert.ToString(resultado);

            //}

            //else if (btnMultiplicacion.Text == "x")
            //{
            //    mult = Operaciones.mult;
            //    resultado = mult * Convert.ToDouble(TxBxResultado.Text);
            //    TxBxResultado.Text = Convert.ToString(resultado);


            //}
            //else if (btnSuma.Text == "x")
            //{
            //    sum = Operaciones.sum;
            //    resultado = sum * Convert.ToDouble(TxBxResultado.Text);
            //    TxBxResultado.Text = Convert.ToString(resultado);

            //}
            //else if (btnResta.Text == "x")
            //{
            //    resta = Operaciones.resta;
            //    resultado = resta * Convert.ToDouble(TxBxResultado.Text);
            //    TxBxResultado.Text = Convert.ToString(resultado);

            //}



        }
    }
}
