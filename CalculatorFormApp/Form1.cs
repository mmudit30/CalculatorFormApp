using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFormApp
{
    public partial class Form1 : Form
    {
        String c;
        double _result, num1, num2;
        public Form1()
        {
            _result = num1 = num2 = 0;
            MoveCursor();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(140, 140, 140);
            num1 = Convert.ToDouble(result.Text);
            num1 /= 100;
            result.Text = num1.ToString();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(140, 140, 140);
            num1 = Convert.ToDouble(result.Text);
            num1 = Math.Sqrt(num1);
            result.Text = num1.ToString();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(140, 140, 140);
            num1 = Convert.ToDouble(result.Text);
            num1 = num1*num1;
            result.Text = num1.ToString();
        }


        private void label4_Click(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(140, 140, 140);
            num1 = Convert.ToDouble(result.Text);
            num1 = 1/num1;
            result.Text = num1.ToString();

        }
        private void label5_Click(object sender, EventArgs e)
        {
            label5.BackColor = Color.FromArgb(140, 140, 140);
            result.Text = "";

        }
        private void label6_Click(object sender, EventArgs e)
        {
            label6.BackColor = Color.FromArgb(140, 140, 140);
            result.Text = "";
            step.Text = "";
            num2 = 0;
        }
        private void label7_Click(object sender, EventArgs e)
        {
            label7.BackColor = Color.FromArgb(140, 140, 140);
            if(result.Text.Length!=0)
                result.Text = (result.Text).Substring(0, result.Text.Length - 1);

        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.BackColor = Color.FromArgb(55,133,253);
            if (result.Text != "0")
            {
                num1 = Convert.ToDouble(result.Text);
                if (step.Text == "")
                {
                    step.Text = result.Text + "÷";
                    num2 = num1;

                }
                else
                {
                    num2 /= num1;

                    step.Text += result.Text + "÷";
                }
                result.Text = "0";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.BackColor = Color.FromArgb(140, 140, 140);
            if (result.Text == "" || result.Text=="0")
            {
                result.Text = "7";
            }
            else
            {
                result.Text += "7";
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {
            label10.BackColor = Color.FromArgb(140, 140, 140);
            if (result.Text == "" || result.Text == "0")
            {
                result.Text = "8";
            }
            else
            {
                result.Text += "8";
            }

        }
        private void label11_Click(object sender, EventArgs e)
        {
            label11.BackColor = Color.FromArgb(140, 140, 140);
            if (result.Text == "" || result.Text == "0")
            {
                result.Text = "9";
            }
            else
            {
                result.Text += "9";
            }
        }
        private void label12_Click(object sender, EventArgs e)
        {
            label12.BackColor = Color.FromArgb(55, 133, 253);
            if (result.Text != "0")
            {
                num1 = Convert.ToDouble(result.Text);
                if (step.Text == "")
                {
                    step.Text = result.Text + "⨯";
                    num2 = num1;

                }
                else
                {
                    num2 *= num1;
                    step.Text += result.Text + "⨯";
                }
                result.Text = "0";
            }
        }
        private void label13_Click(object sender, EventArgs e)
        {
            label13.BackColor = Color.FromArgb(140, 140, 140);
            if (result.Text == "" || result.Text == "0")
            {
                result.Text = "4";
            }
            else
            {
                result.Text += "4";
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            label14.BackColor = Color.FromArgb(140, 140, 140);
            if (result.Text == "" || result.Text == "0")
            {
                result.Text = "5";
            }
            else
            {
                result.Text += "5";
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            label15.BackColor = Color.FromArgb(140, 140, 140);
            if (result.Text == "" || result.Text == "0")
            {
                result.Text = "6";
            }
            else
            {
                result.Text += "6";
            }
        }


        private void label16_Click(object sender, EventArgs e)
        {
            label16.BackColor = Color.FromArgb(55, 133, 253);
            if (result.Text != "0" && result.Text != "")
            {
                c = "-";
                num1 = Convert.ToDouble(result.Text);
                if (step.Text == "")
                {
                    step.Text = result.Text + "-";
                    if (c.EndsWith("+"))
                        num2 = num1;
                    else if (c.EndsWith("-"))
                        num2 = num1;
                    else if (c.EndsWith("⨯"))
                        num2 = num1;
                    else if (c.EndsWith("÷"))
                        num2 = num1;
                }
                else
                {
                    step.Text += result.Text + "-";
                    if (c.EndsWith("+"))
                        num2 += num1;
                    else if (c.EndsWith("-"))
                        num2 -= num1;
                    else if (c.EndsWith("⨯"))
                        num2 *= num1;
                    else if (c.EndsWith("÷"))
                        num2 /= num1;
                }
                result.Text = "0";
            }
        }
        private void label17_Click(object sender, EventArgs e)
        {
            label17.BackColor = Color.FromArgb(140, 140, 140);
            if (result.Text == "" || result.Text == "0")
            {
                result.Text = "1";
            }
            else
            {
                result.Text += "1";
            }
        }
        private void label18_Click(object sender, EventArgs e)
        {
            label18.BackColor = Color.FromArgb(140, 140, 140);
            if (result.Text == "" || result.Text == "0")
            {
                result.Text = "2";
            }
            else
            {
                result.Text += "2";
            }
        }


        private void label19_Click(object sender, EventArgs e)
        {
            label19.BackColor = Color.FromArgb(140, 140, 140);
            if (result.Text == "" || result.Text == "0")
            {
                result.Text = "3";
            }
            else
            {
                result.Text += "3";
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            label20.BackColor = Color.FromArgb(55,133,253);

            if (result.Text != "0")
            {
                num1 = Convert.ToDouble(result.Text);
                
                if (step.Text == "")
                {
                    step.Text = result.Text + "+";
                    if (step.Text.EndsWith("+"))
                        num2 = num1;
                    else if (step.Text.EndsWith("-"))
                        num2 = num1;
                    else if (step.Text.EndsWith("⨯"))
                        num2 = num1;
                    else if (step.Text.EndsWith("÷"))
                        num2 = num1;

                }
                else
                {
                    step.Text += result.Text + "+";
                    if (step.Text.EndsWith("+"))
                        num2 += num1;
                    else if (step.Text.EndsWith("-"))
                        num2 -= num1;
                    else if (step.Text.EndsWith("⨯"))
                        num2 *= num1;
                    else if (step.Text.EndsWith("÷"))
                        num2 /= num1;

                }
                result.Text = "0";

                
            }


        }


        private void label21_Click(object sender, EventArgs e)
        {

            label21.BackColor = Color.FromArgb(140, 140, 140);
            if(result.Text.StartsWith("-"))
                result.Text = result.Text.Substring(1,result.Text.Length-1);
            else
            {
                result.Text = "-" + result.Text;
            }
        }



        private void label22_Click(object sender, EventArgs e)
        {
            label22.BackColor = Color.FromArgb(140, 140, 140);
            result.Text += "0";
            num1 =num2= 0;
        }

        private void label23_Click(object sender, EventArgs e)
        {
            label23.BackColor = Color.FromArgb(140, 140, 140);
            if(!result.Text.Contains("."))
                result.Text += ".";

        }

        private void label24_Click(object sender, EventArgs e)
        {
            label24.BackColor = Color.FromArgb(55, 133, 253);
            num1 = Convert.ToDouble(result.Text);
            if (step.Text.EndsWith("+"))
                num2 += num1;
            else if (step.Text.EndsWith("-"))
                num2 -= num1;
            else if (step.Text.EndsWith("⨯"))
                num2 *= num1;
            else if (step.Text.EndsWith("÷"))
                num2 /= num1;

            step.Text = "";
            result.Text = Convert.ToString(num2);
            num2 = num1 = 0;
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(115,115,115);
        }
        
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(115,115,115);

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(115,115,115);

        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(115,115,115);

        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.BackColor = Color.FromArgb(115,115,115);

        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.BackColor = Color.FromArgb(115,115,115);

        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.BackColor = Color.FromArgb(115,115,115);

        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.BackColor = Color.FromArgb(55, 133, 253);

        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.BackColor = Color.FromArgb(115,115,115);

        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.BackColor = Color.FromArgb(115,115,115);

        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            label11.BackColor = Color.FromArgb(115,115,115);

        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label12.BackColor = Color.FromArgb(55, 133, 253);

        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            label13.BackColor = Color.FromArgb(115,115,115);

        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label14.BackColor = Color.FromArgb(115,115,115);

        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label15.BackColor = Color.FromArgb(115,115,115);

        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            label16.BackColor = Color.FromArgb(55, 133, 253);

        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            label17.BackColor = Color.FromArgb(115,115,115);

        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            label18.BackColor = Color.FromArgb(115,115,115);

        }

        private void label19_MouseEnter(object sender, EventArgs e)
        {
            label19.BackColor = Color.FromArgb(115,115,115);

        }

        private void label20_MouseEnter(object sender, EventArgs e)
        {
            label20.BackColor = Color.FromArgb(55, 133, 253);

        }

        private void label21_MouseEnter(object sender, EventArgs e)
        {
            label21.BackColor = Color.FromArgb(115,115,115);

        }

        private void label22_MouseEnter(object sender, EventArgs e)
        {
            label22.BackColor = Color.FromArgb(115,115,115);

        }

        private void label23_MouseEnter(object sender, EventArgs e)
        {
            label23.BackColor = Color.FromArgb(115, 115, 115);

        }
        private void label24_MouseEnter(object sender, EventArgs e)
        {
            label24.BackColor = Color.FromArgb(55, 133, 253);

        }

        private void MoveCursor()
        {
            // Set the Current cursor, move the cursor's Position,
            // and set its clipping rectangle to the form. 

            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
         //   Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }

        
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(26,26,26);
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(26,26,26);
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(26,26,26);
        }
        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(26,26,26);
        }
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.FromArgb(26,26,26);
        }
        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.FromArgb(26,26,26);
        }
        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.FromArgb(26,26,26);
        }
        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.FromArgb(26,26,26);
        }
        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.BackColor = Color.FromArgb(13,13,13);
        }
        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.BackColor = Color.FromArgb(13,13,13);
        }
        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.BackColor = Color.FromArgb(13,13,13);
        }
        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.BackColor = Color.FromArgb(26,26,26);
        }
        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.BackColor = Color.FromArgb(13,13,13);
        }
        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.BackColor = Color.FromArgb(13,13,13);
        }
        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.BackColor = Color.FromArgb(13,13,13);
        }
        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label16.BackColor = Color.FromArgb(26,26,26);
        }
        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.BackColor = Color.FromArgb(13,13,13);
        }
        private void label18_MouseLeave(object sender, EventArgs e)
        {
            label18.BackColor = Color.FromArgb(13,13,13);
        }
        private void label19_MouseLeave(object sender, EventArgs e)
        {
            label19.BackColor = Color.FromArgb(13,13,13);
        }
        private void label20_MouseLeave(object sender, EventArgs e)
        {
            label20.BackColor = Color.FromArgb(26,26,26);
        }
        private void label21_MouseLeave(object sender, EventArgs e)
        {
            label21.BackColor = Color.FromArgb(26,26,26);
        }
        private void label22_MouseLeave(object sender, EventArgs e)
        {
            label22.BackColor = Color.FromArgb(13,13,13);
        }
        private void label23_MouseLeave(object sender, EventArgs e)
        {
            label23.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void label24_MouseLeave(object sender, EventArgs e)
        {
            label24.BackColor = Color.FromArgb(26, 26, 26);
        }

    }

}
