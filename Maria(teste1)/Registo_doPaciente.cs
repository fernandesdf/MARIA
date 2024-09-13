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
    public partial class Registo_doPaciente : Form
    {
        public Registo_doPaciente()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registo_dosMedicos f1 = new Registo_dosMedicos();
            f1.Show();
            this.Hide();
        }

        private void Registo_doPaciente_Load(object sender, EventArgs e)
        {
            label8.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label6.Visible = false;
            label30.Visible = false;
            label3.Visible = false;
            label11.Visible = false;

            foreach (var c in this.Controls)
            {
                if (c is Bunifu.Framework.UI.BunifuCheckbox)
                {
                    ((Bunifu.Framework.UI.BunifuCheckbox)c).Visible = false;
                }

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
            if (textBox10.Text == comboBox3.Text)
            {

            }
            else
            {               
                DataTable dt = BLL.Doente.queryDoenca(comboBox3.Text);
                int id_doenca=0;
                if (dt.Rows.Count!=0) id_doenca = Convert.ToInt32(dt.Rows[0][0]);

                string medicamento = "";
                medicamento = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox10.Text.ToLower());

                DataTable dt1 = BLL.Doente.queryMedicacao(id_doenca, medicamento);

                if (dt1.Rows.Count != 0)
                {
                    MessageBox.Show("Medicacao ja registada.");
                    textBox10.Text = "";
                }
                else
                {
                    int x = BLL.Doente.insertMedicacao(id_doenca, medicamento);
                    textBox10.Text = "";
                }
                
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string sintomas="";
            if (bunifuCheckbox4.Visible == true){
                sintomas=textBox7.Text;
            }
            else{
                sintomas="";
            }

            

            if (bunifuCheckbox1.Visible == true && bunifuCheckbox2.Visible == true && bunifuCheckbox3.Visible == true && bunifuCheckbox5.Visible == true)
            {
                string nome = "";
                nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox1.Text.ToLower());
                int x = BLL.Doente.insertDoente(nome, textBox3.Text, comboBox1.Text, sintomas, comboBox2.Text);
                Registo_dosMedicos f1 = new Registo_dosMedicos();
                f1.Show();
                this.Hide();
            }
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox18.Text == "")
            {
                label8.Visible = false;
            }   
            else if (textBox18.TextLength < 3)
            {
                label8.Visible = true;
            }
            else 
            {   
                string doenca_extra = "";
                doenca_extra= CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox18.Text.ToLower());

                DataTable dt = BLL.Doente.queryDoenca(doenca_extra);

                if (dt.Rows.Count != 0)
                {
                    MessageBox.Show("Doenca ja registada.");
                    textBox18.Text = "";
                }
                else
                {
                    int x = BLL.Doente.insertDoencas_extras(doenca_extra);
                    comboBox3.Items.Add(doenca_extra);
                    textBox18.Text = "";
                }
            }
            

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                label11.Visible = false;
                bunifuImageButton1.Enabled = false;
            }
            else if (textBox10.TextLength >=1 && textBox10.TextLength < 3)
            {
                bunifuImageButton1.Enabled = false;
                label11.Visible = true;
            }
            else
            {
                bunifuImageButton1.Enabled = true;
                label11.Visible = false;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                textBox10.Enabled = false;
            }
            else
            {
                textBox10.Enabled = true;
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text == ""){
                label8.Visible = false;
            }
            else if (textBox18.TextLength >= 1 && textBox18.TextLength < 3)
            {
                label8.Visible = true;
            }
            else
            {
                label8.Visible = false;
            }
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
            if (comboBox1.Text == "")
            {
                bunifuCheckbox3.Visible = false;
            }
            else
            {
                bunifuCheckbox3.Visible = true;
                label6.Visible = false;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                label30.Visible = false;
                bunifuCheckbox4.Visible = false;
            }
            else if (textBox7.TextLength >= 1 && textBox7.TextLength < 7)
            {
                label30.Visible = true;
                bunifuCheckbox4.Visible = false;
            }
            else
            {
                label30.Visible = false;
                bunifuCheckbox4.Visible = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                label3.Visible = true;
                bunifuCheckbox2.Visible = false;
            }
            else
            {
                label3.Visible = false;
                bunifuCheckbox2.Visible = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
