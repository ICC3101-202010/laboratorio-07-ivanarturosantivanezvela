using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABORATORIO7
{
    public partial class Form1 : Form
    {
        string operation = "";
        double firstnumber,secondnumber;
        List<string> numeros = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Numericvalue(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (txtDisplay.Text.Trim()=="0")
            {
                txtDisplay.Text ="";
            }
 
            if (b.Text == ",")
            {
                if (!txtDisplay.Text.Contains(","))
                {
                    txtDisplay.Text = txtDisplay.Text + b.Text;
                }
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }


        }

        private void btncleanall_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void OperationalFunction(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstnumber = double.Parse(txtDisplay.Text);
            operation = b.Text;
            txtDisplay.Text="";

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text =="")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            secondnumber = double.Parse(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(firstnumber + secondnumber);
                    numeros.Add(txtDisplay.Text);
                    break;
                case "-":
                    txtDisplay.Text = Convert.ToString(firstnumber - secondnumber);
                    numeros.Add(txtDisplay.Text);
                    break;
                case "*":
                    txtDisplay.Text = Convert.ToString(firstnumber*secondnumber);
                    numeros.Add(txtDisplay.Text);
                    break;
                case "/":
                    if (secondnumber == 0)
                    {
                        txtDisplay.Text = "Math error";
                    }
                    else 
                    {
                        txtDisplay.Text = Convert.ToString(firstnumber / secondnumber);
                        numeros.Add(txtDisplay.Text);
                    }
                    break;
                default:
                    break;


            }
        }

        private void btnlastresult_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = numeros.Last();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
