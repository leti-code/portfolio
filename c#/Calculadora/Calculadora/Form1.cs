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
        double v1, v2;
        string op, opPrev;
        bool opDone;

        public Form1()
        {
            InitializeComponent();
            v1 = 0;
            v2 = 0;
            opDone = false;
            opPrev = "";
        }

        private void ope_Click(object sender, EventArgs e)
        {
            
            /*Dos opciones:
             - Que no haya valor -> metemos en v1 el valor
            - Que haya un valor -> metemos en v2 el valor, calculamos, lo ponemos en el tb1, limpiamos v1 y v2*/
            Button srcButton = sender as Button;
            op = srcButton.Text;
            if (opPrev == "")
            {
                opPrev = op;
            }
            if(v1 == 0)
            {
                v1 = double.Parse(tb1.Text);
                lNum.Text = tb1.Text + " " + srcButton.Text + " ";
                tb1.Text = "0";

            }
            else
            {

                if (!opDone)
                {
                    lNum.Text = v1.ToString() + " " + opPrev + " " + tb1.Text;
                    bEq_Click(sender, e);
                }
                else
                {
                    lNum.Text = v1.ToString() + " " + opPrev + " ";
                }
            }
            opPrev = op;
        }
        private void bEq_Click(object sender, EventArgs e)
        {
            v2 = double.Parse(tb1.Text);
            lNum.Text = v1.ToString() + " " + opPrev + " " + tb1.Text;
            tb1.Text = calcular(v1, v2, opPrev);
            opDone = true;
            v1 = double.Parse(tb1.Text);
            v2 = 0;
        }

        private string calcular(double n1, double n2, string operando)
        {
            double resultado = 0;
            switch (operando)
            {
                case "+": resultado = v1 + v2; break;
                case "-": resultado = v1 - v2; break;
                case "*": resultado = v1 * v2; break;
                case "/":
                    try
                    {
                        resultado = v1 / v2; break;
                    }
                    catch(Exception e)
                    {
                        tb1.Text = "Error";
                        return "0";
                    }
            }
            return resultado.ToString();
        }
        private void num_Click(object sender, EventArgs e)
        {
            Button srcButton = sender as Button;
            if (tb1.Text == "0" || opDone)
            {
                tb1.Text = srcButton.Text;
                opDone = false;
            }
            else
            {
                tb1.Text += srcButton.Text;
            }

        }

        private void bDel_Click(object sender, EventArgs e)
        {
            v1 = 0;
            v2 = 0;
            lNum.Text = "";
            tb1.Text = "0";
        }

        private void bSign_Click(object sender, EventArgs e)
        {
            double num = double.Parse(tb1.Text);
            num = num * -1;
            tb1.Text = num.ToString();
        }

        private void bDelNum_Click(object sender, EventArgs e)
        {
            v2 = 0;
            tb1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text.Substring(0, tb1.Text.Length - 1);
        }


    }
}
