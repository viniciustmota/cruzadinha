using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cruzadinha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Deseja finalizar a aplicação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (mensagem == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "C")
            {
                textBox2.Focus();
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox1.Focus();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "A")
            {
                textBox3.Focus();
            }
            else
            {
                textBox2.Text = "";
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "C")
            {
                textBox4.Focus();
            }
            else
            {
                textBox3.Text = "";
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "H")
            {
                textBox5.Focus();
            }
            else
            {
                textBox4.Text = "";
            }
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "O")
            {
                textBox6.Focus();
            }
            else
            {
                textBox5.Text = "";
            }
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "R")
            {
                textBox7.Focus();
            }
            else
            {
                textBox6.Text = "";
            }
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "R")
            {
                textBox8.Focus();
            }
            else
            {
                textBox7.Text = "";
            }
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "O")
            {
                textBox9.Focus();
            }
            else
            {
                textBox8.Text = "";
            }
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "A")
            {
                textBox10.Focus();
            }
            else
            {
                textBox9.Text = "";
            }
        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "M")
            {
                textBox11.Focus();
            }
            else
            {
                textBox10.Text = "";
            }
        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text == "E")
            {
                textBox12.Focus();
            }
            else
            {
                textBox11.Text = "";
            }
        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text == "L")
            {
                textBox13.Focus();
            }
            else
            {
                textBox12.Text = "";
            }
        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text == "O")
            {
                textBox14.Focus();
            }
            else
            {
                textBox13.Text = "";
            }
        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text == "B")
            {
                textBox15.Focus();
            }
            else
            {
                textBox14.Text = "";
            }
        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text == "L")
            {
                textBox16.Focus();
            }
            else
            {
                textBox15.Text = "";
            }
        }

        private void TextBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text == "A")
            {
                textBox17.Focus();
            }
            else
            {
                textBox16.Text = "";
            }
        }

        private void TextBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.Text == "T")
            {
                textBox18.Focus();
            }
            else
            {
                textBox17.Text = "";
            }
        }

        private void TextBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text == "R")
            {
                textBox19.Focus();
            }
            else
            {
                textBox18.Text = "";
            }
        }

        private void TextBox19_TextChanged(object sender, EventArgs e)
        {
            if (textBox19.Text == "M")
            {
                textBox20.Focus();
            }
            else
            {
                textBox19.Text = "";
            }
        }

        private void TextBox20_TextChanged(object sender, EventArgs e)
        {
            if (textBox20.Text == "B")
            {
                textBox21.Focus();
            }
            else
            {
                textBox20.Text = "";
            }
        }

        private void TextBox21_TextChanged(object sender, EventArgs e)
        {
            if (textBox21.Text == "O")
            {
                textBox22.Focus();
            }
            else
            {
                textBox21.Text = "";
            }
        }

        private void TextBox22_TextChanged(object sender, EventArgs e)
        {
            if (textBox22.Text == "N")
            {
                textBox23.Focus();
            }
            else
            {
                textBox22.Text = "";
            }
        }

        private void TextBox23_TextChanged(object sender, EventArgs e)
        {
            if (textBox23.Text == "E")
            {
                textBox24.Focus();
            }
            else
            {
                textBox23.Text = "";
            }
        }

        private void TextBox24_TextChanged(object sender, EventArgs e)
        {
            if (textBox24.Text == "R")
            {
                textBox25.Focus();
            }
            else
            {
                textBox24.Text = "";
            }
        }

        private void TextBox25_TextChanged(object sender, EventArgs e)
        {
            if (textBox25.Text == "L")
            {
                textBox26.Focus();
            }
            else
            {
                textBox25.Text = "";
            }
        }

        private void TextBox26_TextChanged(object sender, EventArgs e)
        {
            if (textBox26.Text == "H")
            {
                textBox27.Focus();
            }
            else
            {
                textBox26.Text = "";
            }
        }

        private void TextBox27_TextChanged(object sender, EventArgs e)
        {
            if (textBox27.Text == "A")
            {
                DialogResult mensagem = MessageBox.Show("Parabéns você venceu o jogo,\n deseja jogar novamente?", "Venceu!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (mensagem == System.Windows.Forms.DialogResult.Yes)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    textBox13.Text = "";
                    textBox14.Text = "";
                    textBox15.Text = "";
                    textBox16.Text = "";
                    textBox17.Text = "";
                    textBox18.Text = "";
                    textBox19.Text = "";
                    textBox20.Text = "";
                    textBox21.Text = "";
                    textBox22.Text = "";
                    textBox23.Text = "";
                    textBox24.Text = "";
                    textBox25.Text = "";
                    textBox26.Text = "";
                    textBox27.Text = "";
                    textBox1.Focus();
                }
                    if (mensagem == System.Windows.Forms.DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                textBox27.Text = "";
            }
        }
    }
}
