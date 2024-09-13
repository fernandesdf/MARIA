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
using System.IO;

namespace Maria_teste1_
{
    public partial class Jogo_GaleriaFam : Form
    {
        int nrCheckBoxNome=0;
        bool ajuda = false;
        public Jogo_GaleriaFam()
        
        {
            InitializeComponent();
        }

        private void Jogo_EntesQueridos_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            panel2.Visible = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            //seleciona uma foto random, poem a foto
            Random rnd = new Random();
            DataTable dt = BLL.Jogo_GaleriaFam.Load();
            int rmd = rnd.Next(1, dt.Rows.Count+1);
            int id_foto =Convert.ToInt32(dt.Rows[rmd-1][0]);
            DataTable dtGquery = BLL.Galeria.queryGaleria(id_foto);
            pictureBox4.Image = byteArrayToImage((Byte[])dtGquery.Rows[0][1]);

            //seleciona nomes random de uma tabela ja pre definida com nomes random && seleciona uma das checkboxs para por o nome correto
            int rmdN = rnd.Next(1, 4);
            nrCheckBoxNome = rmdN;
            //MessageBox.Show("" + rmdN);
            if (rmdN == 1)
            {
                checkBox1.Text = dtGquery.Rows[0][2].ToString();
                int rmdNome = rnd.Next(1, 21);
                DataTable dt2 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome);
                checkBox2.Text = dt2.Rows[0][1].ToString();
                int rmdNome2 = rnd.Next(1, 21);
                DataTable dt3 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome2);
                checkBox3.Text = dt3.Rows[0][1].ToString();
            }
            else if (rmdN == 2)
            {
                checkBox2.Text = dtGquery.Rows[0][2].ToString();
                int rmdNome = rnd.Next(1, 21);
                DataTable dt2 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome);
                checkBox1.Text = dt2.Rows[0][1].ToString();
                int rmdNome2 = rnd.Next(1, 21);
                DataTable dt3 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome2);
                checkBox3.Text = dt3.Rows[0][1].ToString();
            }
            else if (rmdN == 3)
            {
                checkBox3.Text = dtGquery.Rows[0][2].ToString();
                int rmdNome = rnd.Next(1, 21);
                DataTable dt2 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome);
                checkBox2.Text = dt2.Rows[0][1].ToString();
                int rmdNome2 = rnd.Next(1, 21);
                DataTable dt3 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome2);
                checkBox1.Text = dt3.Rows[0][1].ToString();
            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (ajuda == false)
            {
                ajuda = true;
                panel1.Visible = true;
            }
            else if (ajuda == true)
            {
                ajuda = false;
                panel1.Visible = false;
            }
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            if (ajuda == false)
            {
                ajuda = true;
                panel1.Visible = true;
            }
            else if (ajuda == true)
            {
                ajuda = false;
                panel1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //seleciona uma foto random, poem a foto
            Random rnd = new Random();
            DataTable dt = BLL.Jogo_GaleriaFam.Load();
            int rmd = rnd.Next(1, dt.Rows.Count + 1);
            int id_foto = Convert.ToInt32(dt.Rows[rmd - 1][0]);
            DataTable dtGquery = BLL.Galeria.queryGaleria(id_foto);
            pictureBox4.Image = byteArrayToImage((Byte[])dtGquery.Rows[0][1]);

            //seleciona nomes random de uma tabela ja pre definida com nomes random && seleciona uma das checkboxs para por o nome correto
            int rmdN = rnd.Next(1, 4);
            nrCheckBoxNome = rmdN;
            //MessageBox.Show("" + rmdN);
            if (rmdN == 1)
            {
                checkBox1.Text = dtGquery.Rows[0][2].ToString();
                int rmdNome = rnd.Next(1, 21);
                DataTable dt2 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome);
                checkBox2.Text = dt2.Rows[0][1].ToString();
                int rmdNome2 = rnd.Next(1, 21);
                DataTable dt3 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome2);
                checkBox3.Text = dt3.Rows[0][1].ToString();
            }
            else if (rmdN == 2)
            {
                checkBox2.Text = dtGquery.Rows[0][2].ToString();
                int rmdNome = rnd.Next(1, 21);
                DataTable dt2 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome);
                checkBox1.Text = dt2.Rows[0][1].ToString();
                int rmdNome2 = rnd.Next(1, 21);
                DataTable dt3 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome2);
                checkBox3.Text = dt3.Rows[0][1].ToString();
            }
            else if (rmdN == 3)
            {
                checkBox3.Text = dtGquery.Rows[0][2].ToString();
                int rmdNome = rnd.Next(1, 21);
                DataTable dt2 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome);
                checkBox2.Text = dt2.Rows[0][1].ToString();
                int rmdNome2 = rnd.Next(1, 21);
                DataTable dt3 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome2);
                checkBox1.Text = dt3.Rows[0][1].ToString();
            }
            panel2.Visible = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (nrCheckBoxNome == 1)
                label8.Text = "Acertou!";
            else
                label8.Text = "Errou!";

            checkBox2.Checked = false;
            checkBox3.Checked = false;
            panel2.Visible = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (nrCheckBoxNome == 2)
            {
                label8.Text = "Acertou!";
            }
            else
                label8.Text = "Errou!";

            checkBox1.Checked = false;
            checkBox3.Checked = false;
            panel2.Visible = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (nrCheckBoxNome == 3)
            {
                label8.Text = "Acertou!";
            }
            else
                label8.Text = "Errou!";

            checkBox2.Checked = false;
            checkBox1.Checked = false;
            panel2.Visible = true;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            panel2.Visible = false;
            label9.Text = panel2.Visible.ToString();
            //seleciona uma foto random, poem a foto
            Random rnd = new Random();
            DataTable dt = BLL.Jogo_GaleriaFam.Load();
            int rmd = rnd.Next(1, dt.Rows.Count + 1);
            int id_foto = Convert.ToInt32(dt.Rows[rmd - 1][0]);
            DataTable dtGquery = BLL.Galeria.queryGaleria(id_foto);
            pictureBox4.Image = byteArrayToImage((Byte[])dtGquery.Rows[0][1]);

            //seleciona nomes random de uma tabela ja pre definida com nomes random && seleciona uma das checkboxs para por o nome correto
            int rmdN = rnd.Next(1, 4);
            nrCheckBoxNome = rmdN;
            label10.Text = "" + nrCheckBoxNome;
            //MessageBox.Show("" + rmdN);
            if (rmdN == 1)
            {
                checkBox1.Text = dtGquery.Rows[0][2].ToString();
                int rmdNome = rnd.Next(1, 21);
                DataTable dt2 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome);
                checkBox2.Text = dt2.Rows[0][1].ToString();
                int rmdNome2 = rnd.Next(1, 21);
                DataTable dt3 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome2);
                checkBox3.Text = dt3.Rows[0][1].ToString();
            }
            else if (rmdN == 2)
            {
                checkBox2.Text = dtGquery.Rows[0][2].ToString();
                int rmdNome = rnd.Next(1, 21);
                DataTable dt2 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome);
                checkBox1.Text = dt2.Rows[0][1].ToString();
                int rmdNome2 = rnd.Next(1, 21);
                DataTable dt3 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome2);
                checkBox3.Text = dt3.Rows[0][1].ToString();
            }
            else if (rmdN == 3)
            {
                checkBox3.Text = dtGquery.Rows[0][2].ToString();
                int rmdNome = rnd.Next(1, 21);
                DataTable dt2 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome);
                checkBox2.Text = dt2.Rows[0][1].ToString();
                int rmdNome2 = rnd.Next(1, 21);
                DataTable dt3 = BLL.Jogo_GaleriaFam.queryNomes(rmdNome2);
                checkBox1.Text = dt3.Rows[0][1].ToString();
            }
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
    }
}
