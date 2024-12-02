using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    internal static class Program
    {

        new partial class Form1 : Form
        {
            public TextBox Solution;
            public Button Button1;
            public Button Button2;
            public Button Button3;
            public Button Button4;
            public Button Button5;
            public Button Button6;
            public Button Button7;
            public Button Button8;
            public Button Button9;
            public Button Button0;
            public Button ButtonMultiply;
            public Button ButtonPlus;
            public Button ButtonMinus;
            public Button ButtonDivide;
            public Button ButtonDo;
            public Button ResultBox;

            public double num1;
            public double num2;
            public double res;
            public string str1;
            public string str2;
            public string strres;
            public bool flag = false;
            public char op;
            public string Result;

            public Form1()
            {
                Button1 = new Button();
                Button2 = new Button();
                Button3 = new Button();
                Button4 = new Button();
                Button5 = new Button();
                Button6 = new Button();
                Button7 = new Button();
                Button8 = new Button();
                Button9 = new Button();
                Button0 = new Button();
                ButtonPlus = new Button();
                ButtonMinus = new Button();
                ButtonDivide = new Button();
                ButtonMultiply = new Button();
                ButtonDo = new Button();
                ResultBox = new Button();

                Button1.Size = new System.Drawing.Size(75, 75);
                Button2.Size = new System.Drawing.Size(75, 75);
                Button3.Size = new System.Drawing.Size(75, 75);
                Button4.Size = new System.Drawing.Size(75, 75);
                Button5.Size = new System.Drawing.Size(75, 75);
                Button6.Size = new System.Drawing.Size(75, 75);
                Button7.Size = new System.Drawing.Size(75, 75);
                Button8.Size = new System.Drawing.Size(75, 75);
                Button9.Size = new System.Drawing.Size(75, 75);
                ButtonPlus.Size = new System.Drawing.Size(75, 75);
                ButtonDivide.Size = new System.Drawing.Size(75, 75);
                ButtonMinus.Size = new System.Drawing.Size(75, 75);
                ButtonMultiply.Size = new System.Drawing.Size(75, 75);
                ButtonDo.Size = new System.Drawing.Size(75, 75);
                ResultBox.Size = new System.Drawing.Size(75, 75);
                Button0.Size = new System.Drawing.Size(75, 75);


                Button1.Location = new System.Drawing.Point(0, 0);
                Button2.Location = new System.Drawing.Point(75, 0);
                Button3.Location = new System.Drawing.Point(150, 0);
                Button4.Location = new System.Drawing.Point(0, 75);
                Button5.Location = new System.Drawing.Point(75, 75);
                Button6.Location = new System.Drawing.Point(150, 75);
                Button7.Location = new System.Drawing.Point(0, 150);
                Button8.Location = new System.Drawing.Point(75, 150);
                Button9.Location = new System.Drawing.Point(150, 150);
                ButtonDo.Location = new System.Drawing.Point(225, 0);
                ButtonPlus.Location = new System.Drawing.Point(225, 75);
                ButtonMultiply.Location = new System.Drawing.Point(300, 75);
                ButtonMinus.Location = new System.Drawing.Point(225, 150);
                ButtonDivide.Location = new System.Drawing.Point(300, 150);
                ResultBox.Location = new System.Drawing.Point(300, 0);
                Button0.Location = new System.Drawing.Point(75, 225);

                Button1.Text = "1";
                Button2.Text = "2";
                Button3.Text = "3";
                Button4.Text = "4";
                Button5.Text = "5";
                Button6.Text = "6";
                Button7.Text = "7";
                Button8.Text = "8";
                Button9.Text = "9";
                Button0.Text = "0";
                ButtonDo.Text = "Done";
                ButtonMultiply.Text = "X";
                ButtonDivide.Text = "/";
                ButtonPlus.Text = "+";
                ButtonMinus.Text = "-";
                ResultBox.Text = "Iron = Goat";

                ButtonPlus.BackColor = System.Drawing.Color.Green;
                ButtonMinus.BackColor = System.Drawing.Color.Blue;
                ButtonMultiply.BackColor = System.Drawing.Color.Red;
                ButtonDivide.BackColor = System.Drawing.Color.Yellow;

                Button1.Click += new EventHandler(Button1_Click);
                Button2.Click += new EventHandler(Button2_Click);
                Button3.Click += new EventHandler(Button3_Click);
                Button4.Click += new EventHandler(Button4_Click);
                Button5.Click += new EventHandler(Button5_Click);
                Button6.Click += new EventHandler(Button6_Click);
                Button7.Click += new EventHandler(Button7_Click);
                Button8.Click += new EventHandler(Button8_Click);
                Button9.Click += new EventHandler(Button9_Click);
                Button0.Click += new EventHandler(Button0_Click);
                ButtonPlus.Click += new EventHandler(ButtonPlus_Click);
                ButtonMinus.Click += new EventHandler(ButtonMinus_Click);
                ButtonMultiply.Click += new EventHandler(ButtonMultiply_Click);
                ButtonDivide.Click += new EventHandler(ButtonDivide_Click);
                ButtonDo.Click += new EventHandler(ButtonDone_Click);

                Controls.Add(Button1);
                Controls.Add(Button2);
                Controls.Add(Button3);
                Controls.Add(Button4);
                Controls.Add(Button5);
                Controls.Add(Button6);
                Controls.Add(Button7);
                Controls.Add(Button8);
                Controls.Add(Button9);
                Controls.Add(Button0);
                Controls.Add(ButtonDo);
                Controls.Add(ButtonDivide);
                Controls.Add(ButtonPlus);
                Controls.Add(ButtonMinus);
                Controls.Add(ButtonMultiply);
                Controls.Add(ResultBox);
            }

            private void ButtonMultiply_Click1(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void ButtonMinus_Click1(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            public void Button1_Click(object sender, EventArgs e)
            {
                if (flag == false)
                {
                    str1 = str1 + "1";
                } else
                {
                    str2 = str2 + "1";
                }

            }
            public void Button2_Click(object sender, EventArgs e)
            {
                if (flag == false)
                {
                    str1 = str1 + "2";
                }
                else
                {
                    str2 = str2 + "2";
                }

            }
            public void Button8_Click(object sender, EventArgs e)
            {
                if (flag == false)
                {
                    str1 = str1 + "8";
                }
                else
                {
                    str2 = str2 + "8";
                }

            }
            public void Button9_Click(object sender, EventArgs e)
            {
                if (flag == false)
                {
                    str1 = str1 + "9";
                }
                else
                {
                    str2 = str2 + "9";
                }

            }
            public void Button3_Click(object sender, EventArgs e)
            {
                if (flag == false)
                {
                    str1 = str1 + "3";
                }
                else
                {
                    str2 = str2 + "3";
                }

            }
            public void Button4_Click(object sender, EventArgs e)
            {
                if (flag == false)
                {
                    str1 = str1 + "4";
                }
                else
                {
                    str2 = str2 + "4";
                }

            }
            public void Button5_Click(object sender, EventArgs e)
            {
                if (flag == false)
                {
                    str1 = str1 + "5";
                }
                else
                {
                    str2 = str2 + "5";
                }

            }
            public void Button6_Click(object sender, EventArgs e)
            {
                if (flag == false)
                {
                    str1 = str1 + "6";
                }
                else
                {
                    str2 = str2 + "6";
                }

            }
            public void Button7_Click(object sender, EventArgs e)
            {
                if (flag == false)
                {
                    str1 = str1 + "7";
                }
                else
                {
                    str2 = str2 + "7";
                }

            }
            public void Button0_Click(object sender, EventArgs e)
            {
                if (flag == false)
                {
                    str1 = str1 + "0";
                }
                else
                {
                    str2 = str2 + "0";
                }

            }
            public void ButtonDone_Click(object sender, EventArgs e)
            {
                if (flag != true || str1 == null || str2 == null)
                {
                    MessageBox.Show("Insire um calculo valdio!");
                } else
                {
                    num1 = Int32.Parse(str1);
                    num2 = Int32.Parse(str2);
                    str1 = null;
                    str2 = null;
                    flag = false;

                    switch (op)
                    {
                        case '+':
                            res = num1 + num2;
                            strres = Convert.ToString(res);
                            MessageBox.Show(strres);
                            flag = false;
                            break;
                        case '-':
                            res = num1 - num2;
                            strres = Convert.ToString(res);
                            MessageBox.Show(strres);
                            flag = false;
                            break;
                        case '*':
                            res = num1 * num2;
                            strres = Convert.ToString(res);
                            MessageBox.Show(strres);
                            flag = false;
                            break;
                        case '/':
                            if (str2 == "0")
                            {
                                MessageBox.Show("ERROR");
                                break;
                            }
                            res = num1 / num2;
                            strres = Convert.ToString(res);
                            MessageBox.Show(strres);
                            flag = false;
                            break;
                        default:
                            MessageBox.Show("ERROR");
                            flag = false;
                            break;
                    }
                }

            }
            public void ButtonPlus_Click(object sender, EventArgs e)
            {
                op = '+';
                flag = true;
            }
            public void ButtonMinus_Click(object sender, EventArgs e)
            {
                op = '-';
                flag = true;
            }
            public void ButtonMultiply_Click(object sender, EventArgs e)
            {
                op = '*';
                flag = true;
            }
            public void ButtonDivide_Click(object sender, EventArgs e)
            {
                op = '/';
                flag = true;
            }


        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
