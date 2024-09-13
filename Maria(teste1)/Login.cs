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

namespace Maria_teste1_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //globais.cr = globais.cr + 1;


            //if (bunifuMaterialTextbox1.Text != "a")
            //{

            //}
            //else
            //{
            //    Form2 f1 = new Form2();
            //    f1.Show();
            //    Form1 f2 = new Form1();
            //    f2.Hide();
            //    this.Hide();

            //}

            //validacao de Login

            globais.cr = globais.cr + 1;

            if (bunifuMaterialTextbox1.Text.Equals("") || bunifuMaterialTextbox2.Text.Equals(""))
            {
                MessageBox.Show("Nao deixe espacos em branco");
            }
            else
            {
                string userName = bunifuMaterialTextbox1.Text.ToString();
                string pass = bunifuMaterialTextbox2.Text.ToString();
                DataTable dt = BLL.Administrador.queryLogin(userName, pass);
                if (dt.Rows.Count > 0)
                {
                    globais.userName = bunifuMaterialTextbox1.Text;
                    Form2 f1 = new Form2();
                    f1.Show();
                    Form1 f2 = new Form1();
                    f2.Hide();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username ou Palavra-passe invalida.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            if (globais.cr == 6)
            {
                this.Hide();
            }
           




        }

        private void Login_Load(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
            timer1.Start();
            globais.cr = 0;
            globais.ver = true;
            globais.sec = 0;
           
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text != "")
            {
                timer1.Stop();
            }
            if (globais.ver == false)
            {
                timer1.Stop();
                this.Close();

            }
          
            globais.sec = globais.sec + 1;
            if (globais.sec ==  6)
            {
                globais.ver = false;
            }
        }

        private void bunifuFlatButton1_MouseHover(object sender, EventArgs e)
        {
            bunifuFlatButton1.ForeColor = Color.Silver;
        }
    }
}
