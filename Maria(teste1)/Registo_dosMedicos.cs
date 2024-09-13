using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BusinessLogicLayer;

namespace Maria_teste1_
{
    public partial class Registo_dosMedicos : Form
    {
        public Registo_dosMedicos()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 3)
            {
                bunifuCheckbox1.Visible = false;
                label22.Visible = true;
            }
            else
            {
                bunifuCheckbox1.Visible = true;
                label22.Visible = false;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength < 7)
            {
                bunifuCheckbox2.Visible = false;
                label5.Visible = true;
            }
            else
            {
                bunifuCheckbox2.Visible = true;
                label5.Visible = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength < 9)
            {
                bunifuCheckbox3.Visible = false;
                label7.Visible = true;
            }
            else
            {
                bunifuCheckbox3.Visible = true;
                label7.Visible = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.TextLength < 7)
            {
                bunifuCheckbox4.Visible = false;
                label9.Visible = true;
            }
            else
            {
                bunifuCheckbox4.Visible = true;
                label9.Visible = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.TextLength < 9)
            {
                bunifuCheckbox5.Visible = false;
                label11.Visible = true;
            }
            else
            {
                bunifuCheckbox5.Visible = true;
                label11.Visible = false;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.TextLength < 3)
            {
                bunifuCheckbox10.Visible = false;
                label21.Visible = true;
            }
            else
            {
                bunifuCheckbox10.Visible = true;
                label21.Visible = false;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.TextLength < 7)
            {
                bunifuCheckbox9.Visible = false;
                label19.Visible = true;
            }
            else
            {
                bunifuCheckbox9.Visible = true;
                label19.Visible = false;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.TextLength < 9)
            {
                bunifuCheckbox8.Visible = false;
                label17.Visible = true;
            }
            else
            {
                bunifuCheckbox8.Visible = true;
                label17.Visible = false;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.TextLength < 7)
            {
                bunifuCheckbox7.Visible = false;
                label15.Visible = true;
            }
            else
            {
                bunifuCheckbox7.Visible = true;
                label15.Visible = false;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.TextLength < 9)
            {
                bunifuCheckbox6.Visible = false;
                label13.Visible = true;
            }
            else
            {
                bunifuCheckbox6.Visible = true;
                label13.Visible = false;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Visible==true && bunifuCheckbox2.Visible==true && bunifuCheckbox3.Visible==true && bunifuCheckbox4.Visible==true && bunifuCheckbox5.Visible==true && bunifuCheckbox6.Visible==true && bunifuCheckbox7.Visible==true && bunifuCheckbox8.Visible==true && bunifuCheckbox9.Visible==true && bunifuCheckbox10.Visible==true)
            {
                string nome_Mfam = "";
                nome_Mfam = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox1.Text.ToLower());

                string nome_Mesp = "";
                nome_Mesp = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox10.Text.ToLower());

                string t = "+351" + textBox2.Text;
                string t_centro = "+351" + textBox5.Text;

                string t_esp="+351" + textBox9.Text;
                string t_centro_esp = "+351" + textBox6.Text;

                int x = BLL.Medicos.insertMedico_fam(nome_Mfam, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

                int y = BLL.Medicos.insertMedico_esp(nome_Mesp, textBox9.Text, textBox8.Text, textBox7.Text, textBox6.Text);

                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }


        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void Registo_dosMedicos_Load(object sender, EventArgs e)
        {
            label22.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label11.Visible = false;
            label21.Visible = false;
            label19.Visible = false;
            label17.Visible = false;
            label15.Visible = false;
            label13.Visible = false;

            bunifuCheckbox1.Visible = false;
            bunifuCheckbox2.Visible = false;
            bunifuCheckbox3.Visible = false;
            bunifuCheckbox4.Visible = false;
            bunifuCheckbox5.Visible = false;
            bunifuCheckbox6.Visible = false;
            bunifuCheckbox7.Visible = false;
            bunifuCheckbox8.Visible = false;
            bunifuCheckbox9.Visible = false;
            bunifuCheckbox10.Visible = false;
        }
    }
}
