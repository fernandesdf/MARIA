using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using System.Runtime.InteropServices;
using BusinessLogicLayer;
using System.Globalization;
using System.IO;


namespace Maria_teste1_
{

    public partial class Form2 : Form
    {
        Boolean[] dias = new Boolean[7];
        Boolean[] diasM = new Boolean[32];
        int id_toque =0;
        int leng = 0;
        int i = 0;
        int jj3 = 0;
        string img1 = "";
        string img2 = "";
        string img3 = "";
        bool alr_edit = false;
        private int location = 0;
        bool alarmR = false;
        System.Media.SoundPlayer Toque;
        bool toqueA = false;
        bool buttonC_Alarme = false;
        int label = 0;
        bool jogoG = false;

        public Form2()
        {

            InitializeComponent();
            // Set position on top of your panel
           tabPage11.AutoScrollPosition = new Point(0, 0);

            // Set maximum position of your panel beyond the point your panel items reach.
            // You'll have to change this size depending on the total size of items for your case.
            tabPage11.VerticalScroll.Maximum = 725;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage5;

            if (toqueA == true)
            {
                Toque.Stop();
                toqueA = false;
            }

            bunifuFlatButton2.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.DoubleBuffered = true;

            bunifuImageButton5.Focus();

            for (int i = 0; i < 6; i++)
            {
                dias[i] = false;
            }
            toqueA = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            

            

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuMetroTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back) ;
            
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox7_OnValueChanged(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("osk.exe");
        }

        private void bunifuMaterialTextbox7_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("--");
            //System.Diagnostics.Process.Start("osk.exe");
        }

        private void bunifuMaterialTextbox7_MouseHover(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("osk.exe");
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("osk.exe");
            bunifuImageButton4.Visible = true;

            if (toqueA == true)
            {
                Toque.Stop();
                toqueA = false;
            }
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //if (globais.frm == "f1")
            //{
            //    AdminInformaçoes f1 = new AdminInformaçoes();
            //    f1.Close();
            //}
            //Form1 f100 = new Form1();
            //f100.Show();
            this.Close();
            if (toqueA == true)
            {
                Toque.Stop();
                toqueA = false;
            }
        }

        private void bunifuFlatButton3_Click(object sender, System.EventArgs e)
        {
          
        }

        private void bunifuFlatButton7_Click(object sender, System.EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage1;
            bunifuImageButton5.Focus();

            DataTable dt = BLL.Administrador.queryAdmin(globais.userName);

            bunifuMaterialTextbox7.Text = dt.Rows[0][3].ToString();
            Size size7 = TextRenderer.MeasureText(bunifuMaterialTextbox7.Text, bunifuMaterialTextbox7.Font);
            bunifuMaterialTextbox7.Width = size7.Width;
            bunifuMaterialTextbox7.Height = size7.Height;

            bunifuMaterialTextbox6.Text = dt.Rows[0][4].ToString();
            Size size6 = TextRenderer.MeasureText(bunifuMaterialTextbox6.Text, bunifuMaterialTextbox6.Font);
            bunifuMaterialTextbox6.Width = size6.Width;
            bunifuMaterialTextbox6.Height = size6.Height;
            string t_casa = dt.Rows[0][5].ToString();
            if (t_casa == "")
            {
                bunifuMaterialTextbox5.Text = "Sem informação";
                bunifuMaterialTextbox5.Enabled = false;
            }
            else
                bunifuMaterialTextbox5.Text = dt.Rows[0][5].ToString();

            Size size5 = TextRenderer.MeasureText(bunifuMaterialTextbox5.Text, bunifuMaterialTextbox5.Font);
            bunifuMaterialTextbox5.Width = size5.Width;
            bunifuMaterialTextbox5.Height = size5.Height;

            string t_emprego = dt.Rows[0][6].ToString();
            if (t_emprego == "")
            {
                bunifuMaterialTextbox4.Text = "Sem informação";
                bunifuMaterialTextbox4.Enabled = false;
            }
            else
                bunifuMaterialTextbox4.Text = dt.Rows[0][6].ToString();

            Size size4 = TextRenderer.MeasureText(bunifuMaterialTextbox4.Text, bunifuMaterialTextbox4.Font);
            bunifuMaterialTextbox4.Width = size4.Width;
            bunifuMaterialTextbox4.Height = size4.Height;

            bunifuMaterialTextbox3.Text = dt.Rows[0][7].ToString();
            Size size3 = TextRenderer.MeasureText(bunifuMaterialTextbox3.Text, bunifuMaterialTextbox3.Font);
            bunifuMaterialTextbox3.Width = size3.Width;
            bunifuMaterialTextbox3.Height = size3.Height;

            string m_emprego = dt.Rows[0][8].ToString();
            if (m_emprego == "")
            {
                bunifuMaterialTextbox2.Text = "Sem informação";
                bunifuMaterialTextbox2.Enabled = false;
            }
            else
                bunifuMaterialTextbox2.Text = dt.Rows[0][8].ToString();

            Size size2 = TextRenderer.MeasureText(bunifuMaterialTextbox2.Text, bunifuMaterialTextbox2.Font);
            bunifuMaterialTextbox2.Width = size2.Width;
            bunifuMaterialTextbox2.Height = size2.Height;

            bunifuMaterialTextbox1.Text = dt.Rows[0][9].ToString();
            Size size = TextRenderer.MeasureText(bunifuMaterialTextbox1.Text, bunifuMaterialTextbox1.Font);
            bunifuMaterialTextbox1.Width = size.Width;
            bunifuMaterialTextbox1.Height = size.Height;
        }

        private void bunifuFlatButton8_Click(object sender, System.EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage23;
            bunifuImageButton5.Focus();

            DataTable dt = BLL.Administrador.queryAdmin(globais.userName);
            textBox5.Text = dt.Rows[0][3].ToString();

            textBox9.Text = dt.Rows[0][4].ToString();

            string t_casa = dt.Rows[0][5].ToString();
            if (t_casa == "")
            {
                textBox10.Text = "Sem informação";
                //textBox10.Enabled = false;
            }
            else
                textBox10.Text = dt.Rows[0][5].ToString();

            string t_emprego = dt.Rows[0][6].ToString();
            if (t_emprego == "")
            {
                textBox11.Text = "Sem informação";
                //textBox11.Enabled = false;
            }
            else
                textBox11.Text = dt.Rows[0][6].ToString();

            textBox6.Text = dt.Rows[0][7].ToString();

            string m_emprego = dt.Rows[0][8].ToString();
            if (m_emprego == "")
            {
                textBox7.Text = "Sem informação";
                //textBox7.Enabled = false;
            }
            else
                textBox7.Text = dt.Rows[0][8].ToString();

            textBox8.Text = dt.Rows[0][9].ToString();

            maskedTextBox1.Text = dt.Rows[0][10].ToString();

            label86.Visible = false;
            label87.Visible = false;
            label88.Visible = false;
            label89.Visible = false;
            label90.Visible = false;
            label91.Visible = false;
            label92.Visible = false;
            label95.Visible = false;
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void label4_Click(object sender, System.EventArgs e)
        {

        }

        private void label5_Click(object sender, System.EventArgs e)
        {

        }

        private void label6_Click(object sender, System.EventArgs e)
        {

        }

        private void label7_Click(object sender, System.EventArgs e)
        {

        }

        private void label8_Click(object sender, System.EventArgs e)
        {

        }

        private void bunifuFlatButton10_Click(object sender, System.EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage2;

            bunifuFlatButton2.Focus();

            DataTable dt = BLL.Doente.LoadDoente();
            bunifuMaterialTextbox10.Text = dt.Rows[0][1].ToString();
            Size size10 = TextRenderer.MeasureText(bunifuMaterialTextbox10.Text, bunifuMaterialTextbox10.Font);
            bunifuMaterialTextbox10.Width = size10.Width;
            bunifuMaterialTextbox10.Height = size10.Height;

            bunifuMaterialTextbox11.Text = dt.Rows[0][2].ToString();
            Size size11 = TextRenderer.MeasureText(bunifuMaterialTextbox11.Text, bunifuMaterialTextbox11.Font);
            bunifuMaterialTextbox11.Width = size11.Width;
            bunifuMaterialTextbox11.Height = size11.Height;

            bunifuMaterialTextbox8.Text = dt.Rows[0][3].ToString();
            Size size8 = TextRenderer.MeasureText(bunifuMaterialTextbox8.Text, bunifuMaterialTextbox8.Font);
            bunifuMaterialTextbox8.Width = size8.Width;
            bunifuMaterialTextbox8.Height = size8.Height;

            bunifuMaterialTextbox9.Text = dt.Rows[0][5].ToString();
            Size size9 = TextRenderer.MeasureText(bunifuMaterialTextbox9.Text, bunifuMaterialTextbox9.Font);
            bunifuMaterialTextbox9.Width = size9.Width;
            bunifuMaterialTextbox9.Height = size9.Height;

            textBox1.Text = dt.Rows[0][4].ToString();
            if (textBox1.Text == "")
                textBox1.Text = "Sem informação";

            Size size1 = TextRenderer.MeasureText(textBox1.Text, textBox1.Font);
            textBox1.Width = size1.Width;
            textBox1.Height = size1.Height;

            //DataTable dt1 = BLL.Doente.queryDoenca_Like("");
            DataTable dt1 = BLL.Doente.LoadDoenca();

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                string doenca = dt1.Rows[i][1].ToString();
                metroComboBox3.Items.Add(doenca);
            } 

        }

        private void bunifuMaterialTextbox6_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox5_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox4_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox3_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox10_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox11_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox8_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox9_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox12_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox13_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox15_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox16_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox17_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox14_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox18_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox19_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox20_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox21_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox22_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox23_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuFlatButton12_Click(object sender, System.EventArgs e)
        {
            
        }

        private void bunifuFlatButton12_Click_1(object sender, System.EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage6;

            bunifuFlatButton4.Focus();

            DataTable dt = BLL.Medicos.LoadMed_fam();
            bunifuMaterialTextbox26.Text = dt.Rows[0][1].ToString();
            Size size = TextRenderer.MeasureText(bunifuMaterialTextbox26.Text, bunifuMaterialTextbox26.Font);
            bunifuMaterialTextbox26.Width = size.Width;
            bunifuMaterialTextbox26.Height = size.Height;

            bunifuMaterialTextbox27.Text = dt.Rows[0][3].ToString();
            Size size27 = TextRenderer.MeasureText(bunifuMaterialTextbox27.Text, bunifuMaterialTextbox27.Font);
            bunifuMaterialTextbox27.Width = size27.Width;
            bunifuMaterialTextbox27.Height = size27.Height;

            bunifuMaterialTextbox25.Text = dt.Rows[0][2].ToString();
            Size size25 = TextRenderer.MeasureText(bunifuMaterialTextbox25.Text, bunifuMaterialTextbox25.Font);
            bunifuMaterialTextbox25.Width = size25.Width;
            bunifuMaterialTextbox25.Height = size25.Height;

            bunifuMaterialTextbox24.Text = dt.Rows[0][4].ToString();
            Size size24 = TextRenderer.MeasureText(bunifuMaterialTextbox24.Text, bunifuMaterialTextbox24.Font);
            bunifuMaterialTextbox24.Width = size24.Width;
            bunifuMaterialTextbox24.Height = size24.Height;

            bunifuMaterialTextbox29.Text = dt.Rows[0][5].ToString();
            Size size29 = TextRenderer.MeasureText(bunifuMaterialTextbox29.Text, bunifuMaterialTextbox29.Font);
            bunifuMaterialTextbox29.Width = size29.Width;
            bunifuMaterialTextbox29.Height = size29.Height;

            
        }

        private void bunifuFlatButton4_Click(object sender, System.EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage22;

            bunifuFlatButton4.Focus();

            if (toqueA == true)
            {
                Toque.Stop();
                toqueA = false;
            }
        }

        private void bunifuFlatButton14_Click(object sender, System.EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage9;

            bunifuFlatButton4.Focus();
            

            DataTable dt = BLL.Medicos.LoadMed_esp();
            bunifuMaterialTextbox32.Text = dt.Rows[0][1].ToString();
            Size size32 = TextRenderer.MeasureText(bunifuMaterialTextbox32.Text, bunifuMaterialTextbox32.Font);
            bunifuMaterialTextbox32.Width = size32.Width;
            bunifuMaterialTextbox32.Height = size32.Height;

            bunifuMaterialTextbox33.Text = dt.Rows[0][3].ToString();
            Size size33 = TextRenderer.MeasureText(bunifuMaterialTextbox33.Text, bunifuMaterialTextbox33.Font);
            bunifuMaterialTextbox33.Width = size33.Width;
            bunifuMaterialTextbox33.Height = size33.Height;

            bunifuMaterialTextbox31.Text = dt.Rows[0][2].ToString();
            Size size31 = TextRenderer.MeasureText(bunifuMaterialTextbox31.Text, bunifuMaterialTextbox31.Font);
            bunifuMaterialTextbox31.Width = size31.Width;
            bunifuMaterialTextbox31.Height = size31.Height;

            bunifuMaterialTextbox28.Text = dt.Rows[0][4].ToString();
            Size size28 = TextRenderer.MeasureText(bunifuMaterialTextbox28.Text, bunifuMaterialTextbox28.Font);
            bunifuMaterialTextbox28.Width = size28.Width;
            bunifuMaterialTextbox28.Height = size28.Height;

            bunifuMaterialTextbox34.Text = dt.Rows[0][5].ToString();
            Size size34 = TextRenderer.MeasureText(bunifuMaterialTextbox34.Text, bunifuMaterialTextbox34.Font);
            bunifuMaterialTextbox34.Width = size34.Width;
            bunifuMaterialTextbox34.Height = size34.Height;
        }

        private void tabPage10_Click(object sender, System.EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, System.EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage10;

            bunifuFlatButton5.Focus();

            if (toqueA == true)
            {
                Toque.Stop();
                toqueA = false;
            }
        }

        private void bunifuImageButton3_Click(object sender, System.EventArgs e)
        {
            panel3.Visible = true;
        }

        private void bunifuFlatButton15_Click(object sender, System.EventArgs e)
        {
            panel3.Visible = false;
        }

        private void panel4_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, System.EventArgs e)
        {
            //G:\PT\Maria(teste1)\Maria(teste1)\bin\Debug\Selena\tumblr_oyvh6cuzEV1vrpaero3_1280.jpg
            pictureBox19.ImageLocation=System.Windows.Forms.Application.StartupPath + "/Selena/tumblr_oyvh6cuzEV1vrpaero3_1280.jpg";
            //label49.Text = label33.Text;
            label49.Visible = true;
        }

        private void pictureBox5_Click_1(object sender, System.EventArgs e)
        {
            pictureBox19.ImageLocation = System.Windows.Forms.Application.StartupPath + "/Selena/DNpiGZPW0AYbZuu.jpg";
            //label49.Text = label35.Text;
            label49.Visible = true;
        }

        private void pictureBox6_Click(object sender, System.EventArgs e)
        {
            pictureBox19.ImageLocation = System.Windows.Forms.Application.StartupPath + "/Selena/21147382_1930651340538048_4199070627719544832_n.jpg";
            //label49.Text = label36.Text;
            label49.Visible = true;
        }

        private void bunifuFlatButton6_Click(object sender, System.EventArgs e)
        {
            if (toqueA == true)
            {
                Toque.Stop();
                toqueA = false;
            }
            
            materialTabControl1.SelectedTab = tabPage11;
            
            alr_edit = false;
            bunifuCustomLabel9.Text = "Editar";

            //tabPage11
            tabPage12.AutoScrollPosition = new Point(0, 0);
            tabPage12.VerticalScroll.Minimum = 0;
            tabPage13.AutoScrollPosition = new Point(0, 0);
            tabPage13.VerticalScroll.Minimum = 0;
            tabPage14.AutoScrollPosition = new Point(0, 0);
            tabPage14.VerticalScroll.Minimum = 0;
            //tabPage11.VerticalScroll.Value = 0;
            //bunifuCustomLabel3.Focus();
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            Point ponto1 = new Point(59, 22);
            Point ponto2 = new Point(62, 64);
            bunifuCustomLabel3.Location = ponto1;
            bunifuCustomLabel4.Location = ponto2;
            Point p28 = new Point(66, 89);
            bunifuSeparator2.Location = p28;
            Point p42 = new Point(649, 58);
            bunifuSwitch1.Location = p42;

            Point ponto3 = new Point(59, 127);
            Point ponto4 = new Point(62, 169);
            bunifuCustomLabel6.Location = ponto3;
            bunifuCustomLabel5.Location = ponto4;
            Point p29 = new Point(66, 194);
            bunifuSeparator3.Location = p29;
            Point p43 = new Point(649, 164);
            bunifuSwitch2.Location = p43;

            Point ponto5 = new Point(59, 232);
            Point ponto6 = new Point(62, 274);
            bunifuCustomLabel8.Location = ponto5;
            bunifuCustomLabel7.Location = ponto6;
            Point p30 = new Point(66, 299);
            bunifuSeparator4.Location = p30;
            Point p44 = new Point(649, 268);
            bunifuSwitch3.Location = p44;

            Point ponto7 = new Point(64, 337);
            Point ponto8 = new Point(67, 379);
            bunifuCustomLabel15.Location = ponto7;
            bunifuCustomLabel14.Location = ponto8;
            Point p31 = new Point(72, 404);
            bunifuSeparator7.Location = p31;
            Point p45 = new Point(655, 373);
            bunifuSwitch6.Location = p45;

            Point ponto9 = new Point(64, 442);
            Point ponto10 = new Point(67, 484);
            bunifuCustomLabel13.Location = ponto9;
            bunifuCustomLabel12.Location = ponto10;
            Point p32 = new Point(72, 509);
            bunifuSeparator6.Location = p32;
            Point p46 = new Point(655, 479);
            bunifuSwitch5.Location = p46;

            Point ponto11 = new Point(64, 547);
            Point ponto12 = new Point(67, 589);
            bunifuCustomLabel11.Location = ponto11;
            bunifuCustomLabel10.Location = ponto12;
            Point p33 = new Point(72, 614);
            bunifuSeparator5.Location = p33;
            Point p47 = new Point(655, 583);
            bunifuSwitch4.Location = p47;

            //tabPage14
            //nao esta feito
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            Point ponto13 = new Point(59, 22);
            Point ponto14 = new Point(62, 64);
            bunifuCustomLabel3.Location = ponto1;
            bunifuCustomLabel4.Location = ponto2;
            Point ponto15 = new Point(59, 127);
            Point ponto16 = new Point(62, 169);
            bunifuCustomLabel6.Location = ponto3;
            bunifuCustomLabel5.Location = ponto4;
            Point ponto17 = new Point(59, 232);
            Point ponto18 = new Point(62, 274);
            bunifuCustomLabel8.Location = ponto5;
            bunifuCustomLabel7.Location = ponto6;
            Point ponto19 = new Point(64, 337);
            Point ponto20 = new Point(67, 379);
            bunifuCustomLabel15.Location = ponto7;
            bunifuCustomLabel14.Location = ponto8;
            Point ponto21 = new Point(64, 442);
            Point ponto22 = new Point(67, 484);
            bunifuCustomLabel13.Location = ponto9;
            bunifuCustomLabel12.Location = ponto10;
            Point ponto23 = new Point(64, 547);
            Point ponto24 = new Point(67, 589);
            bunifuCustomLabel11.Location = ponto11;
            bunifuCustomLabel10.Location = ponto12;




        }

        private void tabPage12_Click(object sender, System.EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, System.EventArgs e)
        {
            bunifuCustomLabel9.Text = "Editar";
            alr_edit = false;
            location = 0;
        }

        private void bunifuCustomLabel9_Click(object sender, System.EventArgs e)
        { 
            string st1 = Convert.ToString(materialTabControl2.SelectedTab);
            if (alr_edit == false)
            {
               
                if (st1=="TabPage: {Alarmes Semanais}")
                {
                alr_edit = true;
                bunifuCustomLabel9.Text = "Ok";
              
                Point p1 = new Point(66, 40);
                Point p2 = pictureBox21.Location;
                Point p3 = new Point(p1.X, p2.Y);
                pictureBox21.Location = p3;   
                pictureBox21.Visible = true;

                Point p55 = pictureBox22.Location;
                Point p56 = new Point(p1.X, p55.Y);
                pictureBox22.Location = p56;  
                pictureBox22.Visible = true;

                Point p57 = pictureBox23.Location;
                Point p58 = new Point(p1.X, p57.Y);
                pictureBox23.Location = p58;  
                pictureBox23.Visible = true;

                Point p59 = pictureBox24.Location;
                Point p60 = new Point(p1.X, p59.Y);
                pictureBox24.Location = p60;  
                pictureBox24.Visible = true;

                Point p61 = pictureBox25.Location;
                Point p62 = new Point(p1.X, p61.Y);
                pictureBox25.Location = p62;  
                pictureBox25.Visible = true;

                Point p63 = pictureBox26.Location;
                Point p64 = new Point(p1.X, p63.Y);
                pictureBox26.Location = p64;  
                pictureBox26.Visible = true;


                Point ponto1 = new Point(109, 22);
                Point p4 = bunifuCustomLabel3.Location;
                Point p5 = new Point(ponto1.X, p4.Y);
                Point ponto2 = new Point(112, 64);
                Point p6 = bunifuCustomLabel4.Location;
                Point p7 = new Point(ponto2.X, p6.Y);
                bunifuCustomLabel3.Location = p5;
                bunifuCustomLabel4.Location = p7;
                Point p28 = new Point(66, 89);
                Point p29 = bunifuSeparator2.Location;
                Point p30 = new Point(p28.X, p29.Y);
                bunifuSeparator2.Location = p30;
                Point p42 = new Point(649, 58);
                Point p43 = bunifuSwitch1.Location;
                Point p44 = new Point(p42.X, p43.Y);
                bunifuSwitch1.Location = p44;

                Point ponto3 = new Point(109, 127);
                Point p8 = bunifuCustomLabel6.Location;
                Point p9 = new Point(ponto3.X, p8.Y);
                Point ponto4 = new Point(112, 169);
                Point p10 = bunifuCustomLabel5.Location;
                Point p11 = new Point(ponto4.X, p10.Y);
                bunifuCustomLabel6.Location = p9;
                bunifuCustomLabel5.Location = p11;
                Point p31 = new Point(66, 89);
                Point p32 = bunifuSeparator3.Location;
                Point p33 = new Point(p31.X, p32.Y);
                bunifuSeparator3.Location = p33;
                Point p45 = bunifuSwitch2.Location;
                Point p46 = new Point(p42.X, p45.Y);
                bunifuSwitch2.Location = p46;

                Point ponto5 = new Point(109, 232);
                Point p12 = bunifuCustomLabel8.Location;
                Point p13 = new Point(ponto5.X, p12.Y);
                Point ponto6 = new Point(112, 274);
                Point p14 = bunifuCustomLabel7.Location;
                Point p15 = new Point(ponto6.X, p14.Y);
                bunifuCustomLabel8.Location = p13;
                bunifuCustomLabel7.Location = p15;
                Point p34 = bunifuSeparator4.Location;
                Point p35 = new Point(p31.X, p34.Y);
                bunifuSeparator4.Location = p35;
                Point p47 = bunifuSwitch3.Location;
                Point p48 = new Point(p42.X, p47.Y);
                bunifuSwitch3.Location = p48;

                Point ponto7 = new Point(114, 337);
                Point p16 = bunifuCustomLabel15.Location;
                Point p17 = new Point(ponto7.X, p16.Y);
                Point ponto8 = new Point(117, 379);
                Point p18 = bunifuCustomLabel14.Location;
                Point p19 = new Point(ponto8.X, p18.Y);
                bunifuCustomLabel15.Location = p17;
                bunifuCustomLabel14.Location = p19;
                Point p36 = bunifuSeparator7.Location;
                Point p37 = new Point(p31.X, p36.Y);
                bunifuSeparator7.Location = p37;
                Point p49 = bunifuSwitch6.Location;
                Point p50 = new Point(p42.X, p49.Y);
                bunifuSwitch6.Location = p50;

                Point ponto9 = new Point(114, 442);
                Point p20 = bunifuCustomLabel13.Location;
                Point p21 = new Point(ponto9.X, p20.Y);
                Point ponto10 = new Point(117, 484);
                Point p22 = bunifuCustomLabel12.Location;
                Point p23 = new Point(ponto10.X, p22.Y);
                bunifuCustomLabel13.Location = p21;
                bunifuCustomLabel12.Location = p23;
                Point p38 = bunifuSeparator6.Location;
                Point p39 = new Point(p31.X, p38.Y);
                bunifuSeparator6.Location = p39;
                Point p51 = bunifuSwitch5.Location;
                Point p52 = new Point(p42.X, p51.Y);
                bunifuSwitch5.Location = p52;

                Point ponto11 = new Point(114, 547);
                Point p24 = bunifuCustomLabel11.Location;
                Point p25 = new Point(ponto11.X, p24.Y);
                Point ponto12 = new Point(117, 589);
                Point p26 = bunifuCustomLabel10.Location;
                Point p27 = new Point(ponto12.X, p26.Y);
                bunifuCustomLabel11.Location = p25;
                bunifuCustomLabel10.Location = p27;
                Point p40 = bunifuSeparator5.Location;
                Point p41 = new Point(p31.X, p40.Y);
                bunifuSeparator5.Location = p41;
                Point p53 = bunifuSwitch4.Location;
                Point p54 = new Point(p42.X, p53.Y);
                bunifuSwitch4.Location = p54;
                //bunifuCustomLabel3.Location=
                }
                    //nao esta feito
                else if (st1 == "TabPage: {Alarmes Pontuais}")
                {

                }
                    //nao esta feito
                else if (st1 == "TabPage: {Alarmes Mensais}")
                {
                    alr_edit = true;
                    bunifuCustomLabel9.Text = "Ok";

                    Point p1 = new Point(66, 40);
                    Point p2 = pictureBox32.Location;
                    Point p3 = new Point(p1.X, p2.Y);
                    pictureBox32.Location = p3;
                    pictureBox32.Visible = true;

                    Point p55 = pictureBox31.Location;
                    Point p56 = new Point(p1.X, p55.Y);
                    pictureBox31.Location = p56;
                    pictureBox31.Visible = true;

                    Point p57 = pictureBox30.Location;
                    Point p58 = new Point(p1.X, p57.Y);
                    pictureBox30.Location = p58;
                    pictureBox30.Visible = true;

                    Point p59 = pictureBox29.Location;
                    Point p60 = new Point(p1.X, p59.Y);
                    pictureBox29.Location = p60;
                    pictureBox29.Visible = true;

                    Point p61 = pictureBox28.Location;
                    Point p62 = new Point(p1.X, p61.Y);
                    pictureBox28.Location = p62;
                    pictureBox28.Visible = true;

                    Point p63 = pictureBox27.Location;
                    Point p64 = new Point(p1.X, p63.Y);
                    pictureBox27.Location = p64;
                    pictureBox27.Visible = true;


                    Point ponto1 = new Point(109, 22);
                    Point p4 = bunifuCustomLabel27.Location;
                    Point p5 = new Point(ponto1.X, p4.Y);
                    Point ponto2 = new Point(112, 64);
                    Point p6 = bunifuCustomLabel26.Location;
                    Point p7 = new Point(ponto2.X, p6.Y);
                    bunifuCustomLabel27.Location = p5;
                    bunifuCustomLabel26.Location = p7;
                    Point p28 = new Point(66, 89);
                    Point p29 = bunifuSeparator13.Location;
                    Point p30 = new Point(p28.X, p29.Y);
                    bunifuSeparator13.Location = p30;
                    Point p42 = new Point(649, 58);
                    Point p43 = bunifuSwitch12.Location;
                    Point p44 = new Point(p42.X, p43.Y);
                    bunifuSwitch12.Location = p44;

                    Point ponto3 = new Point(109, 127);
                    Point p8 = bunifuCustomLabel25.Location;
                    Point p9 = new Point(ponto3.X, p8.Y);
                    Point ponto4 = new Point(112, 169);
                    Point p10 = bunifuCustomLabel24.Location;
                    Point p11 = new Point(ponto4.X, p10.Y);
                    bunifuCustomLabel25.Location = p9;
                    bunifuCustomLabel24.Location = p11;
                    Point p31 = new Point(66, 89);
                    Point p32 = bunifuSeparator12.Location;
                    Point p33 = new Point(p31.X, p32.Y);
                    bunifuSeparator12.Location = p33;
                    Point p45 = bunifuSwitch11.Location;
                    Point p46 = new Point(p42.X, p45.Y);
                    bunifuSwitch11.Location = p46;

                    Point ponto5 = new Point(109, 232);
                    Point p12 = bunifuCustomLabel23.Location;
                    Point p13 = new Point(ponto5.X, p12.Y);
                    Point ponto6 = new Point(112, 274);
                    Point p14 = bunifuCustomLabel22.Location;
                    Point p15 = new Point(ponto6.X, p14.Y);
                    bunifuCustomLabel23.Location = p13;
                    bunifuCustomLabel22.Location = p15;
                    Point p34 = bunifuSeparator11.Location;
                    Point p35 = new Point(p31.X, p34.Y);
                    bunifuSeparator11.Location = p35;
                    Point p47 = bunifuSwitch10.Location;
                    Point p48 = new Point(p42.X, p47.Y);
                    bunifuSwitch10.Location = p48;

                    Point ponto7 = new Point(114, 337);
                    Point p16 = bunifuCustomLabel21.Location;
                    Point p17 = new Point(ponto7.X, p16.Y);
                    Point ponto8 = new Point(117, 379);
                    Point p18 = bunifuCustomLabel20.Location;
                    Point p19 = new Point(ponto8.X, p18.Y);
                    bunifuCustomLabel21.Location = p17;
                    bunifuCustomLabel20.Location = p19;
                    Point p36 = bunifuSeparator10.Location;
                    Point p37 = new Point(p31.X, p36.Y);
                    bunifuSeparator10.Location = p37;
                    Point p49 = bunifuSwitch9.Location;
                    Point p50 = new Point(p42.X, p49.Y);
                    bunifuSwitch9.Location = p50;

                    Point ponto9 = new Point(114, 442);
                    Point p20 = bunifuCustomLabel19.Location;
                    Point p21 = new Point(ponto9.X, p20.Y);
                    Point ponto10 = new Point(117, 484);
                    Point p22 = bunifuCustomLabel18.Location;
                    Point p23 = new Point(ponto10.X, p22.Y);
                    bunifuCustomLabel19.Location = p21;
                    bunifuCustomLabel18.Location = p23;
                    Point p38 = bunifuSeparator9.Location;
                    Point p39 = new Point(p31.X, p38.Y);
                    bunifuSeparator9.Location = p39;
                    Point p51 = bunifuSwitch8.Location;
                    Point p52 = new Point(p42.X, p51.Y);
                    bunifuSwitch8.Location = p52;

                    Point ponto11 = new Point(114, 547);
                    Point p24 = bunifuCustomLabel17.Location;
                    Point p25 = new Point(ponto11.X, p24.Y);
                    Point ponto12 = new Point(117, 589);
                    Point p26 = bunifuCustomLabel16.Location;
                    Point p27 = new Point(ponto12.X, p26.Y);
                    bunifuCustomLabel17.Location = p25;
                    bunifuCustomLabel16.Location = p27;
                    Point p40 = bunifuSeparator8.Location;
                    Point p41 = new Point(p31.X, p40.Y);
                    bunifuSeparator8.Location = p41;
                    Point p53 = bunifuSwitch7.Location;
                    Point p54 = new Point(p42.X, p53.Y);
                    bunifuSwitch7.Location = p54;
                }

                
            }
            else if (alr_edit == true)
            {
               
                if (st1 == "TabPage: {Alarmes Semanais}")
                {
                    alr_edit = false;
                    bunifuCustomLabel9.Text = "Editar";

                    Point ponto1 = new Point(59, 22);
                    Point p4 = bunifuCustomLabel3.Location;
                    Point p5 = new Point(ponto1.X, p4.Y);
                    Point ponto2 = new Point(62, 64);
                    Point p6 = bunifuCustomLabel4.Location;
                    Point p7 = new Point(ponto2.X, p6.Y);
                    bunifuCustomLabel3.Location = p5;
                    bunifuCustomLabel4.Location = p7;
                    Point p28 = new Point(66, 89);
                    Point p29 = bunifuSeparator2.Location;
                    Point p30 = new Point(p28.X, p29.Y);
                    bunifuSeparator2.Location = p30;
                    Point p42 = new Point(649, 58);
                    Point p43 = bunifuSwitch1.Location;
                    Point p44 = new Point(p42.X, p43.Y);
                    bunifuSwitch1.Location = p44;

                    Point ponto3 = new Point(59, 127);
                    Point p8 = bunifuCustomLabel6.Location;
                    Point p9 = new Point(ponto3.X, p8.Y);
                    Point ponto4 = new Point(62, 169);
                    Point p10 = bunifuCustomLabel5.Location;
                    Point p11 = new Point(ponto4.X, p10.Y);
                    bunifuCustomLabel6.Location = p9;
                    bunifuCustomLabel5.Location = p11;
                    Point p31 = new Point(66, 89);
                    Point p32 = bunifuSeparator3.Location;
                    Point p33 = new Point(p31.X, p32.Y);
                    bunifuSeparator3.Location = p33;
                    Point p45 = bunifuSwitch2.Location;
                    Point p46 = new Point(p42.X, p45.Y);
                    bunifuSwitch2.Location = p46;

                    Point ponto5 = new Point(59, 232);
                    Point p12 = bunifuCustomLabel8.Location;
                    Point p13 = new Point(ponto5.X, p12.Y);
                    Point ponto6 = new Point(62, 274);
                    Point p14 = bunifuCustomLabel7.Location;
                    Point p15 = new Point(ponto6.X, p14.Y);
                    bunifuCustomLabel8.Location = p13;
                    bunifuCustomLabel7.Location = p15;
                    Point p34 = bunifuSeparator4.Location;
                    Point p35 = new Point(p31.X, p34.Y);
                    bunifuSeparator4.Location = p35;
                    Point p47 = bunifuSwitch3.Location;
                    Point p48 = new Point(p42.X, p47.Y);
                    bunifuSwitch3.Location = p48;

                    Point ponto7 = new Point(64, 337);
                    Point p16 = bunifuCustomLabel15.Location;
                    Point p17 = new Point(ponto7.X, p16.Y);
                    Point ponto8 = new Point(67, 379);
                    Point p18 = bunifuCustomLabel14.Location;
                    Point p19 = new Point(ponto8.X, p18.Y);
                    bunifuCustomLabel15.Location = p17;
                    bunifuCustomLabel14.Location = p19;
                    Point p36 = bunifuSeparator7.Location;
                    Point p37 = new Point(p31.X, p36.Y);
                    bunifuSeparator7.Location = p37;
                    Point p49 = bunifuSwitch6.Location;
                    Point p50 = new Point(p42.X, p49.Y);
                    bunifuSwitch6.Location = p50;

                    Point ponto9 = new Point(64, 442);
                    Point p20 = bunifuCustomLabel13.Location;
                    Point p21 = new Point(ponto9.X, p20.Y);
                    Point ponto10 = new Point(67, 484);
                    Point p22 = bunifuCustomLabel12.Location;
                    Point p23 = new Point(ponto10.X, p22.Y);
                    bunifuCustomLabel13.Location = p21;
                    bunifuCustomLabel12.Location = p23;
                    Point p38 = bunifuSeparator6.Location;
                    Point p39 = new Point(p31.X, p38.Y);
                    bunifuSeparator6.Location = p39;
                    Point p51 = bunifuSwitch5.Location;
                    Point p52 = new Point(p42.X, p51.Y);
                    bunifuSwitch5.Location = p52;

                    Point ponto11 = new Point(64, 547);
                    Point p24 = bunifuCustomLabel11.Location;
                    Point p25 = new Point(ponto11.X, p24.Y);
                    Point ponto12 = new Point(67, 589);
                    Point p26 = bunifuCustomLabel10.Location;
                    Point p27 = new Point(ponto12.X, p26.Y);
                    bunifuCustomLabel11.Location = p25;
                    bunifuCustomLabel10.Location = p27;
                    Point p40 = bunifuSeparator5.Location;
                    Point p41 = new Point(p31.X, p40.Y);
                    bunifuSeparator5.Location = p41;
                    Point p53 = bunifuSwitch4.Location;
                    Point p54 = new Point(p42.X, p53.Y);
                    bunifuSwitch4.Location = p54;

                    pictureBox21.Visible = false;
                    pictureBox22.Visible = false;
                    pictureBox23.Visible = false;
                    pictureBox24.Visible = false;
                    pictureBox25.Visible = false;
                    pictureBox26.Visible = false;
                }
                    //nao esta feito
                else if (st1 == "TabPage: {Alarmes Pontuais}")
                {

                }
                    //nao esta feito
                else if (st1 == "TabPage: {Alarmes Mensais}")
                {
                    alr_edit = false;
                    bunifuCustomLabel9.Text = "Editar";

                    Point ponto1 = new Point(59, 22);
                    Point p4 = bunifuCustomLabel27.Location;
                    Point p5 = new Point(ponto1.X, p4.Y);
                    Point ponto2 = new Point(62, 64);
                    Point p6 = bunifuCustomLabel26.Location;
                    Point p7 = new Point(ponto2.X, p6.Y);
                    bunifuCustomLabel27.Location = p5;
                    bunifuCustomLabel26.Location = p7;
                    Point p28 = new Point(66, 89);
                    Point p29 = bunifuSeparator13.Location;
                    Point p30 = new Point(p28.X, p29.Y);
                    bunifuSeparator13.Location = p30;
                    Point p42 = new Point(649, 58);
                    Point p43 = bunifuSwitch12.Location;
                    Point p44 = new Point(p42.X, p43.Y);
                    bunifuSwitch12.Location = p44;

                    Point ponto3 = new Point(59, 127);
                    Point p8 = bunifuCustomLabel25.Location;
                    Point p9 = new Point(ponto3.X, p8.Y);
                    Point ponto4 = new Point(62, 169);
                    Point p10 = bunifuCustomLabel24.Location;
                    Point p11 = new Point(ponto4.X, p10.Y);
                    bunifuCustomLabel25.Location = p9;
                    bunifuCustomLabel24.Location = p11;
                    Point p31 = new Point(66, 89);
                    Point p32 = bunifuSeparator12.Location;
                    Point p33 = new Point(p31.X, p32.Y);
                    bunifuSeparator12.Location = p33;
                    Point p45 = bunifuSwitch11.Location;
                    Point p46 = new Point(p42.X, p45.Y);
                    bunifuSwitch11.Location = p46;

                    Point ponto5 = new Point(59, 232);
                    Point p12 = bunifuCustomLabel23.Location;
                    Point p13 = new Point(ponto5.X, p12.Y);
                    Point ponto6 = new Point(62, 274);
                    Point p14 = bunifuCustomLabel22.Location;
                    Point p15 = new Point(ponto6.X, p14.Y);
                    bunifuCustomLabel23.Location = p13;
                    bunifuCustomLabel22.Location = p15;
                    Point p34 = bunifuSeparator11.Location;
                    Point p35 = new Point(p31.X, p34.Y);
                    bunifuSeparator11.Location = p35;
                    Point p47 = bunifuSwitch10.Location;
                    Point p48 = new Point(p42.X, p47.Y);
                    bunifuSwitch10.Location = p48;

                    Point ponto7 = new Point(64, 337);
                    Point p16 = bunifuCustomLabel21.Location;
                    Point p17 = new Point(ponto7.X, p16.Y);
                    Point ponto8 = new Point(67, 379);
                    Point p18 = bunifuCustomLabel20.Location;
                    Point p19 = new Point(ponto8.X, p18.Y);
                    bunifuCustomLabel21.Location = p17;
                    bunifuCustomLabel20.Location = p19;
                    Point p36 = bunifuSeparator10.Location;
                    Point p37 = new Point(p31.X, p36.Y);
                    bunifuSeparator10.Location = p37;
                    Point p49 = bunifuSwitch9.Location;
                    Point p50 = new Point(p42.X, p49.Y);
                    bunifuSwitch9.Location = p50;

                    Point ponto9 = new Point(64, 442);
                    Point p20 = bunifuCustomLabel19.Location;
                    Point p21 = new Point(ponto9.X, p20.Y);
                    Point ponto10 = new Point(67, 484);
                    Point p22 = bunifuCustomLabel18.Location;
                    Point p23 = new Point(ponto10.X, p22.Y);
                    bunifuCustomLabel19.Location = p21;
                    bunifuCustomLabel18.Location = p23;
                    Point p38 = bunifuSeparator9.Location;
                    Point p39 = new Point(p31.X, p38.Y);
                    bunifuSeparator9.Location = p39;
                    Point p51 = bunifuSwitch8.Location;
                    Point p52 = new Point(p42.X, p51.Y);
                    bunifuSwitch8.Location = p52;

                    Point ponto11 = new Point(64, 547);
                    Point p24 = bunifuCustomLabel17.Location;
                    Point p25 = new Point(ponto11.X, p24.Y);
                    Point ponto12 = new Point(67, 589);
                    Point p26 = bunifuCustomLabel16.Location;
                    Point p27 = new Point(ponto12.X, p26.Y);
                    bunifuCustomLabel17.Location = p25;
                    bunifuCustomLabel16.Location = p27;
                    Point p40 = bunifuSeparator8.Location;
                    Point p41 = new Point(p31.X, p40.Y);
                    bunifuSeparator8.Location = p41;
                    Point p53 = bunifuSwitch7.Location;
                    Point p54 = new Point(p42.X, p53.Y);
                    bunifuSwitch7.Location = p54;

                    pictureBox32.Visible = false;
                    pictureBox31.Visible = false;
                    pictureBox30.Visible = false;
                    pictureBox29.Visible = false;
                    pictureBox28.Visible = false;
                    pictureBox27.Visible = false;
                }




            }
            
        }

        private void btnUp_Click(object sender, System.EventArgs e)
        {
            //if (location - 20 > 0)
            //{
            //    location -= 20;
            //    tabPage12.VerticalScroll.Value = location;
            //}
            //else
            //{
            //    // If scroll position is below 0 set the position to 0 (MIN)
            //    location = 0;
            //    tabPage12.AutoScrollPosition = new Point(0, location);
            //}
        }

        private void btnDown_Click(object sender, System.EventArgs e)
        {
            //if (location + 20 < tabPage12.VerticalScroll.Maximum)
            //{
            //    location += 20;
            //    tabPage12.VerticalScroll.Value = location;
            //}
            //else
            //{
            //    // If scroll position is above 280 set the position to 280 (MAX)
            //    location = tabPage12.VerticalScroll.Maximum;
            //    tabPage12.AutoScrollPosition = new Point(0, location);
            //}
        }

        private void btnDown_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
             string st1 = Convert.ToString(materialTabControl2.SelectedTab);

             if (st1 == "TabPage: {Alarmes Semanais}")
             {
                 if (location + 20 < tabPage12.VerticalScroll.Maximum)
                 {
                     location += 20;
                     tabPage12.VerticalScroll.Value = location;
                 }
                 else
                 {
                     // If scroll position is above 280 set the position to 280 (MAX)
                     location = tabPage12.VerticalScroll.Maximum;
                     tabPage12.AutoScrollPosition = new Point(0, location);
                 }
             }
             else if (st1 == "TabPage: {Alarmes Pontuais}")
             {

             }
             //nao esta feito
             else if (st1 == "TabPage: {Alarmes Mensais}")
             {
                 if (location + 20 < tabPage14.VerticalScroll.Maximum)
                 {
                     location += 20;
                     tabPage14.VerticalScroll.Value = location;
                 }
                 else
                 {
                     // If scroll position is above 280 set the position to 280 (MAX)
                     location = tabPage14.VerticalScroll.Maximum;
                     tabPage14.AutoScrollPosition = new Point(0, location);
                 }
             }
        }

        private void btnUp_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            string st1 = Convert.ToString(materialTabControl2.SelectedTab);

            if (st1 == "TabPage: {Alarmes Semanais}")
            {
                if (location - 20 > 0)
                {
                    location -= 20;
                    tabPage12.VerticalScroll.Value = location;
                }
                else
                {
                    // If scroll position is below 0 set the position to 0 (MIN)
                    location = 0;
                    tabPage12.AutoScrollPosition = new Point(0, location);
                }
            }
            else if (st1 == "TabPage: {Alarmes Pontuais}")
             {

             }
             //nao esta feito
            else if (st1 == "TabPage: {Alarmes Mensais}")
            {
                if (location - 20 > 0)
                {
                    location -= 20;
                    tabPage14.VerticalScroll.Value = location;
                }
                else
                {
                    // If scroll position is below 0 set the position to 0 (MIN)
                    location = 0;
                    tabPage14.AutoScrollPosition = new Point(0, location);
                }
            }
        }

        private void bunifuCustomLabel28_Click(object sender, EventArgs e)
        {
            textBox4.Text = DateTime.Now.ToString("HH");
            textBox3.Text = DateTime.Now.ToString("mm");
            label53.Text = "Nunca";
            materialTabControl1.SelectedTab = tabPage15;



            string st1 = materialTabControl2.SelectedTab.ToString();
            if (st1 == "TabPage: {Alarmes Semanais}")
            {
                label52.Text = "Repetir";
                materialTabControl3.SelectedTab = tabPage19;
                alr_edit = false;
                bunifuCustomLabel9.Text = "Editar";
                tabPage12.AutoScrollPosition = new Point(0, 0);
                tabPage12.VerticalScroll.Minimum = 0;
                tabPage13.AutoScrollPosition = new Point(0, 0);
                tabPage13.VerticalScroll.Minimum = 0;
                tabPage14.AutoScrollPosition = new Point(0, 0);
                tabPage14.VerticalScroll.Minimum = 0;
                tabPage16.AutoScrollPosition = new Point(0, 0);
                tabPage16.VerticalScroll.Minimum = 0;
                tabPage18.AutoScrollPosition = new Point(0, 0);
                tabPage18.VerticalScroll.Minimum = 0;

              

                label53.Text = "Nunca";
                pictureBox38.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;

                label56.Text = "Alarme";
                textBox27.Text = "Alarme";

                label59.Text = "Radar";
                pictureBox39.Visible = true;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                id_toque = 1;

                //for (int i = 0; i < 6; i++)
                //{
                //    dias[i] = false;
                //}
                //dias[0] = false;
                //dias[1] = false;
                //dias[2] = false;
                //dias[3] = false;
                //dias[4] = false;
                //dias[5] = false;
                //dias[6] = false;

                //id_toque = 1;


            }
            else if (st1 == "TabPage: {Alarmes Pontuais}"){
                materialTabControl3.SelectedTab = tabPage19;
                label52.Text = "Data";
                alr_edit = false;
                bunifuCustomLabel9.Text = "Editar";
                tabPage12.AutoScrollPosition = new Point(0, 0);
                tabPage12.VerticalScroll.Minimum = 0;
                tabPage13.AutoScrollPosition = new Point(0, 0);
                tabPage13.VerticalScroll.Minimum = 0;
                tabPage14.AutoScrollPosition = new Point(0, 0);
                tabPage14.VerticalScroll.Minimum = 0;

                dias[0] = false;
                dias[1] = false;
                dias[2] = false;
                dias[3] = false;
                dias[4] = false;
                dias[5] = false;
                dias[6] = false;

                id_toque = 1;
            }
            else if (st1 == "TabPage: {Alarmes Mensais}")
            {
                label52.Text = "Repetir nos dias";
                materialTabControl3.SelectedTab = tabPage19;
                //materialTabControl3.SelectedTab = tabPage21;
                for (int i = 0; i < 31; i++)
                {
                    diasM[i + 1] = false;
                }
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();

                label37.Text = "Nunca";
                label53.Text = "Nunca";

                label56.Text = "Alarme";
                textBox27.Text = "Alarme";

                label59.Text = "Radar";
                pictureBox39.Visible = true;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                id_toque = 1;
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                comboBox1.Items.Clear();
                comboBox1.Text = "";
                alarmR = false;
                comboBox2.Visible = false;
                bunifuImageButton9.Visible = false;
            }
            
        }

        private void bunifuCustomLabel30_Click(object sender, EventArgs e)
        {
            int md = 0;
            string st1 = materialTabControl3.SelectedTab.ToString();

            if (st1 == "TabPage: {Criar Semanais}")
            {
                materialTabControl1.SelectedTab = tabPage11;
                for (int i = 0; i < 6; i++)
                {
                    dias[i] = false;
                }
                //textBox4.Text = "18";
                //textBox3.Text = "48";

                //label53.Text = "Nunca";
                //pictureBox38.Visible = false;
                //pictureBox47.Visible = false;
                //pictureBox48.Visible = false;
                //pictureBox50.Visible = false;
                //pictureBox51.Visible = false;
                //pictureBox52.Visible = false;
                //pictureBox53.Visible = false;

                //label56.Text = "Alarme";
                //textBox27.Text = "Alarme";

                //label59.Text = "Door Bell";
                //pictureBox39.Visible = true;
                //pictureBox41.Visible = false;
                //pictureBox42.Visible = false;
                //pictureBox43.Visible = false;
                //pictureBox44.Visible = false;
                //pictureBox45.Visible = false;
                //pictureBox46.Visible = false;
                //id_toque = 1;
            }
            else if (st1 == "TabPage: {Repetir}")
            {
                bunifuCustomLabel30.Text = "Cancelar";
                bunifuCustomLabel31.Visible=true;
                bunifuCustomLabel29.Visible = true;
                bunifuCustomLabel31.Text = "Criar";
                materialTabControl3.SelectedTab = tabPage19;
                label53.Text = "Nunca";
                    
                if (dias[1] == true && label53.Text == "Nunca"){
                    label53.Text = "dom";
                    md += 1;
                }                  
                else if (dias[1] == true && label53.Text != "Nunca"){
                    label53.Text += " dom";
                    md += 1;
                }
                    
                if (dias[2] == true && label53.Text == "Nunca"){
                    label53.Text = "seg";
                    md += 1;
                }                   
                else if (dias[2] == true && label53.Text != "Nunca"){
                    label53.Text += " seg";
                    md += 1;
                }
                    
                if (dias[3] == true && label53.Text == "Nunca"){
                    label53.Text = "ter";
                    md += 1;
                }                    
                else if (dias[3] == true && label53.Text != "Nunca"){
                    label53.Text += " ter";
                    md += 1;
                }
                    
                if (dias[4] == true && label53.Text == "Nunca"){
                    label53.Text = "qua";
                    md += 1;
                }             
                else if (dias[4] == true && label53.Text != "Nunca"){
                    label53.Text += " qua";
                    md += 1;
                }
                    
                if (dias[5] == true && label53.Text == "Nunca"){
                      label53.Text = "qui";
                      md += 1;
                }                 
                else if (dias[5] == true && label53.Text != "Nunca"){
                    label53.Text += " qui";
                    md += 1;
                }
                    
                if (dias[6] == true && label53.Text == "Nunca"){
                    label53.Text = "sex";
                    md += 1;
                }
                else if (dias[6] == true && label53.Text != "Nunca")
                {
                   label53.Text += " sex";
                    md += 1;
                }

                if (dias[0] == true && label53.Text == "Nunca")
                {
                    label53.Text = "sab";
                    md += 1;
                }
                else if (dias[0] == true && label53.Text != "Nunca")
                {
                    label53.Text += " sab";
                    md += 1;
                }

                if (dias[0] == true && dias[1] == true && dias[2] == true && dias[3] == true && dias[4] == true && dias[5] == true && dias[6])
                    label53.Text = "todos os dias";

                //sim, isto esta feito
                if (md >= 2)
                {

                }
                else
                {
                    if (dias[1] == true)
                        label53.Text = "ao domingo";
                    else if (dias[2] == true)
                        label53.Text = "à segunda";
                    else if (dias[3] == true)
                        label53.Text = "à terça";
                    else if (dias[4] == true)
                        label53.Text = "à quarta";
                    else if (dias[5] == true)
                        label53.Text = "à quinta";
                    else if (dias[6] == true)
                        label53.Text = "à sexta";
                    else if (dias[0] == true)
                        label53.Text = "ao sábado";
                   
                }

                bunifuCustomLabel29.Visible = true;
            }
            else if (st1 == "TabPage: {Descrição}")
            {
                bunifuCustomLabel30.Text = "Cancelar";
                bunifuCustomLabel31.Visible = true;
                materialTabControl3.SelectedTab = tabPage19;
                label56.Text = textBox27.Text;
                bunifuCustomLabel31.Text = "Criar";
            }
            else if (st1 == "TabPage: {Toque}")
            {
                bunifuCustomLabel30.Text = "Cancelar";
                bunifuCustomLabel31.Visible = true;
                bunifuCustomLabel31.Text = "Criar";
                materialTabControl3.SelectedTab = tabPage19;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox39.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                if (toqueA == true)
                {
                    Toque.Stop();
                    toqueA = false;
                }
            }
            else if (st1 == "TabPage: {Pontuais_Data}")
            {
                materialTabControl3.SelectedTab = tabPage19;

                label53.Text = dateTimePicker1.Text;
                bunifuCustomLabel30.Text = "Cancelar";
                bunifuCustomLabel31.Visible = true;
                bunifuCustomLabel31.Text = "Criar";

            }
            else if (st1 == "TabPage: {Criar Mensais}")
            {
                materialTabControl3.SelectedTab = tabPage19;

                label53.Text = label37.Text;
                bunifuCustomLabel30.Text = "Cancelar";
                bunifuCustomLabel31.Visible = true;
                bunifuCustomLabel31.Text = "Criar";


            }
            


            bunifuCustomLabel29.Visible = true;
            
        }

        private void tabPage19_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            tabPage16.AutoScrollPosition = new Point(0, 0);
            tabPage16.VerticalScroll.Minimum = 0;
            if (label52.Text=="Repetir")
            {              

                materialTabControl3.SelectedTab = tabPage16;
                bunifuCustomLabel30.Text = "< Anterior";
                bunifuCustomLabel29.Visible = false;
                bunifuCustomLabel31.Text = "Repetir";
                bunifuCustomLabel31.Visible = true;
            }
            else if (label52.Text=="Data")
            {
                materialTabControl3.SelectedTab = tabPage20;
                bunifuCustomLabel30.Text = "< Anterior";
                bunifuCustomLabel29.Visible = false;
                bunifuCustomLabel31.Text = "Data";
                bunifuCustomLabel31.Visible = true;
                dateTimePicker1.MinDate = DateTime.Today;
                //datet
            }
            else if (label52.Text == "Repetir nos dias")
            {
                materialTabControl3.SelectedTab = tabPage21;
                bunifuCustomLabel30.Text = "< Anterior";
                bunifuCustomLabel29.Visible = false;
                bunifuCustomLabel31.Text = "Repetir nos dias";
                bunifuCustomLabel31.Visible = true;
                //comboBox1.Items.Clear();
                //comboBox2.Items.Clear();

                for (int i = 0; i < 31; i++)
                {
                    comboBox1.Items.Add(i + 1);

                }
            }
            

        }

        private void label53_Click(object sender, EventArgs e)
        {
            tabPage16.AutoScrollPosition = new Point(0, 0);
            tabPage16.VerticalScroll.Minimum = 0;
            if (label52.Text == "Repetir")
            {

                materialTabControl3.SelectedTab = tabPage16;
                bunifuCustomLabel30.Text = "< Anterior";
                bunifuCustomLabel29.Visible = false;
                bunifuCustomLabel31.Text = "Repetir";
                bunifuCustomLabel31.Visible = true;
            }
            else if (label52.Text == "Data")
            {
                materialTabControl3.SelectedTab = tabPage20;
                bunifuCustomLabel30.Text = "< Anterior";
                bunifuCustomLabel29.Visible = false;
                bunifuCustomLabel31.Text = "Data";
                bunifuCustomLabel31.Visible = true;
                dateTimePicker1.MinDate = DateTime.Today;
            }
            else if (label52.Text == "Repetir nos dias")
            {
                materialTabControl3.SelectedTab = tabPage21;
                bunifuCustomLabel30.Text = "< Anterior";
                bunifuCustomLabel29.Visible = false;
                bunifuCustomLabel31.Text = "Repetir nos dias";
                bunifuCustomLabel31.Visible = true;
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();


                for (int i = 0; i < 31; i++)
                {
                    if (diasM[i + 1] == true)
                    {
                        comboBox2.Items.Add(i + 1);
                    }
                    else
                    {
                        comboBox1.Items.Add(i + 1);
                    }


                }
            }
        }

        private void label52_Click(object sender, EventArgs e)
        {
            tabPage16.AutoScrollPosition = new Point(0, 0);
            tabPage16.VerticalScroll.Minimum = 0;
            if (label52.Text == "Repetir")
            {

                materialTabControl3.SelectedTab = tabPage16;
                bunifuCustomLabel30.Text = "< Anterior";
                bunifuCustomLabel29.Visible = false;
                bunifuCustomLabel31.Text = "Repetir";
                bunifuCustomLabel31.Visible = true;
            }
            else if (label52.Text == "Data")
            {
                materialTabControl3.SelectedTab = tabPage20;
                bunifuCustomLabel30.Text = "< Anterior";
                bunifuCustomLabel29.Visible = false;
                bunifuCustomLabel31.Text = "Data";
                bunifuCustomLabel31.Visible = true;
                dateTimePicker1.MinDate = DateTime.Today;
            }
            else if (label52.Text == "Repetir nos dias")
            {
                materialTabControl3.SelectedTab = tabPage21;
                bunifuCustomLabel30.Text = "< Anterior";
                bunifuCustomLabel29.Visible = false;
                bunifuCustomLabel31.Text = "Repetir nos dias";
                bunifuCustomLabel31.Visible = true;
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();


                for (int i = 0; i < 31; i++)
                {
                    if (diasM[i + 1] == true)
                    {
                        comboBox2.Items.Add(i + 1);
                    }
                    else
                    {
                        comboBox1.Items.Add(i + 1);
                    }
                    

                }
            }
        }

        private void label54_Click(object sender, EventArgs e)
        {
            tabPage16.AutoScrollPosition = new Point(0, 0);
            tabPage16.VerticalScroll.Minimum = 0;
            if (label52.Text == "Repetir")
            {

                materialTabControl3.SelectedTab = tabPage16;
                bunifuCustomLabel30.Text = "< Anterior";
                bunifuCustomLabel29.Visible = false;
                bunifuCustomLabel31.Text = "Repetir";
                bunifuCustomLabel31.Visible = true;
            }
            else if (label52.Text == "Data")
            {
                materialTabControl3.SelectedTab = tabPage20;
                bunifuCustomLabel30.Text = "< Anterior";
                bunifuCustomLabel29.Visible = false;
                bunifuCustomLabel31.Text = "Data";
                bunifuCustomLabel31.Visible = true;
                dateTimePicker1.MinDate = DateTime.Today;
            }
            else if (label52.Text == "Repetir nos dias")
            {
                materialTabControl3.SelectedTab = tabPage21;
                bunifuCustomLabel30.Text = "< Anterior";
                bunifuCustomLabel29.Visible = false;
                bunifuCustomLabel31.Text = "Repetir nos dias";
                bunifuCustomLabel31.Visible = true;
                //comboBox1.Items.Clear();
                //comboBox2.Items.Clear();

                for (int i = 0; i < 31; i++)
                {
                    comboBox1.Items.Add(i + 1);

                }
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            bunifuImageButton4.Visible = false;
            materialTabControl1.SelectedTab = tabPage29;
            if (toqueA == true)
            {
                Toque.Stop();
                toqueA = false;
            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage3;
            bunifuImageButton5.Focus();

            if (toqueA == true)
            {
                Toque.Stop();
                toqueA = false;
            }
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage7;

            bunifuFlatButton4.Focus();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage8;

            bunifuFlatButton4.Focus();
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage25;
            bunifuFlatButton4.Focus();

            DataTable dt = BLL.Medicos.LoadMed_fam();

            textBox17.Text = dt.Rows[0][1].ToString();
            textBox18.Text = dt.Rows[0][3].ToString();
            textBox19.Text = dt.Rows[0][2].ToString();
            textBox20.Text = dt.Rows[0][4].ToString();
            textBox21.Text = dt.Rows[0][5].ToString();

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
           
                string st1 = Convert.ToString(materialTabControl3.SelectedTab);

                if (st1 == "TabPage: {Toque}")
                {
                    if (location - 20 > 0)
                    {
                        location -= 20;
                        tabPage18.VerticalScroll.Value = location;
                    }
                    else
                    {
                        // If scroll position is below 0 set the position to 0 (MIN)
                        location = 0;
                        tabPage18.AutoScrollPosition = new Point(0, location);
                    }
                
                   }


            
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            materialTabControl3.SelectedTab = tabPage17;
            bunifuCustomLabel30.Text = "< Anterior";
            bunifuCustomLabel29.Visible = false;
            bunifuCustomLabel31.Text = "Descrição";
            bunifuCustomLabel31.Visible = true;
        }

        private void label57_Click(object sender, EventArgs e)
        {
            materialTabControl3.SelectedTab = tabPage17;
            bunifuCustomLabel30.Text = "< Anterior";
            bunifuCustomLabel29.Visible = false;
            bunifuCustomLabel31.Text = "Descrição";
            bunifuCustomLabel31.Visible = true;
        }

        private void label56_Click(object sender, EventArgs e)
        {
            materialTabControl3.SelectedTab = tabPage17;
            bunifuCustomLabel30.Text = "< Anterior";
            bunifuCustomLabel29.Visible = false;
            bunifuCustomLabel31.Text = "Descrição";
            bunifuCustomLabel31.Visible = true;
        }

        private void label55_Click(object sender, EventArgs e)
        {
            materialTabControl3.SelectedTab = tabPage17;
            bunifuCustomLabel30.Text = "< Anterior";
            bunifuCustomLabel29.Visible = false;
            bunifuCustomLabel31.Text = "Descrição";
            bunifuCustomLabel31.Visible = true;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            materialTabControl3.SelectedTab = tabPage18;
            bunifuCustomLabel30.Text = "< Anterior";
            bunifuCustomLabel29.Visible = false;
            bunifuCustomLabel31.Text = "Toque";
            bunifuCustomLabel31.Visible = true;
            pictureBox35.Visible = true;
            pictureBox36.Visible = true;
            tabPage18.AutoScrollPosition = new Point(0, 0);
            tabPage18.VerticalScroll.Minimum = 0;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            string st1 = Convert.ToString(materialTabControl3.SelectedTab);

            if (st1 == "TabPage: {Toque}")
            {
                if (location + 20 < tabPage18.VerticalScroll.Maximum)
                {
                    location += 20;
                    tabPage18.VerticalScroll.Value = location;
                }
                else
                {
                    // If scroll position is above 280 set the position to 280 (MAX)
                    location = tabPage18.VerticalScroll.Maximum;
                    tabPage18.AutoScrollPosition = new Point(0, location);
                }
            }
    
        }

        private void label60_Click(object sender, EventArgs e)
        {
            materialTabControl3.SelectedTab = tabPage18;
            bunifuCustomLabel30.Text = "< Anterior";
            bunifuCustomLabel29.Visible = false;
            bunifuCustomLabel31.Text = "Toque";
            bunifuCustomLabel31.Visible = true;
            pictureBox35.Visible = true;
            pictureBox36.Visible = true;
            tabPage18.AutoScrollPosition = new Point(0, 0);
            tabPage18.VerticalScroll.Minimum = 0;
        }

        private void label59_Click(object sender, EventArgs e)
        {
            materialTabControl3.SelectedTab = tabPage18;
            bunifuCustomLabel30.Text = "< Anterior";
            bunifuCustomLabel29.Visible = false;
            bunifuCustomLabel31.Text = "Toque";
            bunifuCustomLabel31.Visible = true;
            pictureBox35.Visible = true;
            pictureBox36.Visible = true;
            tabPage18.AutoScrollPosition = new Point(0, 0);
            tabPage18.VerticalScroll.Minimum = 0;
        }

        private void label58_Click(object sender, EventArgs e)
        {
            materialTabControl3.SelectedTab = tabPage18;
            bunifuCustomLabel30.Text = "< Anterior";
            bunifuCustomLabel29.Visible = false;
            bunifuCustomLabel31.Text = "Toque";
            bunifuCustomLabel31.Visible = true;
            pictureBox35.Visible = true;
            pictureBox36.Visible = true;
            tabPage18.AutoScrollPosition = new Point(0, 0);
            tabPage18.VerticalScroll.Minimum = 0;
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            if (pictureBox38.Visible==false)
            pictureBox38.Visible = true;
            else
                pictureBox38.Visible = false;

            if (dias[1] == true)
                dias[1] = false;
            else
                dias[1] = true;

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {
            if (pictureBox38.Visible == false)
                pictureBox38.Visible = true;
            else
                pictureBox38.Visible = false;

            if (dias[1] == true)
                dias[1] = false;
            else
                dias[1] = true;
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            if (pictureBox47.Visible == false)
                pictureBox47.Visible = true;
            else
                pictureBox47.Visible = false;

            if (dias[2] == true)
                dias[2] = false;
            else
                dias[2] = true;
        }

        private void label66_Click(object sender, EventArgs e)
        {
            if (pictureBox47.Visible == false)
                pictureBox47.Visible = true;
            else
                pictureBox47.Visible = false;

            if (dias[2] == true)
                dias[2] = false;
            else
                dias[2] = true;
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            if (pictureBox48.Visible == false)
                pictureBox48.Visible = true;
            else
                pictureBox48.Visible = false;

            if (dias[3] == true)
                dias[3] = false;
            else
                dias[3] = true;
        }

        private void label63_Click(object sender, EventArgs e)
        {
            if (pictureBox48.Visible == false)
                pictureBox48.Visible = true;
            else
                pictureBox48.Visible = false;

            if (dias[3] == true)
                dias[3] = false;
            else
                dias[3] = true;
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            if (pictureBox50.Visible == false)
                pictureBox50.Visible = true;
            else
                pictureBox50.Visible = false;

            if (dias[4] == true)
                dias[4] = false;
            else
                dias[4] = true;
        }

        private void label61_Click(object sender, EventArgs e)
        {
            if (pictureBox50.Visible == false)
                pictureBox50.Visible = true;
            else
                pictureBox50.Visible = false;

            if (dias[4] == true)
                dias[4] = false;
            else
                dias[4] = true;
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            if (pictureBox51.Visible == false)
                pictureBox51.Visible = true;
            else
                pictureBox51.Visible = false;

            if (dias[5] == true)
                dias[5] = false;
            else
                dias[5] = true;
        }

        private void label62_Click(object sender, EventArgs e)
        {
            if (pictureBox51.Visible == false)
                pictureBox51.Visible = true;
            else
                pictureBox51.Visible = false;

            if (dias[5] == true)
                dias[5] = false;
            else
                dias[5] = true;
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            if (pictureBox52.Visible == false)
                pictureBox52.Visible = true;
            else
                pictureBox52.Visible = false;

            if (dias[6] == true)
                dias[6] = false;
            else
                dias[6] = true;
        }

        private void label64_Click(object sender, EventArgs e)
        {
            pictureBox38.Visible = false;
            if (pictureBox52.Visible == false)
                pictureBox52.Visible = true;
            else
                pictureBox52.Visible = false;

            if (dias[6] == true)
                dias[6] = false;
            else
                dias[6] = true;
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            if (pictureBox53.Visible == false)
                pictureBox53.Visible = true;
            else
                pictureBox53.Visible = false;

            if (dias[0] == true)
                dias[0] = false;
            else
                dias[0] = true;
        }

        private void label65_Click(object sender, EventArgs e)
        {
            if (pictureBox53.Visible == false)
                pictureBox53.Visible = true;
            else
                pictureBox53.Visible = false;

            if (dias[0] == true)
                dias[0] = false;
            else
                dias[0] = true;
        }

        private void panel23_Click(object sender, EventArgs e)
        {
            
        }

        private void panel23_Click_1(object sender, EventArgs e)
        {
            pictureBox39.Visible = true;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            //
            id_toque = 1;
            label59.Text = "Radar";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label77_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = true;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 1;
            
            label59.Text = "Radar";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel22_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = true;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 2;
            label59.Text = "Beacon";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label76_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = true;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 2;
            label59.Text = "Beacon";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel20_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = true;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 3;
            label59.Text = "Bulletin";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label74_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = true;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 3;
            label59.Text = "Bulletin";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = true;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 4;
            label59.Text = "By the sea";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label75_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = true;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 4;
            label59.Text = "By the sea";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel19_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = true;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 5;
            label59.Text = "Circuit";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label73_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = true;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 5;
            label59.Text = "Circuit";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = true;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 6;
            label59.Text = "Constellation";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label71_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = true;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 6;
            label59.Text = "Constellation";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = true;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 7;
            label59.Text = "Cosmic";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label70_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = true;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 7;
            label59.Text = "Cosmic";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void bunifuMaterialTextbox7_Resize(object sender, EventArgs e)
        {
            
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox14.Visible = false;
            bunifuMaterialTextbox18.Visible = false;
            bunifuMaterialTextbox19.Visible = false;
            bunifuMaterialTextbox20.Visible = false;
            bunifuMaterialTextbox21.Visible = false;
            bunifuMaterialTextbox22.Visible = false;
            bunifuMaterialTextbox23.Visible = false;

            int id_doenca = 0;
            DataTable dt1 = BLL.Doente.queryDoenca(metroComboBox3.Text);
            //dataGridView1.DataSource = dt1;
            if (dt1.Rows.Count > 0)
            {
                if (dt1.Rows.Count > 0)
                {
                    id_doenca = Convert.ToInt16(dt1.Rows[0][0]);
                }
            }

            
            DataTable dt = BLL.Doente.queryMedicamento(id_doenca);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string medicamento = dt.Rows[i][2].ToString();
            

                if (bunifuMaterialTextbox14.Visible == false)
                {
                    bunifuMaterialTextbox14.Visible = true;
                    bunifuMaterialTextbox14.Text = medicamento;
                    Size size14 = TextRenderer.MeasureText(bunifuMaterialTextbox14.Text, bunifuMaterialTextbox14.Font);
                    bunifuMaterialTextbox14.Width = size14.Width;
                    bunifuMaterialTextbox14.Height = size14.Height;
                }
                else if (bunifuMaterialTextbox18.Visible == false)
                {
                    bunifuMaterialTextbox18.Visible = true;
                    bunifuMaterialTextbox18.Text = medicamento;
                    Size size18 = TextRenderer.MeasureText(bunifuMaterialTextbox18.Text, bunifuMaterialTextbox18.Font);
                    bunifuMaterialTextbox18.Width = size18.Width;
                    bunifuMaterialTextbox18.Height = size18.Height;
                }
                else if (bunifuMaterialTextbox19.Visible == false)
                {
                    bunifuMaterialTextbox19.Visible = true;
                    bunifuMaterialTextbox19.Text = medicamento;
                    Size size19 = TextRenderer.MeasureText(bunifuMaterialTextbox19.Text, bunifuMaterialTextbox19.Font);
                    bunifuMaterialTextbox19.Width = size19.Width;
                    bunifuMaterialTextbox19.Height = size19.Height;
                }
                else if (bunifuMaterialTextbox20.Visible == false)
                {
                    bunifuMaterialTextbox20.Visible = true;
                    bunifuMaterialTextbox20.Text = medicamento;
                    Size size20 = TextRenderer.MeasureText(bunifuMaterialTextbox20.Text, bunifuMaterialTextbox20.Font);
                    bunifuMaterialTextbox20.Width = size20.Width;
                    bunifuMaterialTextbox20.Height = size20.Height;
                }
                else if (bunifuMaterialTextbox21.Visible == false)
                {
                    bunifuMaterialTextbox21.Visible = true;
                    bunifuMaterialTextbox21.Text = medicamento;
                    Size size21 = TextRenderer.MeasureText(bunifuMaterialTextbox21.Text, bunifuMaterialTextbox21.Font);
                    bunifuMaterialTextbox21.Width = size21.Width;
                    bunifuMaterialTextbox21.Height = size21.Height;
                }
                else if (bunifuMaterialTextbox22.Visible == false)
                {
                    bunifuMaterialTextbox22.Visible = true;
                    bunifuMaterialTextbox22.Text = medicamento;
                    Size size22 = TextRenderer.MeasureText(bunifuMaterialTextbox22.Text, bunifuMaterialTextbox22.Font);
                    bunifuMaterialTextbox22.Width = size22.Width;
                    bunifuMaterialTextbox22.Height = size22.Height;
                }
                else if (bunifuMaterialTextbox23.Visible == false)
                {
                    bunifuMaterialTextbox23.Visible = true;
                    bunifuMaterialTextbox23.Text = medicamento;
                    Size size23 = TextRenderer.MeasureText(bunifuMaterialTextbox23.Text, bunifuMaterialTextbox23.Font);
                    bunifuMaterialTextbox23.Width = size23.Width;
                    bunifuMaterialTextbox23.Height = size23.Height;
                }
            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox15_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox16_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuCustomLabel34_Click(object sender, EventArgs e)
        {
            string nome = "";
            if (textBox5.TextLength < 3)
            {
                label86.Visible = true;
            }
            else
            {
                label86.Visible = false;
                nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox5.Text.ToLower());
            }

            string t_pessoal = "";
            if (textBox9.TextLength < 9)
            {
                label87.Visible = true;
            }
            else
            {
                label87.Visible = false;
                t_pessoal = textBox9.Text;
            }

            string t_casa = "";
            if (textBox10.Text == "" || textBox10.Text == "Sem informação")
            {
                t_casa="";
                label88.Visible=false;
            }
            else if (textBox10.TextLength < 9)
            {
                label88.Visible = true;
                t_casa = "";
            }
            else
            {
                label88.Visible = false;
                t_casa = textBox10.Text;
            }

            string t_emp = "";
            if (textBox11.Text == "" || textBox11.Text == "Sem informação")
            {
                t_emp="";
                label89.Visible=false;
            }
            else if (textBox11.TextLength < 9)
            {
                label89.Visible = true;
                t_emp = "";
            }
            else
            {
                label89.Visible = false;
                t_emp = textBox11.Text;
            }

            string m = "";
            if (textBox6.TextLength < 7)
            {
                label90.Visible = true;
            }
            else
            {
                label90.Visible = false;
                m= CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox6.Text.ToLower());
            }

            string m_t = "";
            if (textBox7.Text == "" || textBox7.Text == "Sem informação")
            {
                m_t="";
                label91.Visible=false;
            }
            else if (textBox7.TextLength < 7)
            {
                label91.Visible = true;
                m_t="";
            }
            else
            {
                label91.Visible = false;
                m_t = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox7.Text.ToLower());
            }

            string g = "";
            if (textBox8.TextLength < 3)
            {
                label92.Visible = true;
            }
            else
            {
                label92.Visible = false;
                g = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox8.Text.ToLower());
            }

            if (maskedTextBox1.MaskFull)
            {
                label24.Visible = false;
            }
            else
            {
                label24.Visible = true;
            }

            if (textBox5.TextLength >= 3 && textBox9.TextLength >= 9 && textBox6.TextLength >= 7 && textBox5.TextLength >= 3 && textBox6.TextLength>=7 && textBox8.TextLength >= 3 && maskedTextBox1.MaskFull)
            {
                if (textBox10.TextLength < 9 && textBox10.TextLength != 0)
                    label88.Visible = true;
                else if (textBox11.TextLength < 9 && textBox11.TextLength != 0)
                    label89.Visible = true;
                else if (textBox7.TextLength < 7 && textBox11.TextLength != 0)
                    label91.Visible = true;
                else
                {

                    int x = BLL.Administrador.updateEditar(globais.userName, nome, t_pessoal, t_casa, t_emp, m, m_t, g, maskedTextBox1.Text);

                    //suas infg
                    materialTabControl1.SelectedTab = tabPage1;
                    bunifuImageButton5.Focus();

                    DataTable dt = BLL.Administrador.queryAdmin(globais.userName);

                    bunifuMaterialTextbox7.Text = dt.Rows[0][3].ToString();
                    Size size7 = TextRenderer.MeasureText(bunifuMaterialTextbox7.Text, bunifuMaterialTextbox7.Font);
                    bunifuMaterialTextbox7.Width = size7.Width;
                    bunifuMaterialTextbox7.Height = size7.Height;

                    bunifuMaterialTextbox6.Text = dt.Rows[0][4].ToString();
                    Size size6 = TextRenderer.MeasureText(bunifuMaterialTextbox6.Text, bunifuMaterialTextbox6.Font);
                    bunifuMaterialTextbox6.Width = size6.Width;
                    bunifuMaterialTextbox6.Height = size6.Height;
                    string t_casa1 = dt.Rows[0][5].ToString();
                    if (t_casa1 == "")
                    {
                        bunifuMaterialTextbox5.Text = "Sem informação";
                        bunifuMaterialTextbox5.Enabled = false;
                    }
                    else
                        bunifuMaterialTextbox5.Text = dt.Rows[0][5].ToString();

                    Size size5 = TextRenderer.MeasureText(bunifuMaterialTextbox5.Text, bunifuMaterialTextbox5.Font);
                    bunifuMaterialTextbox5.Width = size5.Width;
                    bunifuMaterialTextbox5.Height = size5.Height;

                    string t_emprego = dt.Rows[0][6].ToString();
                    if (t_emprego == "")
                    {
                        bunifuMaterialTextbox4.Text = "Sem informação";
                        bunifuMaterialTextbox4.Enabled = false;
                    }
                    else
                        bunifuMaterialTextbox4.Text = dt.Rows[0][6].ToString();

                    Size size4 = TextRenderer.MeasureText(bunifuMaterialTextbox4.Text, bunifuMaterialTextbox4.Font);
                    bunifuMaterialTextbox4.Width = size4.Width;
                    bunifuMaterialTextbox4.Height = size4.Height;

                    bunifuMaterialTextbox3.Text = dt.Rows[0][7].ToString();
                    Size size3 = TextRenderer.MeasureText(bunifuMaterialTextbox3.Text, bunifuMaterialTextbox3.Font);
                    bunifuMaterialTextbox3.Width = size3.Width;
                    bunifuMaterialTextbox3.Height = size3.Height;

                    string m_emprego = dt.Rows[0][8].ToString();
                    if (m_emprego == "")
                    {
                        bunifuMaterialTextbox2.Text = "Sem informação";
                        bunifuMaterialTextbox2.Enabled = false;
                    }
                    else
                        bunifuMaterialTextbox2.Text = dt.Rows[0][8].ToString();

                    Size size2 = TextRenderer.MeasureText(bunifuMaterialTextbox2.Text, bunifuMaterialTextbox2.Font);
                    bunifuMaterialTextbox2.Width = size2.Width;
                    bunifuMaterialTextbox2.Height = size2.Height;

                    bunifuMaterialTextbox1.Text = dt.Rows[0][9].ToString();
                    Size size = TextRenderer.MeasureText(bunifuMaterialTextbox1.Text, bunifuMaterialTextbox1.Font);
                    bunifuMaterialTextbox1.Width = size.Width;
                    bunifuMaterialTextbox1.Height = size.Height;




                    
                }

                

            }
        }

        private void tabPage23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel33_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage23;
            bunifuImageButton5.Focus();

            DataTable dt = BLL.Administrador.queryAdmin(globais.userName);
            textBox5.Text = dt.Rows[0][3].ToString();

            textBox9.Text = dt.Rows[0][4].ToString();

            string t_casa = dt.Rows[0][5].ToString();
            if (t_casa == "")
            {
                textBox10.Text = "Sem informação";
                //textBox10.Enabled = false;
            }
            else
                textBox10.Text = dt.Rows[0][5].ToString();

            string t_emprego = dt.Rows[0][6].ToString();
            if (t_emprego == "")
            {
                textBox11.Text = "Sem informação";
                //textBox11.Enabled = false;
            }
            else
                textBox11.Text = dt.Rows[0][6].ToString();

            textBox6.Text = dt.Rows[0][7].ToString();

            string m_emprego = dt.Rows[0][8].ToString();
            if (m_emprego == "")
            {
                textBox7.Text = "Sem informação";
                //textBox7.Enabled = false;
            }
            else
                textBox7.Text = dt.Rows[0][8].ToString();

            textBox8.Text = dt.Rows[0][9].ToString();

            maskedTextBox1.Text = dt.Rows[0][10].ToString();

            label86.Visible = false;
            label87.Visible = false;
            label88.Visible = false;
            label89.Visible = false;
            label90.Visible = false;
            label91.Visible = false;
            label92.Visible = false;
            label95.Visible = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.TextLength < 3)
            {
                label86.Visible = true;
            }
            else
            {
                label86.Visible = false;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.TextLength < 9)
            {
                label87.Visible = true;
            }
            else
            {
                label87.Visible = false;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                label88.Visible = false;
            }
            else if (textBox10.TextLength < 9)
            {
                label88.Visible = true;
            }
            else
            {
                label88.Visible = false;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                label89.Visible = false;
            }
            else if (textBox11.TextLength < 9)
            {
                label89.Visible = true;
            }
            else
            {
                label89.Visible = false;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.TextLength < 7)
            {
                label90.Visible = true;
            }
            else
            {
                label90.Visible = false;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                label91.Visible = false;
            }
            else if (textBox7.TextLength < 7)
            {
                label91.Visible = true;
            }
            else
            {
                label91.Visible = false;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.TextLength < 3)
            {
                label92.Visible = true;
            }
            else
            {
                label92.Visible = false;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {                
                label95.Visible = false;
            }
            else
            {
                label95.Visible = true;
            }
        }

        private void tabPage24_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage24;

            bunifuFlatButton2.Focus();

            metroComboBox1.Items.Clear();
            metroComboBox1.Text = "";

            DataTable dt = BLL.Doente.LoadDoente();
            textBox13.Text = dt.Rows[0][1].ToString();


            textBox14.Text = dt.Rows[0][2].ToString();


            metroComboBox6.Text = dt.Rows[0][3].ToString();

            metroComboBox2.Text = dt.Rows[0][5].ToString();


            textBox12.Text = dt.Rows[0][4].ToString();
            if (textBox12.Text == "")
                textBox12.Text = "Sem informação";

            //DataTable dt1 = BLL.Doente.queryDoenca_Like("");
            DataTable dt1 = BLL.Doente.LoadDoenca();

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                string doenca = dt1.Rows[i][1].ToString();
                metroComboBox1.Items.Add(doenca);
            } 

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int id_doenca = 0;
            DataTable dt1 = BLL.Doente.queryDoenca(metroComboBox1.Text);
            //dataGridView1.DataSource = dt1;
            if (dt1.Rows.Count > 0)
            {
                id_doenca = Convert.ToInt16(dt1.Rows[0][0]);
            }
            metroComboBox5.Items.Clear();

            DataTable dt = BLL.Doente.queryMedicamento(id_doenca);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt1.Rows.Count > 0)
                {
                    string medicamento = dt.Rows[i][2].ToString();
                    metroComboBox5.Items.Add(medicamento);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text == "")
            {

            }
            else
            {
                //MessageBox dr=

                if (MessageBox.Show("Tem a certeza que pretende eliminar esta doença? Caso elimine, todos as respectivas medicações serão também eliminadas.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DataTable dt = BLL.Doente.queryDoenca(metroComboBox1.Text);
                    int id_doenca =(int)dt.Rows[0][0];
                    int x = BLL.Doente.deleteMedicacao(id_doenca);
                    int y = BLL.Doente.deleteDoenca(id_doenca);

                    metroComboBox1.Items.Clear();
                    metroComboBox1.Text = "";
                    DataTable dt1 = BLL.Doente.LoadDoenca();

                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        string doenca = dt1.Rows[i][1].ToString();
                        metroComboBox1.Items.Add(doenca);
                    }


                    metroComboBox5.Items.Clear();
                    metroComboBox5.Text = "";
                }
                else
                {

                }
                 

                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (metroComboBox5.Text == "")
            {

            }
            else
            {
                if (MessageBox.Show("Tem a certeza que pretende eliminar este medicação? Caso elimine, será eliminado permanentemente.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DataTable dt = BLL.Doente.queryDoenca(metroComboBox1.Text);
                    int id_doenca = (int)dt.Rows[0][0];
                    int x = BLL.Doente.deleteMedicamento(id_doenca, metroComboBox5.Text);

                    metroComboBox1.Text = "";
                    metroComboBox5.Items.Clear();
                    metroComboBox5.Text = "";

                   

                    DataTable dt1 = BLL.Doente.queryMedicamento(id_doenca);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt1.Rows.Count > 0)
                        {
                            string medicamento = dt1.Rows[i][2].ToString();
                            metroComboBox5.Items.Add(medicamento);
                        }
                    }
                }
                else
                {

                }
            }
        }

        private void bunifuCustomLabel37_Click(object sender, EventArgs e)
        {
            string nome = "";
            if (textBox13.TextLength < 3)
                label104.Visible = true;
            else
            {
                label104.Visible = false;
                nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox13.Text.ToLower());
            }
                

            string morada = "";
            if (textBox14.TextLength < 7)
                label105.Visible = true;
            else
            {
                label105.Visible = false;
                morada = textBox14.Text;
            }



            string sintomas = "";
            if (textBox12.Text == "")
                sintomas = "";
            else if (textBox12.TextLength < 3)
                sintomas = "";
            else
                sintomas = textBox12.Text;

            if (textBox13.TextLength >= 3 && textBox14.TextLength >= 7)
            {




                int x = BLL.Doente.updateDoente(nome, morada, metroComboBox6.Text, sintomas, metroComboBox2.Text);


                materialTabControl1.SelectedTab = tabPage2;

                bunifuFlatButton2.Focus();

                DataTable dt = BLL.Doente.LoadDoente();
                bunifuMaterialTextbox10.Text = dt.Rows[0][1].ToString();
                Size size10 = TextRenderer.MeasureText(bunifuMaterialTextbox10.Text, bunifuMaterialTextbox10.Font);
                bunifuMaterialTextbox10.Width = size10.Width;
                bunifuMaterialTextbox10.Height = size10.Height;

                bunifuMaterialTextbox11.Text = dt.Rows[0][2].ToString();
                Size size11 = TextRenderer.MeasureText(bunifuMaterialTextbox11.Text, bunifuMaterialTextbox11.Font);
                bunifuMaterialTextbox11.Width = size11.Width;
                bunifuMaterialTextbox11.Height = size11.Height;

                bunifuMaterialTextbox8.Text = dt.Rows[0][3].ToString();
                Size size8 = TextRenderer.MeasureText(bunifuMaterialTextbox8.Text, bunifuMaterialTextbox8.Font);
                bunifuMaterialTextbox8.Width = size8.Width;
                bunifuMaterialTextbox8.Height = size8.Height;

                bunifuMaterialTextbox9.Text = dt.Rows[0][5].ToString();
                Size size9 = TextRenderer.MeasureText(bunifuMaterialTextbox9.Text, bunifuMaterialTextbox9.Font);
                bunifuMaterialTextbox9.Width = size9.Width;
                bunifuMaterialTextbox9.Height = size9.Height;

                textBox1.Text = dt.Rows[0][4].ToString();
                if (textBox1.Text == "")
                    textBox1.Text = "Sem informação";

                Size size1 = TextRenderer.MeasureText(textBox1.Text, textBox1.Font);
                textBox1.Width = size1.Width;
                textBox1.Height = size1.Height;

                metroComboBox3.Items.Clear();
                metroComboBox3.Text = "";
                DataTable dt1 = BLL.Doente.LoadDoenca();

                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    string doenca = dt1.Rows[i][1].ToString();
                    metroComboBox3.Items.Add(doenca);
                } 


            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox13.TextLength < 3)
                label104.Visible = true;
            else
            {
                label104.Visible = false;
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.TextLength < 7)
                label105.Visible = true;
            else
            {
                label105.Visible = false;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox12.Text == "")
                label106.Visible = false;
            else if (textBox12.TextLength < 7)
                label106.Visible = true;
            else
            {
                label106.Visible = false;

            }
                

        }

        private void bunifuCustomLabel38_Click(object sender, EventArgs e)
        {

            if (metroComboBox1.Text == "")
            {
                panel24.Visible = true;
                textBox15.Text = "";
                textBox16.Text = "";
                textBox15.Enabled = true;
                textBox16.Enabled = false;
                bunifuImageButton6.Enabled = true;
                bunifuImageButton7.Enabled = false;
            }
            else
            {
                panel24.Visible = true;
                textBox15.Text = metroComboBox1.Text;
                textBox15.Enabled = false;
                bunifuImageButton6.Enabled = false;
                textBox16.Enabled = true;
                textBox16.Text = "";
                bunifuImageButton7.Enabled = true;
            }
        }

        private void bunifuCustomLabel39_Click(object sender, EventArgs e)
        {
            panel24.Visible = false;
            label109.Visible = false;
            label110.Visible = false;
            textBox16.Enabled = false;
            textBox15.Enabled = true;
            bunifuImageButton7.Enabled = false;
            bunifuImageButton6.Enabled = true;
            panel24.Visible = false;

            metroComboBox1.Items.Clear();
            metroComboBox1.Text = "";
            DataTable dt2 = BLL.Doente.LoadDoenca();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                metroComboBox1.Items.Add(dt2.Rows[i][1].ToString());
            }
            metroComboBox5.Text = "";
            metroComboBox5.Items.Clear();
        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (textBox15.Text == "")
                label109.Visible = false;
            else if (textBox15.TextLength < 3 && textBox15.TextLength >= 1)
                label109.Visible = true;
            else
            {
                label109.Visible = false;
                DataTable dt = BLL.Doente.queryDoenca(textBox15.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Doença já registada!");
                }
                else
                {
                    string doenca = "";
                    doenca = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox15.Text.ToLower());
                    int x = BLL.Doente.insertDoencas_extras(doenca);
                    textBox15.Text = doenca;

                    if (MessageBox.Show("Doença registada com sucesso! Pretende adicionar medicação respectivamente hà doença que acabou de adicionar?registar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        textBox15.Enabled = false;
                        textBox16.Enabled = true;
                        bunifuImageButton6.Enabled = false;
                        bunifuImageButton7.Enabled = true;
                    }
                    else
                    {
                        label109.Visible = false;
                        label110.Visible = false;
                        textBox16.Enabled = false;
                        textBox15.Enabled = true;
                        bunifuImageButton7.Enabled = false;
                        bunifuImageButton6.Enabled = true;
                        panel24.Visible = false;

                        metroComboBox1.Items.Clear();
                        metroComboBox1.Text = "";
                        DataTable dt2 = BLL.Doente.LoadDoenca();
                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            metroComboBox1.Items.Add(dt2.Rows[i][1].ToString());
                        }
                        metroComboBox5.Text = "";
                            metroComboBox5.Items.Clear();
                    }
                }
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text == "")
            {
                label109.Visible = false;
                textBox16.Enabled = false;
                bunifuImageButton7.Enabled = false;
            }
            else if (textBox15.TextLength < 3 && textBox15.TextLength >= 1)
            {
                label109.Visible = true;
                textBox16.Enabled = false;
                bunifuImageButton7.Enabled = false;
            }
            else
            {
                label109.Visible = false;
                textBox16.Enabled = false;
                bunifuImageButton7.Enabled = false;
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text == "")
                label110.Visible = false;
            else if (textBox16.TextLength < 3 && textBox16.TextLength >= 1)
                label110.Visible = true;
            else
                label110.Visible = false;  
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            if (textBox16.Text == "")
                label110.Visible = false;
            else if (textBox16.TextLength < 3 && textBox15.TextLength >= 1)
                label110.Visible = true;
            else
            {
                label110.Visible = false;

                DataTable dt = BLL.Doente.queryDoenca(textBox15.Text);
                int id_doenca = 0;
                if (dt.Rows.Count>0) id_doenca = (int)dt.Rows[0][0];

                   string medicamento = "";
                    medicamento = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox16.Text.ToLower());

                    DataTable dt1 = BLL.Doente.queryMedicacao(id_doenca, medicamento);
                    if (dt1.Rows.Count > 0)
                    {
                        MessageBox.Show("Medicação já registada!");
                    }
                    else
                    {
                        int x = BLL.Doente.insertMedicacao(id_doenca, medicamento);
                        if (MessageBox.Show("Medicação registada com sucesso! Pretende adicionar mais alguma medicação respectivamente a esta doença?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            textBox16.Text = "";
                        }
                        else
                        {
                            label109.Visible = false;
                            label110.Visible = false;
                            textBox16.Enabled = false;
                            textBox15.Enabled = true;
                            bunifuImageButton7.Enabled = false;
                            bunifuImageButton6.Enabled = true;
                            panel24.Visible = false;

                            metroComboBox1.Items.Clear();
                            metroComboBox1.Text = "";
                            DataTable dt2 = BLL.Doente.LoadDoenca();
                            for (int i = 0; i < dt2.Rows.Count; i++)
                            {
                                metroComboBox1.Items.Add(dt2.Rows[i][1].ToString());
                            }
                            metroComboBox5.Text = "";
                            metroComboBox5.Items.Clear();
                        }
                    }
               
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b+0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b+0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b+0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void bunifuCustomLabel40_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage24;

            bunifuFlatButton2.Focus();

            metroComboBox1.Items.Clear();
            metroComboBox1.Text = "";

            DataTable dt = BLL.Doente.LoadDoente();
            textBox13.Text = dt.Rows[0][1].ToString();


            textBox14.Text = dt.Rows[0][2].ToString();


            metroComboBox6.Text = dt.Rows[0][3].ToString();

            metroComboBox2.Text = dt.Rows[0][5].ToString();


            textBox12.Text = dt.Rows[0][4].ToString();
            if (textBox12.Text == "")
                textBox12.Text = "Sem informação";

            //DataTable dt1 = BLL.Doente.queryDoenca_Like("");
            DataTable dt1 = BLL.Doente.LoadDoenca();

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                string doenca = dt1.Rows[i][1].ToString();
                metroComboBox1.Items.Add(doenca);
            } 
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.TextLength<3)
                label115.Visible = true;
            else
                label115.Visible = false;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.TextLength < 9)
                label116.Visible = true;
            else
                label116.Visible = false;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (textBox20.TextLength < 7)
                label118.Visible = true;
            else
                label118.Visible = false;
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (textBox21.TextLength < 9)
                label119.Visible = true;
            else
                label119.Visible = false;
        }

        private void bunifuCustomLabel41_Click(object sender, EventArgs e)
        {
            if (textBox17.TextLength >= 3 && textBox18.TextLength >= 9 && textBox19.TextLength >= 7 && textBox20.TextLength >= 7 && textBox21.TextLength >= 9)
            {
                string nome = "";
                nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox17.Text.ToLower());

                string m = "";
                m = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox19.Text.ToLower());

                string m_centro = "";
                m_centro = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox20.Text.ToLower());

                int x = BLL.Medicos.updateMedico_fam(nome, m, textBox18.Text, m_centro, textBox21.Text);

                //inf_med_fam
                materialTabControl1.SelectedTab = tabPage6;

                bunifuFlatButton4.Focus();

                DataTable dt = BLL.Medicos.LoadMed_fam();
                bunifuMaterialTextbox26.Text = dt.Rows[0][1].ToString();
                Size size = TextRenderer.MeasureText(bunifuMaterialTextbox26.Text, bunifuMaterialTextbox26.Font);
                bunifuMaterialTextbox26.Width = size.Width;
                bunifuMaterialTextbox26.Height = size.Height;

                bunifuMaterialTextbox27.Text = dt.Rows[0][3].ToString();
                Size size27 = TextRenderer.MeasureText(bunifuMaterialTextbox27.Text, bunifuMaterialTextbox27.Font);
                bunifuMaterialTextbox27.Width = size27.Width;
                bunifuMaterialTextbox27.Height = size27.Height;

                bunifuMaterialTextbox25.Text = dt.Rows[0][2].ToString();
                Size size25 = TextRenderer.MeasureText(bunifuMaterialTextbox25.Text, bunifuMaterialTextbox25.Font);
                bunifuMaterialTextbox25.Width = size25.Width;
                bunifuMaterialTextbox25.Height = size25.Height;

                bunifuMaterialTextbox24.Text = dt.Rows[0][4].ToString();
                Size size24 = TextRenderer.MeasureText(bunifuMaterialTextbox24.Text, bunifuMaterialTextbox24.Font);
                bunifuMaterialTextbox24.Width = size24.Width;
                bunifuMaterialTextbox24.Height = size24.Height;

                bunifuMaterialTextbox29.Text = dt.Rows[0][5].ToString();
                Size size29 = TextRenderer.MeasureText(bunifuMaterialTextbox29.Text, bunifuMaterialTextbox29.Font);
                bunifuMaterialTextbox29.Width = size29.Width;
                bunifuMaterialTextbox29.Height = size29.Height;
            }
        }

        private void textBox19_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox19.TextLength < 7)
                label117.Visible = true;
            else
                label117.Visible = false;
        }

        private void bunifuCustomLabel43_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage25;
            bunifuFlatButton4.Focus();

            DataTable dt = BLL.Medicos.LoadMed_fam();

            textBox17.Text = dt.Rows[0][1].ToString();
            textBox18.Text = dt.Rows[0][3].ToString();
            textBox19.Text = dt.Rows[0][2].ToString();
            textBox20.Text = dt.Rows[0][4].ToString();
            textBox21.Text = dt.Rows[0][5].ToString();
        }

        private void bunifuMaterialTextbox9_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox8_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox29_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox33_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void bunifuMaterialTextbox34_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tabPage26_Click(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (textBox26.TextLength < 3)
                label124.Visible = true;
            else
                label124.Visible = false;
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (textBox25.TextLength < 9)
                label123.Visible = true;
            else
                label123.Visible = false;
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (textBox22.TextLength < 7)
                label122.Visible = true;
            else
                label122.Visible = false;
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (textBox24.TextLength < 7)
                label121.Visible = true;
            else
                label121.Visible = false;
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (textBox23.TextLength < 9)
                label120.Visible = true;
            else
                label120.Visible = false;
        }

        private void bunifuCustomLabel45_Click(object sender, EventArgs e)
        {
            if (textBox17.TextLength >= 3 && textBox18.TextLength >= 9 && textBox19.TextLength >= 7 && textBox20.TextLength >= 7 && textBox21.TextLength >= 9)
            {
                string nome = "";
                nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox26.Text.ToLower());

                string m = "";
                m = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox22.Text.ToLower());

                string m_centro = "";
                m_centro = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox24.Text.ToLower());

                int x = BLL.Medicos.updateMedico_esp(nome, m, textBox25.Text, m_centro, textBox23.Text);

                //inf_med_esp
                materialTabControl1.SelectedTab = tabPage9;

                bunifuFlatButton4.Focus();


                DataTable dt = BLL.Medicos.LoadMed_esp();
                bunifuMaterialTextbox32.Text = dt.Rows[0][1].ToString();
                Size size32 = TextRenderer.MeasureText(bunifuMaterialTextbox32.Text, bunifuMaterialTextbox32.Font);
                bunifuMaterialTextbox32.Width = size32.Width;
                bunifuMaterialTextbox32.Height = size32.Height;

                bunifuMaterialTextbox33.Text = dt.Rows[0][3].ToString();
                Size size33 = TextRenderer.MeasureText(bunifuMaterialTextbox33.Text, bunifuMaterialTextbox33.Font);
                bunifuMaterialTextbox33.Width = size33.Width;
                bunifuMaterialTextbox33.Height = size33.Height;

                bunifuMaterialTextbox31.Text = dt.Rows[0][2].ToString();
                Size size31 = TextRenderer.MeasureText(bunifuMaterialTextbox31.Text, bunifuMaterialTextbox31.Font);
                bunifuMaterialTextbox31.Width = size31.Width;
                bunifuMaterialTextbox31.Height = size31.Height;

                bunifuMaterialTextbox28.Text = dt.Rows[0][4].ToString();
                Size size28 = TextRenderer.MeasureText(bunifuMaterialTextbox28.Text, bunifuMaterialTextbox28.Font);
                bunifuMaterialTextbox28.Width = size28.Width;
                bunifuMaterialTextbox28.Height = size28.Height;

                bunifuMaterialTextbox34.Text = dt.Rows[0][5].ToString();
                Size size34 = TextRenderer.MeasureText(bunifuMaterialTextbox34.Text, bunifuMaterialTextbox34.Font);
                bunifuMaterialTextbox34.Width = size34.Width;
                bunifuMaterialTextbox34.Height = size34.Height;
            }
        }

        private void bunifuCustomLabel46_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage26;

            bunifuFlatButton4.Focus();

            DataTable dt = BLL.Medicos.LoadMed_esp();

            textBox26.Text = dt.Rows[0][1].ToString();
            textBox25.Text = dt.Rows[0][3].ToString();
            textBox22.Text = dt.Rows[0][2].ToString();
            textBox26.Text = dt.Rows[0][1].ToString();
            textBox24.Text = dt.Rows[0][4].ToString();
            textBox23.Text = dt.Rows[0][5].ToString();
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage26;

            bunifuFlatButton4.Focus();

            DataTable dt = BLL.Medicos.LoadMed_esp();

            textBox26.Text = dt.Rows[0][1].ToString();
            textBox25.Text = dt.Rows[0][3].ToString();
            textBox22.Text = dt.Rows[0][2].ToString();
            textBox26.Text = dt.Rows[0][1].ToString();
            textBox24.Text = dt.Rows[0][4].ToString();
            textBox23.Text = dt.Rows[0][5].ToString();
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void pictureBox36_MouseDown(object sender, MouseEventArgs e)
        {
            //buttonC_Alarme = true;
            //if (buttonC_Alarme == true)
            //{
            label += 1;
            label133.Text = label.ToString();
            if (e.Button == MouseButtons.Left) { 
            
            
            
            }
            //    string st1 = Convert.ToString(materialTabControl3.SelectedTab);

            //    if (st1 == "TabPage: {Toque}")
            //    {
            //        if (location - 20 > 0)
            //        {
            //            location -= 20;
            //            tabPage18.VerticalScroll.Value = location;
            //        }
            //        else
            //        {
            //            // If scroll position is below 0 set the position to 0 (MIN)
            //            location = 0;
            //            tabPage18.AutoScrollPosition = new Point(0, location);
            //        }
            //    }
            //}
        }

        private void bunifuCustomLabel31_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel29_Click(object sender, EventArgs e)
        {
            if (label52.Text == "Repetir")
            {
                bunifuCustomLabel30.Text = "Cancelar";
                bunifuCustomLabel31.Visible = true;
                bunifuCustomLabel29.Visible = true;
                materialTabControl3.SelectedTab = tabPage19;
                string hora = textBox4.Text + ":" + textBox3.Text;

                //codigo para criar alarmes diarios e semanais

                if (dias[0] == true && dias[1] == true && dias[2] == true && dias[3] == true && dias[4] == true && dias[5] == true && dias[6]==true)
                {
                    //alarme diario
                    int x = BLL.Alarmes.insertAlarme(id_toque, label56.Text, 1, hora, true);
                    int id_alarme = Convert.ToInt32(BLL.Alarmes.queryUltimoId());
                    int y = BLL.Alarmes.insertAlarmeDiario(id_alarme);
                    materialTabControl1.SelectedTab = tabPage11;
                    materialTabControl2.SelectedTab = tabPage12;

                }
                    //semanais
                else if (dias[0] == true || dias[1] == true || dias[2] == true || dias[3] == true || dias[4] == true || dias[5] == true || dias[6]==true)
                {
                    //ao sab
                    if (dias[0] == true)
                    {
                        int x = BLL.Alarmes.insertAlarme(id_toque, label56.Text, 3, hora, true);
                        int id_alarme = Convert.ToInt32(BLL.Alarmes.queryUltimoId());
                        int y = BLL.Alarmes.insertAlarmeSemanais(id_alarme, "sáb");
                    }

                    //ao dom
                    if (dias[1] == true)
                    {
                        int x = BLL.Alarmes.insertAlarme(id_toque, label56.Text, 3, hora, true);
                        int id_alarme = Convert.ToInt32(BLL.Alarmes.queryUltimoId());
                        int y = BLL.Alarmes.insertAlarmeSemanais(id_alarme, "dom");
                    }

                    //a seg
                    if (dias[2] == true)
                    {
                        int x = BLL.Alarmes.insertAlarme(id_toque, label56.Text, 3, hora, true);
                        int id_alarme = Convert.ToInt32(BLL.Alarmes.queryUltimoId());
                        int y = BLL.Alarmes.insertAlarmeSemanais(id_alarme, "seg");
                    }

                    //a ter
                    if (dias[3] == true)
                    {
                        int x = BLL.Alarmes.insertAlarme(id_toque, label56.Text, 3, hora, true);
                        int id_alarme = Convert.ToInt32(BLL.Alarmes.queryUltimoId());
                        int y = BLL.Alarmes.insertAlarmeSemanais(id_alarme, "ter");
                    }

                    //a qua
                    if (dias[4] == true)
                    {
                        int x = BLL.Alarmes.insertAlarme(id_toque, label56.Text, 3, hora, true);
                        int id_alarme = Convert.ToInt32(BLL.Alarmes.queryUltimoId());
                        int y = BLL.Alarmes.insertAlarmeSemanais(id_alarme, "qua");
                    }

                    //a qui
                    if (dias[5] == true)
                    {
                        int x = BLL.Alarmes.insertAlarme(id_toque, label56.Text, 3, hora, true);
                        int id_alarme = Convert.ToInt32(BLL.Alarmes.queryUltimoId());
                        int y = BLL.Alarmes.insertAlarmeSemanais(id_alarme, "qui");
                    }

                    //a sex
                    if (dias[6] == true)
                    {
                        int x = BLL.Alarmes.insertAlarme(id_toque, label56.Text, 3, hora, true);
                        int id_alarme = Convert.ToInt32(BLL.Alarmes.queryUltimoId());
                        int y = BLL.Alarmes.insertAlarmeSemanais(id_alarme, "sex");
                    }

                    for (int i = 0; i < 6; i++)
                    {
                        dias[i] = false;
                    }

                    
                    materialTabControl1.SelectedTab = tabPage11;
                    materialTabControl2.SelectedTab = tabPage12;
                }
                else
                {
                    if (label53.Text == "Nunca")
                    {
                        MessageBox.Show("Necessita de escolher quando deseja repetir o alarme.");
                    }
                }
                
                
            }
            else if (label52.Text == "Data")
            {
                bunifuCustomLabel30.Text = "Cancelar";
                bunifuCustomLabel31.Visible = true;
                bunifuCustomLabel29.Visible = true;
                materialTabControl3.SelectedTab = tabPage19;
                
                string hora = textBox4.Text + ":" + textBox3.Text;
                //MessageBox.Show(""+DateTime.Today);
                DateTime data =Convert.ToDateTime(dateTimePicker1.Text);
                //codigo para criar alarmes pontuais
                    if (label53.Text == "Nunca")
                    {
                        MessageBox.Show("Necessita de escolher uma data para o alarme.");
                    }
                    else
                    {
                        int x = BLL.Alarmes.insertAlarme(id_toque, label56.Text, 2, hora, true);
                        int id_alarme = Convert.ToInt32(BLL.Alarmes.queryUltimoId());
                        int y = BLL.Alarmes.insertAlarmePontuais(id_alarme,data);
                    }

            }
            else if (label52.Text == "Repetir nos dias") {

                bunifuCustomLabel30.Text = "Cancelar";
                bunifuCustomLabel31.Visible = true;
                bunifuCustomLabel29.Visible = true;
                materialTabControl3.SelectedTab = tabPage19;
                string hora = textBox4.Text + ":" + textBox3.Text;

                //codigo para criar alarmes mensais

                for (int i = 0; i < 32; i++)
                {
                    if (diasM[i + 1]==true)
                    {
                        int x = BLL.Alarmes.insertAlarme(id_toque, label56.Text, 4, hora, true);
                        int id_alarme = Convert.ToInt32(BLL.Alarmes.queryUltimoId());
                        int y = BLL.Alarmes.insertAlarmeMensais(id_alarme,i+1);
                    }
                }
                
            
            
            }


            materialTabControl1.SelectedTab = tabPage11;
            materialTabControl2.SelectedTab = tabPage13;
            }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }
        

        private void pictureBox38_Click(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
            //    e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = "\b0123456789".IndexOf(e.KeyChar) < 0;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void label40_Click(object sender, EventArgs e)
        {
            if (alarmR == false)
            {
                alarmR = true;
                comboBox2.Visible = true;
                bunifuImageButton9.Visible = true;
                comboBox2.Items.Clear();
                for (int i = 0; i < 31; i++)
                {
                    if (diasM[i + 1] == true)
                    {
                        comboBox2.Items.Add(i + 1);
                    }
                }
            }
            else
            {
                alarmR = false;
                comboBox2.Visible = false;
                bunifuImageButton9.Visible = false;
            }
            
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back);
        }

        private void tabPage21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {

            }
            else
            {
                int y = Convert.ToInt32(comboBox1.Text);
                diasM[y] = true;
                comboBox1.Items.Remove(y);
                comboBox2.Items.Clear();
                for (int i = 0; i < 31; i++)
                {
                    if (diasM[i + 1] == true)
                    {
                        int x = i + 1;
                        comboBox2.Items.Add(x);
                    }
                    
                }

                label37.Text = "Nunca";
                for (int i = 0; i < 31; i++)
                {
                    if (diasM[i + 1] == true)
                    {
                        if (label37.Text == "Nunca")
                        {
                            int x = i + 1;
                            label37.Text=x.ToString();
                        }
                        else
                        {
                            int x = i + 1;
                            label37.Text +=", " + x;
                        }
                    }
                }
            }
            
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {

            }
            else
            {
                int y = Convert.ToInt32(comboBox2.Text);
                diasM[y] = false;
                comboBox2.Items.Remove(y);
                comboBox1.Items.Clear();

                for (int i = 0; i < 31; i++)
                {
                    if (diasM[i + 1] == false)
                    {
                        int x = i + 1;
                        comboBox1.Items.Add(x);
                    }
                }


                label37.Text = "Nunca";
                for (int i = 0; i < 31; i++)
                {
                    if (diasM[i + 1] == true)
                    {
                        if (label37.Text == "Nunca")
                        {
                            int x = i + 1;
                            label37.Text = "" + x;
                        }
                        else
                        {
                            int x = i + 1;
                            label37.Text += ", " + x;
                        }
                    }
                }
                if (comboBox2.Items.Count == 0)
                {
                    comboBox2.Text = "";
                    alarmR = false;
                    comboBox2.Visible = false;
                    bunifuImageButton9.Visible = false;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel47_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage27;
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        private void bunifuCustomLabel49_Click(object sender, EventArgs e)
        {

            //Image imagem;

            //byte[] imgArray;
            //openFileDialog1.ShowDialog();
            //string file = openFileDialog1.FileName.ToString();

            //imagem = Image.FromFile(file, true);
            //pictureBox8.Image = imagem;
            //imgArray = imageToByteArray(imagem);
            //int x = BLL.Galeria.insertImovelFoto(imgArray, textBox28.Text, textBox29.Text);
            //DataTable dt = BLL.Galeria.queryImovelFoto1(globais.qpb);
            //globais.qpb = globais.qpb + 1;

            //if (globais.coluna == 1)
            //{
            //    PictureBox picture = new PictureBox
            //    {
            //        Name = "pictureBox" + globais.pb,
            //        Size = new Size(93, 96),
            //        Location = new Point(28, (globais.cn1 + 135)),

            //        Image = byteArrayToImage((Byte[])dt.Rows[globais.ola][1]),

            //        SizeMode = PictureBoxSizeMode.StretchImage,

            //    };
            //    picture.Click += this.PictureClick;
            //    Label label = new Label
            //    {
            //        Name = "label" + globais.lbl,
            //        AutoSize = false,
            //        Size = new Size(93, 26),
            //        Location = new Point(28, (globais.lab1 + 135)),
            //        TextAlign = ContentAlignment.MiddleCenter,
            //        Text = ((Convert.ToString(dt.Rows[globais.ola][2])) + "\n" + (Convert.ToString(dt.Rows[globais.ola][3]))),
            //    };
            //    globais.lbl = globais.lbl + 1;
            //    panel4.Controls.Add(label);
            //    label.BringToFront();
            //    globais.ola = globais.ola + 1;

            //    panel4.Controls.Add(picture);

            //    picture.BringToFront();

            //    globais.pb = globais.pb + 1;
            //    globais.coluna = 2;
            //    globais.cn1 = globais.cn1 + 135;
            //    globais.lab1 = globais.lab1 + 135;
            //}
            //else if (globais.coluna == 2)
            //{
            //    PictureBox picture = new PictureBox
            //    {
            //        Name = "pictureBox" + globais.pb,
            //        Size = new Size(93, 96),
            //        Location = new Point(188, (globais.cn2 + 135)),
            //        Image = byteArrayToImage((Byte[])dt.Rows[globais.ola][1]),

            //        SizeMode = PictureBoxSizeMode.StretchImage,

            //    };
            //    Label label = new Label
            //    {
            //        Name = "label" + globais.lbl,
            //        AutoSize = false,
            //        Size = new Size(93, 26),
            //        Location = new Point(188, (globais.lab2 + 135)),
            //        TextAlign = ContentAlignment.MiddleCenter,
            //        Text = ((Convert.ToString(dt.Rows[globais.ola][2])) + "\n" + (Convert.ToString(dt.Rows[globais.ola][3]))),
            //    };
            //    globais.lbl = globais.lbl + 1;
            //    panel4.Controls.Add(label);
            //    label.BringToFront();
            //    globais.ola = globais.ola + 1;
            //    panel4.Controls.Add(picture);
            //    picture.BringToFront();

            //    globais.pb = globais.pb + 1;
            //    globais.coluna = 3;
            //    globais.cn2 = globais.cn2 + 135;
            //    globais.lab2 = globais.lab2 + 135;
            //}
            //else if (globais.coluna == 3)
            //{
            //    PictureBox picture = new PictureBox
            //    {
            //        Name = "pictureBox" + globais.pb,
            //        Size = new Size(93, 96),
            //        Location = new Point(343, (globais.cn3 + 135)),

            //        Image = byteArrayToImage((Byte[])dt.Rows[globais.ola][1]),

            //        SizeMode = PictureBoxSizeMode.StretchImage,
            //    };
            //    Label label = new Label
            //    {
            //        Name = "label" + globais.lbl,
            //        AutoSize = false,
            //        Size = new Size(93, 26),
            //        Location = new Point(343, (globais.lab3 + 135)),
            //        TextAlign = ContentAlignment.MiddleCenter,
            //        Text = ((Convert.ToString(dt.Rows[globais.ola][2])) + "\n" + (Convert.ToString(dt.Rows[globais.ola][3]))),
            //    };
            //    globais.lbl = globais.lbl + 1;
            //    panel4.Controls.Add(label);
            //    label.BringToFront();
            //    globais.ola = globais.ola + 1;
            //    panel4.Controls.Add(picture);
            //    picture.BringToFront();
            //    globais.lab3 = globais.lab3 + 135;
            //    globais.pb = globais.pb + 1;
            //    globais.coluna = 1;
            //    globais.cn3 = globais.cn3 + 135;
            //}

            //foreach (Control pb in panel4.Controls)
            //{
            //    if (pb is PictureBox && pb.Name != "pictureBox1" && pb.Name != "pictureBox2" && pb.Name != "pictureBox3")
            //    {

            //        if (dt.Rows.Count != 0)
            //            pb.BackgroundImage = byteArrayToImage((Byte[])dt.Rows[0][1]);



            //    }

            //}

        }

        private void tabPage27_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_2(object sender, EventArgs e)
        {

        }

        private void label120_Click(object sender, EventArgs e)
        {

        }

        private void label121_Click(object sender, EventArgs e)
        {

        }

        private void label122_Click(object sender, EventArgs e)
        {

        }

        private void label123_Click(object sender, EventArgs e)
        {

        }

        private void label124_Click(object sender, EventArgs e)
        {

        }

        private void label125_Click(object sender, EventArgs e)
        {

        }

        private void label126_Click(object sender, EventArgs e)
        {

        }

        private void label127_Click(object sender, EventArgs e)
        {

        }

        private void label128_Click(object sender, EventArgs e)
        {

        }

        private void label129_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            if (toqueA == true)
            {
                Toque.Stop();
                toqueA = false;
            }

            materialTabControl1.SelectedTab = tabPage28;

        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {

        }

        private void tabPage18_Click(object sender, EventArgs e)
        {

        }

        private void panel33_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = true;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 8;
            label59.Text = "Crystals";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label132_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = true;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 8;
            label59.Text = "Crystals";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel32_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = true;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 9;
            label59.Text = "Hill side";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label131_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = true;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 9;
            label59.Text = "Hill side";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel30_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 10;
            label59.Text = "Illuminate";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label48_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 10;
            label59.Text = "Illuminate";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel31_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = true;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 11;
            label59.Text = "Night owl";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label72_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = true;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 11;
            label59.Text = "Night owl";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel29_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = true;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 12;
            label59.Text = "Opening";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label47_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = true;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 12;
            label59.Text = "Opening";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel28_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = true;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 13;
            label59.Text = "Playtime";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label46_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = true;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 13;
            label59.Text = "Playtime";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel27_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = true;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 14;
            label59.Text = "Presto";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label45_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = true;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 14;
            label59.Text = "Presto";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel47_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = true;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 15;
            label59.Text = "Radiate";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label146_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = true;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 15;
            label59.Text = "Radiate";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel46_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = true;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 16;
            label59.Text = "Ripples";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label145_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = true;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 16;
            label59.Text = "Ripples";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel44_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = true;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 17;
            label59.Text = "Sencha";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label143_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = true;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 17;
            label59.Text = "Sencha";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel45_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = true;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 18;
            label59.Text = "Signal";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label144_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = true;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 18;
            label59.Text = "Signal";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel43_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = true;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 19;
            label59.Text = "Silk";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label142_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = true;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 19;
            label59.Text = "Silk";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel42_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = true;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 20;
            label59.Text = "Slow rise";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label141_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = true;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 20;
            label59.Text = "Slow rise";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel41_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = true;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 21;
            label59.Text = "Summit";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label140_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = true;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 21;
            label59.Text = "Summit";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel40_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = true;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 22;
            label59.Text = "Twinkle";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label139_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = true;
            pictureBox55.Visible = false;
            pictureBox17.Visible = false;
            id_toque = 22;
            label59.Text = "Twinkle";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel39_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = true;
            pictureBox17.Visible = false;
            id_toque = 23;
            label59.Text = "Uplift";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label138_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = true;
            pictureBox17.Visible = false;
            id_toque = 23;
            label59.Text = "Uplift";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void panel37_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = true;
            id_toque = 24;
            label59.Text = "Waves";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void label136_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox64.Visible = false;
            pictureBox63.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox58.Visible = false;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            pictureBox17.Visible = true;
            id_toque = 24;
            label59.Text = "Waves";
            DataTable dt = BLL.Toques.queryToque(id_toque);
            string som = "" + dt.Rows[0][1];
            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
            Toque.Play();
            toqueA = true;
        }

        private void pictureBox36_MouseUp(object sender, MouseEventArgs e)
        {
            buttonC_Alarme = false;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            while (e.Button == MouseButtons.Left) {
                button3.PerformClick();
                //System.Threading.Thread.Sleep(500);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string st1 = Convert.ToString(materialTabControl3.SelectedTab);

            if (st1 == "TabPage: {Toque}")
            {
                if (location - 20 > 0)
                {
                    location -= 20;
                    tabPage18.VerticalScroll.Value = location;
                }
                else
                {
                    // If scroll position is below 0 set the position to 0 (MIN)
                    location = 0;
                    tabPage18.AutoScrollPosition = new Point(0, location);
                }

             }
        }

        private void bunifuMaterialTextbox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void bunifuCustomLabel53_Click(object sender, EventArgs e)
        {
            if (bunifuCustomLabel53.Text == "Remover")
            {
                bunifuCustomLabel53.Text = "Cancelar";
                jogoG = false;
                bunifuCustomLabel52.Visible = false;
                panel35.Visible = false;
                bunifuCustomLabel54.Visible = false;
                bunifuCustomLabel55.Visible = true;

            }
            else if (bunifuCustomLabel53.Text == "Cancelar")
            {
                bunifuCustomLabel53.Text = "Remover";
            }
        }

        private void bunifuCustomLabel55_Click(object sender, EventArgs e)
        {
            if (jogoG == false)
            {
                jogoG = true;
                bunifuCustomLabel52.Visible = true;
                panel35.Visible = true;
                bunifuCustomLabel55.Visible = false;
                bunifuCustomLabel54.Visible = true;
            }
            else
            {
                jogoG = false;
                bunifuCustomLabel52.Visible = false;
                panel35.Visible = false;
                bunifuCustomLabel54.Visible = false;
                bunifuCustomLabel55.Visible = true;
            }
        }

        private void bunifuCustomLabel54_Click(object sender, EventArgs e)
        {
            if (jogoG == false)
            {
                jogoG = true;
                bunifuCustomLabel52.Visible = true;
                panel35.Visible = true;
                bunifuCustomLabel55.Visible = false;
                bunifuCustomLabel54.Visible = true;
            }
            else
            {
                jogoG = false;
                bunifuCustomLabel52.Visible = false;
                panel35.Visible = false;
                bunifuCustomLabel54.Visible = false;
                bunifuCustomLabel55.Visible = true;
            }
        }

   
    }
}
