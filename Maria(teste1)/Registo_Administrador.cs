using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using System.Globalization;

namespace Maria_teste1_
{
    public partial class Registo_Administrador : Form
    {
        bool flag = false;
        string prefixo = "+351";
        string prefixo2 = "+351";
        string prefixo3 = "+351";
        string grau_parentesco = "";
        string observacao = "";
        string nr_emprego = "";
        string local_tra = "";
        string nr_casa = "";
        int max_len = 0;
        string nr_pessoal = "";
        int max_len2 = 0;
        int max_len3 = 0;
        string cod_postal = "";
        string utilizador = "";
        string pass = "";
        string nome = "";
        string morada = "";
        bool pwc = true;

        public Registo_Administrador()
        {
            InitializeComponent();
        }

        private void Registo_Administrador_Load(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is Bunifu.Framework.UI.BunifuCheckbox)
                {
                    ((Bunifu.Framework.UI.BunifuCheckbox)c).Visible = false;
                }

            }
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            // bunifuCheckbox1.Visible = false;

            label14.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            //label30.Visible = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength < 7)
            {
                bunifuCheckbox5.Visible = false;
                label23.Visible = true;
            }
            else
            {
                bunifuCheckbox5.Visible = true;
                label23.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void Registo_Paciente_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            

            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuCheckbox9_OnChange(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //label14.Text = maskedTextBox1.Text;
            //label14.Visible = true;

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            //if (textBox11.Text == textBox12.Text && textBox11.Text != "")
            //{
            //    label14.Visible = true;
            //}
            //else
            //{
            //    label14.Visible = false;
            //}

          




        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Portugal")
            {
                prefixo3 = "+351";
                textBox6.MaxLength = 9;
                max_len3 = 9;
            }
            else if (comboBox4.Text == "Cabo Verde")
            {
                prefixo3 = "+238";
                textBox6.MaxLength = 7;
                max_len3 = 7;
            }
            else if (comboBox4.Text == "Brasil")
            {
                prefixo3 = "+55";
                textBox6.MaxLength = 11;
                max_len3 = 11;
            }
            else if (comboBox4.Text == "França")
            {
                prefixo3 = "+33";
                textBox6.MaxLength = 9;
                max_len3 = 9;
            }
            else if (comboBox4.Text == "Suiça")
            {
                prefixo3 = "+41";
                textBox6.MaxLength = 9;
                max_len3 = 9;
            }
            else if (comboBox4.Text == "Inglaterra")
            {
                prefixo3 = "+44";
                textBox6.MaxLength = 10;
                max_len3 = 10;
            }
            else if (comboBox4.Text == "EUA")
            {
                prefixo3 = "+1";
                textBox6.MaxLength = 10;
                max_len3 = 10;
            }
            else if (comboBox4.Text == "Angola")
            {
                prefixo3 = "+244";
                textBox6.MaxLength = 9;
                max_len3 = 9;
            }
            else if (comboBox4.Text == "Moldavia")
            {
                prefixo3 = "+373";
                textBox6.MaxLength = 8;
                max_len3 = 8;
            }
            else if (comboBox4.Text == "Outro")
            {
                label18.Visible = true;
                textBox13.Visible = true;
                textBox13.Text = "+";
                textBox6.Enabled = false;
                textBox6.Text = "";
            }

            if (comboBox4.Text != "Outro")
            {
                label18.Visible = false;
                textBox13.Visible = false;
                textBox6.Enabled = true;
                textBox6.Text = "";
                textBox13.Text = "";
            }
            textBox6.Text = "";
            label28.Visible = false;
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            //if (textBox7.Text == "")
            //{
            //    bunifuCheckbox8.Visible = false;
            //    label30.Visible = false;
            //}
            //else if (textBox7.TextLength < 7)
            //{
            //    bunifuCheckbox8.Visible = false;
            //    label30.Visible = true;
            //}
            //else
            //{
            //    bunifuCheckbox8.Visible = true;
            //    label30.Visible = false;
            //}
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox5.TextLength < 7)
            {
                bunifuCheckbox6.Visible = false;
                label29.Visible = true;
            }
            else
            {
                bunifuCheckbox6.Visible = true;
                label29.Visible = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (flag == false)
            {
                flag = true;
                string pass = textBox10.Text;
                textBox10.PasswordChar = char.Parse("\0");
                textBox10.Text = pass;
            }
            else
            {
                flag = false;
                string pass = textBox10.Text;
                textBox10.PasswordChar = char.Parse("*");
                textBox10.Text = pass;
            }
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            if (textBox2.TextLength < max_len)
            {
                label14.Visible = true;
                label14.Text = "Campo obrigatório por preencher";
            }
            //else
            //{
            //    label14.Visible = false;
            //}

            if (textBox1.TextLength < 3)
            {
                label22.Visible = true;
            }
            //else
            //{
            //    label22.Visible = falsew\;
            //}

            if (textBox3.TextLength < 7)
            {
                bunifuCheckbox5.Visible = false;
                label23.Visible = true;
            }

            if (maskedTextBox1.MaskFull)
            {
                //bunifuCheckbox11.Visible = true;
                //label24.Visible = false;
            }
            else
            {
                bunifuCheckbox11.Visible = false;
                label24.Visible = true;
            }

            if (comboBox1.Text == "")
            {
                label26.Visible = true;
                bunifuCheckbox7.Visible = false;
            }


            if (comboBox1.Text == "Outros")
            {
                if (textBox8.TextLength < 3)
                {
                    label25.Visible = true;
                    bunifuCheckbox7.Visible = false;
                }
            }

            if (textBox9.TextLength < 5)
            {
                label20.Visible = true;
                bunifuCheckbox9.Visible = false;
            }

            if (textBox10.TextLength < 3)
            {
                label21.Visible = true;
                bunifuCheckbox10.Visible = false;
            }

            if (bunifuCheckbox1.Visible == true && bunifuCheckbox2.Visible == true && bunifuCheckbox5.Visible == true && bunifuCheckbox11.Visible == true && bunifuCheckbox1.Visible == true && bunifuCheckbox7.Visible == true && bunifuCheckbox9.Visible == true && bunifuCheckbox10.Visible == true && bunifuCheckbox11.Visible == true)
            {
                // ----- Admin superior -----
                //bool superior = true;

                // ----- grau parentesco -----
                if (comboBox1.Text == "Outros")
                {
                    grau_parentesco = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox8.Text.ToLower());

                }
                else
                {
                    grau_parentesco = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(comboBox1.Text.ToLower());
                }


                // ----- nr pessoal -----
                if (comboBox2.Text == "Outro")
                {
                    nr_pessoal = textBox11.Text;
                }

                else
                {
                    nr_pessoal = prefixo + textBox2.Text;
                }

                // ----- codido postal -----
                if (maskedTextBox1.MaskFull)
                {
                    cod_postal = maskedTextBox1.Text;
                }


                // ----- utilizador -----
                if (bunifuCheckbox9.Visible == true)
                {
                    utilizador = textBox9.Text;
                }

                // ----- palavra-passe -----
                if (bunifuCheckbox10.Visible == true)
                {
                    pass = textBox10.Text;
                }

                // ----- nome -----
                if (bunifuCheckbox1.Visible == true)
                {
                    nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox1.Text.ToLower());
                }

                // ----- morada -----
                if (bunifuCheckbox5.Visible == true)
                {
                    morada = textBox3.Text;
                }

                //---------------------------------



                // ----- nr de casa -----
                if (bunifuCheckbox3.Visible == true)
                {
                    if (comboBox2.Text == "Outro")
                    {
                        nr_casa = textBox12.Text;
                    }
                    else
                    {
                        nr_casa = prefixo2 + textBox4.Text;
                    }
                }
                else
                {
                    nr_casa = "";
                }


                // ----- observacao -----
                //if (bunifuCheckbox8.Visible == true)
                //{
                //    observacao = textBox7.Text;
                //}
                //else
                //{
                //    observacao = "";
                //}


                // ----- Local de trabalho -----
                if (bunifuCheckbox6.Visible == true)
                {
                    local_tra = textBox5.Text;
                }
                else
                {
                    local_tra = "";
                }


                // ----- nr de emprego/trabalho -----
                if (bunifuCheckbox4.Visible == true)
                {
                    if (comboBox4.Text == "Outro")
                    {
                        nr_emprego = textBox13.Text;
                    }
                    else
                    {
                        nr_emprego = prefixo3 + textBox6.Text;
                    }
                }
                else
                {
                    nr_emprego = "";
                }



                


                int x = BLL.Administrador.insertAdministrador(utilizador, pass, nome, nr_pessoal, nr_casa, nr_emprego, morada, local_tra, grau_parentesco, cod_postal);

                //MessageBox.Show("Informaçoes registadas!");
                Registo_doPaciente f2 = new Registo_doPaciente();
                f2.Show();
                this.Hide();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Registo_doPaciente f2 = new Registo_doPaciente();
            f2.Show();
            this.Hide();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox3.TextLength < 7)
            {
                bunifuCheckbox5.Visible = false;
                label23.Visible = true;
            }
            else
            {
                bunifuCheckbox5.Visible = true;
                label23.Visible = false;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Portugal")
            {
                prefixo = "+351";
                textBox2.MaxLength = 9;
                max_len = 9;
                bunifuCheckbox2.Visible = false;
            }
            else if (comboBox2.Text == "Cabo Verde")
            {
                prefixo = "+238";
                textBox2.MaxLength = 7;
                max_len = 7;
                bunifuCheckbox2.Visible = false;
            }
            else if (comboBox2.Text == "Brasil")
            {
                prefixo = "+55";
                textBox2.MaxLength = 11;
                max_len = 11;
                bunifuCheckbox2.Visible = false;
            }
            else if (comboBox2.Text == "França")
            {
                prefixo = "+33";
                textBox2.MaxLength = 9;
                max_len = 9;
                bunifuCheckbox2.Visible = false;
            }
            else if (comboBox2.Text == "Suiça")
            {
                prefixo = "+41";
                textBox2.MaxLength = 9;
                max_len = 9;
                bunifuCheckbox2.Visible = false;
            }
            else if (comboBox2.Text == "Inglaterra")
            {
                prefixo = "+44";
                textBox2.MaxLength = 10;
                max_len = 10;
                bunifuCheckbox2.Visible = false;
            }
            else if (comboBox2.Text == "EUA")
            {
                prefixo = "+1";
                textBox2.MaxLength = 10;
                max_len = 10;
                bunifuCheckbox2.Visible = false;
            }
            else if (comboBox2.Text == "Angola")
            {
                prefixo = "+244";
                textBox2.MaxLength = 9;
                max_len = 9;
                bunifuCheckbox2.Visible = false;
            }
            else if (comboBox2.Text == "Moldavia")
            {
                prefixo = "+373";
                textBox2.MaxLength = 8;
                max_len = 8;
                bunifuCheckbox2.Visible = false;
            }
            else if (comboBox2.Text == "Outro")
            {
                label16.Visible = true;
                textBox11.Visible = true;
                textBox11.Text = "+";
                textBox2.Enabled = false;
                textBox2.Text = "";
                bunifuCheckbox2.Visible = false;
            }

            if (comboBox2.Text != "Outro")
            {
                label16.Visible = false;
                textBox11.Visible = false;
                textBox2.Enabled = true;
                textBox2.Text = "";
                textBox11.Text = "";
            }
            textBox2.Text = "";
            label14.Visible = false;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                label14.Visible = false;
                bunifuCheckbox2.Visible = false;
            }
            else
            {
                if (textBox2.TextLength < max_len)
                {
                    bunifuCheckbox2.Visible = false;
                    label14.Text = "Mínimo de " + max_len + " caracteres";
                    label14.Visible = true;
                }
                else
                {
                    label14.Visible = false;
                    bunifuCheckbox2.Visible = true;
                }
            }
        }

        private void textBox11_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox11.TextLength < 5)
            {
                bunifuCheckbox2.Visible = false;
            }
            else
            {
                bunifuCheckbox2.Visible = true;
            }
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Portugal")
            {
                prefixo2 = "+351";
                textBox4.MaxLength = 9;
                max_len2 = 9;
                bunifuCheckbox3.Visible = false;
            }
            else if (comboBox3.Text == "Cabo Verde")
            {
                prefixo2 = "+238";
                textBox4.MaxLength = 7;
                max_len2 = 7;
                bunifuCheckbox3.Visible = false;
            }
            else if (comboBox3.Text == "Brasil")
            {
                prefixo2 = "+55";
                textBox4.MaxLength = 11;
                max_len2 = 11;
                bunifuCheckbox3.Visible = false;
            }
            else if (comboBox3.Text == "França")
            {
                prefixo2 = "+33";
                textBox4.MaxLength = 9;
                max_len2 = 9;
                bunifuCheckbox3.Visible = false;
            }
            else if (comboBox3.Text == "Suiça")
            {
                prefixo2 = "+41";
                textBox4.MaxLength = 9;
                max_len2 = 9;
                bunifuCheckbox3.Visible = false;
            }
            else if (comboBox3.Text == "Inglaterra")
            {
                prefixo2 = "+44";
                textBox4.MaxLength = 10;
                max_len2 = 10;
                bunifuCheckbox3.Visible = false;
            }
            else if (comboBox3.Text == "EUA")
            {
                prefixo2 = "+1";
                textBox4.MaxLength = 10;
                max_len2 = 10;
                bunifuCheckbox3.Visible = false;
            }
            else if (comboBox3.Text == "Angola")
            {
                prefixo2 = "+244";
                textBox4.MaxLength = 9;
                max_len2 = 9;
                bunifuCheckbox3.Visible = false;
            }
            else if (comboBox3.Text == "Moldavia")
            {
                prefixo2 = "+373";
                textBox4.MaxLength = 8;
                max_len2 = 8;
                bunifuCheckbox3.Visible = false;
            }
            else if (comboBox3.Text == "Outro")
            {
                label17.Visible = true;
                textBox12.Visible = true;
                textBox12.Text = "+";
                textBox4.Enabled = false;
                textBox4.Text = "";
                label27.Visible = false;
                bunifuCheckbox3.Visible = false;
            }

            if (comboBox3.Text != "Outro")
            {
                label17.Visible = false;
                textBox12.Visible = false;
                textBox4.Enabled = true;
                textBox4.Text = "";
                textBox12.Text = "";
                label27.Visible = false;
            }
            textBox4.Text = "";
            label27.Visible = false;
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

            if (comboBox2.Text == "Outro")
            {
                nr_casa = prefixo2 + textBox4.Text;
                if (textBox11.Text == nr_casa)
                {
                    label14.Visible = true;
                    label14.Text = "O contacto pessoal não pode ser igual ao de casa ";
                    bunifuCheckbox3.Visible = false;
                    label27.Visible = false;
                }
                else
                {
                    if (textBox4.Text == "")
                    {
                        label27.Visible = false;
                    }
                    else
                    {


                        if (textBox4.TextLength < max_len2)
                        {
                            bunifuCheckbox3.Visible = false;
                            label27.Visible = true;
                            label27.Text = "Mínimo de " + max_len2 + " caracteres";
                            if (textBox11.Text != textBox4.Text)
                            {
                                label14.Visible = false;
                            }

                        }
                        else
                        {
                            bunifuCheckbox3.Visible = true;
                            label14.Visible = false;
                            label27.Visible = false;
                        }
                    }
                }

            }
            else
            {


                if (textBox2.Text == textBox4.Text && textBox2.Text != "")
                {
                    label14.Visible = true;
                    label14.Text = "O contacto pessoal não pode ser igual ao de casa ";
                    bunifuCheckbox3.Visible = false;
                }

                else
                {
                    if (textBox4.Text == "")
                    {
                        label27.Visible = false;
                    }
                    else
                    {
                        if (textBox4.TextLength < max_len2)
                        {
                            bunifuCheckbox3.Visible = false;
                            label27.Visible = true;
                            label27.Text = "Mínimo de " + max_len2 + " caracteres";
                            if (textBox2.Text != textBox4.Text)
                            {
                                label14.Visible = false;
                            }
                        }
                        else
                        {
                            bunifuCheckbox3.Visible = true;
                            label14.Visible = false;
                            label27.Visible = false;
                        }
                    }

                }
            }
        }

        private void textBox12_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox12.TextLength < 5)
            {
                if (comboBox2.Text == "Outro")
                {
                    if (textBox12.Text == textBox11.Text)
                    {
                        bunifuCheckbox3.Visible = false;
                        label14.Visible = true;
                        label14.Text = "O contacto pessoal não pode ser igual ao de casa ";
                    }
                    else
                    {
                        bunifuCheckbox3.Visible = false;
                        label14.Visible = false;
                    }

                }
                else
                {
                    nr_pessoal = prefixo + textBox2.Text;
                    if (nr_pessoal == textBox12.Text)
                    {
                        bunifuCheckbox3.Visible = false;
                        label14.Visible = true;
                    }
                    else
                    {
                        bunifuCheckbox3.Visible = false;
                        label14.Visible = false;
                    }
                }

            }
            else
            {
                if (comboBox2.Text == "Outro")
                {
                    if (textBox12.Text == textBox11.Text)
                    {
                        bunifuCheckbox3.Visible = false;
                        label14.Visible = true;
                        label14.Text = "O contacto pessoal não pode ser igual ao de casa ";
                    }
                    else
                    {
                        bunifuCheckbox3.Visible = true;
                        label14.Visible = false;
                    }

                }
                else
                {
                    nr_pessoal = prefixo + textBox2.Text;
                    if (nr_pessoal == textBox12.Text)
                    {
                        bunifuCheckbox3.Visible = false;
                        label14.Visible = true;
                        label14.Text = "O contacto pessoal não pode ser igual ao de casa ";
                    }
                    else
                    {
                        bunifuCheckbox3.Visible = true;
                        label14.Visible = false;
                    }
                }

            }
        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Portugal")
            {
                prefixo3 = "+351";
                textBox6.MaxLength = 9;
                max_len3 = 9;
                bunifuCheckbox4.Visible = false;
            }
            else if (comboBox4.Text == "Cabo Verde")
            {
                prefixo3 = "+238";
                textBox6.MaxLength = 7;
                max_len3 = 7;
                bunifuCheckbox4.Visible = false;
            }
            else if (comboBox4.Text == "Brasil")
            {
                prefixo3 = "+55";
                textBox6.MaxLength = 11;
                max_len3 = 11;
                bunifuCheckbox4.Visible = false;
            }
            else if (comboBox4.Text == "França")
            {
                prefixo3 = "+33";
                textBox6.MaxLength = 9;
                max_len3 = 9;
                bunifuCheckbox4.Visible = false;
            }
            else if (comboBox4.Text == "Suiça")
            {
                prefixo3 = "+41";
                textBox6.MaxLength = 9;
                max_len3 = 9;
                bunifuCheckbox4.Visible = false;
            }
            else if (comboBox4.Text == "Inglaterra")
            {
                prefixo3 = "+44";
                textBox6.MaxLength = 10;
                max_len3 = 10;
                bunifuCheckbox4.Visible = false;
            }
            else if (comboBox4.Text == "EUA")
            {
                prefixo3 = "+1";
                textBox6.MaxLength = 10;
                max_len3 = 10;
                bunifuCheckbox4.Visible = false;
            }
            else if (comboBox4.Text == "Angola")
            {
                prefixo3 = "+244";
                textBox6.MaxLength = 9;
                max_len3 = 9;
                bunifuCheckbox4.Visible = false;
            }
            else if (comboBox4.Text == "Moldavia")
            {
                prefixo3 = "+373";
                textBox6.MaxLength = 8;
                max_len3 = 8;
                bunifuCheckbox4.Visible = false;
            }
            else if (comboBox4.Text == "Outro")
            {
                label18.Visible = true;
                textBox13.Visible = true;
                textBox13.Text = "+";
                textBox6.Enabled = false;
                textBox6.Text = "";
                bunifuCheckbox4.Visible = false;
            }

            if (comboBox4.Text != "Outro")
            {
                label18.Visible = false;
                textBox13.Visible = false;
                textBox6.Enabled = true;
                textBox6.Text = "";
                textBox13.Text = "";
            }
            textBox6.Text = "";
            label28.Visible = false;
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox6.TextLength == max_len3)
            {
                textBox5.Enabled = true;
            }
            else
            {
                textBox5.Enabled = false;
            }

            if (textBox6.Text == "")
            {
                label28.Visible = false;
            }
            else
            {


                if (textBox6.TextLength < max_len3)
                {
                    bunifuCheckbox4.Visible = false;
                    label28.Visible = true;
                    label28.Text = "Mínimo de " + max_len3 + " caracteres";
                }
                else
                {
                    bunifuCheckbox4.Visible = true;
                    label28.Visible = false;
                }
            }
        }

        private void textBox13_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox13.TextLength < 5)
            {
                textBox5.Enabled = false;
                bunifuCheckbox4.Visible = false;
                textBox5.Text = "";
            }
            else
            {
                bunifuCheckbox4.Visible = true;
                textBox5.Enabled = true;

            }
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {
                bunifuCheckbox11.Visible = true;
                label24.Visible = false;
            }
            else
            {
                bunifuCheckbox11.Visible = false;
                label24.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Outros")
            {
                label11.Visible = true;
                textBox8.Visible = true;
                bunifuCheckbox7.Visible = false;
                label25.Visible = false;
                label25.Text = "";
            }
            else if (comboBox1.Text != "Outros")
            {

                label11.Visible = false;
                textBox8.Visible = false;
                bunifuCheckbox7.Visible = true;
                label25.Visible = false;
                label26.Visible = false;
                label25.Text = "";
            }
        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox8.TextLength < 3)
            {
                bunifuCheckbox7.Visible = false;
                label25.Visible = true;
            }
            else
            {
                bunifuCheckbox7.Visible = true;
                label25.Visible = false;
                label26.Visible = false;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox9.TextLength < 5)
            {
                label20.Visible = true;
                bunifuCheckbox9.Visible = false;
            }
            else
            {
                label20.Visible = false;
                bunifuCheckbox9.Visible = true;
            }
        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox10.TextLength < 3)
            {
                label21.Visible = true;
                bunifuCheckbox10.Visible = false;
            }
            else
            {
                label21.Visible = false;
                bunifuCheckbox10.Visible = true;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox11_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox12_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox6_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox13_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox8_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (pwc == true)
            {
                pwc = false;
                textBox10.PasswordChar = '\0';
            }
            else
            {
                pwc = true;
                textBox10.PasswordChar = '*';
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
