using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SProgram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Number = Convert.ToInt32(number.Text);
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                result.Visible = true;
                sum.Visible = true;
                quantity.Visible = true;
                if (Number == 1)
                {
                    result.Text = "1";
                    sum.Text = "1";
                    quantity.Text = "1";
                }
                else if (Number == 0)
                    MessageBox.Show("Делителем 0 является любое число, отличное от него", "Сообщение");
                else
                {
                    int k = 2;
                    int summa = 1 + Number;
                    result.Text = "1" + ",";
                    for (int i = 2; i < Number; i++)
                    {
                        if (Number % i == 0)
                        {
                            result.Text += " " + i + ",";
                            k++;
                            summa += i;
                        }
                    }
                    result.Text += " " + Number;
                    quantity.Text = Convert.ToString(k);
                    sum.Text = Convert.ToString(summa);
                }
            }
            catch
            {
                MessageBox.Show("Введите число!", "Ошибка");
            }
        }
    }
}
