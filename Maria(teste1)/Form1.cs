using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using BusinessLogicLayer;
using System.Windows.Input;
using System.IO;


namespace Maria_teste1_
{
    public partial class Form1 : Form
    {
        //int va = 0;
        int va1 = 0;
        int lemT = 0;
        int GalCf = 0;
        int GalCi = 0;
        int GalDefaultF = 0;
        int GalDefaultI = 1;
        System.Media.SoundPlayer Toque;
        bool toqueA = false;
        Image imagem2;
        byte[] imgArray;
        bool GaleriaFam = false;

        public Form1()
        {
            InitializeComponent();
        }

       private void button1_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
            f2.Show();
            globais.sec = 0;
            globais.ver = true;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bunifuCustomLabel12.Visible = false;
            bunifuCustomLabel11.Visible = false;
            timer1.Start();
            //timer5.Start();
            bunifuFlatButton15.Visible = false;
            bunifuFlatButton15.Enabled = false;

            DataTable dt1 = BLL.Galeria.Load();
                GalCf = dt1.Rows.Count;
                if (GalCf != 0)
                {
                    GaleriaFam = true;
                    if (GaleriaFam == true)
                    {

                        DataTable dt = BLL.Galeria.Load();
                        GalCf = dt.Rows.Count;
                        if (GalCf != 0)
                        {
                            if (GalCf == GalCi)
                            {
                                GalCi = 0;
                                DataTable dtG = BLL.Galeria.Load();

                                if (dtG.Rows.Count != 0)
                                {
                                    pictureBox4.Image = byteArrayToImage((Byte[])dtG.Rows[GalCi][1]);
                                    label4.Text = dtG.Rows[GalCi][2] + " - " + dtG.Rows[GalCi][3];
                                    label4.Visible = true;
                                    GalCi += 1;
                                    pictureBox12.BringToFront();
                                    pictureBox17.BringToFront();
                                }
                            }
                            else
                            {

                                DataTable dtG = BLL.Galeria.Load();

                                if (dtG.Rows.Count != 0)
                                {
                                    pictureBox4.Image = byteArrayToImage((Byte[])dtG.Rows[GalCi][1]);
                                    label4.Text = dtG.Rows[GalCi][2] + " - " + dtG.Rows[GalCi][3];
                                    label4.Visible = true;
                                    GalCi += 1;
                                    pictureBox12.BringToFront();
                                    pictureBox17.BringToFront();
                                }

                            }

                        }
                        else
                        { }
                        label4.Visible = true;
                    }
                    else
                    {


                    }
                    label10.Text = GalCi.ToString();
                    label11.Text = GalCf.ToString();

                    timer5.Stop();
                    timer5.Start();
                }
                else
                {
                    GaleriaFam = false;
                    if (GaleriaFam == true)
                    {


                    }
                    else
                    {
                        DataTable dt2 = BLL.Galeria.LoadGaleriaDefault();
                        GalDefaultF = dt2.Rows.Count;
                        if (GalDefaultI == GalDefaultF)
                        {
                            GalDefaultI = 0;
                            string imagem = dt2.Rows[GalDefaultI][1].ToString();
                            pictureBox4.ImageLocation = System.Windows.Forms.Application.StartupPath + @imagem;
                            label4.Visible = false;
                            GalDefaultI += 1;
                            pictureBox15.BringToFront();
                            pictureBox16.BringToFront();
                        }
                        else
                        {
                            string imagem = dt2.Rows[GalDefaultI][1].ToString();
                            pictureBox4.ImageLocation = System.Windows.Forms.Application.StartupPath + @imagem;
                            label4.Visible = false;
                            GalDefaultI += 1;
                            pictureBox15.BringToFront();
                            pictureBox16.BringToFront();
                        }

                    }
                    label10.Text = GalCi.ToString();
                    label11.Text = GalCf.ToString(); 

                    timer5.Stop();
                    timer5.Start();
                    label4.Visible = false;
                }


            //-----------------/\----------------\\

                //string file = "C:/Users/fernandesdf/Desktop/Maria/Maria(teste1)/bin/Debug/Selena/tumblr_oyvh6cuzEV1vrpaero3_1280.jpg";
                //imagem2 = Image.FromFile(file, true);
                ////pictureBox4.Image = imagem;
                //imgArray = imageToByteArray(imagem2);
                //int x = BLL.Galeria.insertGaleria(imgArray, "Selena Marie Gomez4", "Sua Mulher4");

            //-----------------/\----------------\\

            //pictureBox4.ImageLocation = System.Windows.Forms.Application.StartupPath + @"\Images\26153345_1572083909549733_8731668113336041472_n-640x640.jpg";

            //-----------------/\----------------\\

            //var filename = @"C:\Users\fernandesdf\Desktop\Maria\Maria(teste1)\bin\Debug\Selena\tumblr_p1myt7n1Jq1wms9iao4_400.png";
            //var img = Image.FromFile(filename);
            //var rect = new Rectangle(new Point(0, 0), img.Size);
            //var cloned = new Bitmap(img).Clone(rect, img.PixelFormat);
            //var bitmap = new Bitmap(cloned, new Size(50, 50));
            //Graphics g = Graphics.FromImage(bitmap);
            //g.DrawImage(bitmap, 50, 50);
            //cloned.Dispose();
            //g.Dispose();

            //-----------------/\----------------\\

            //Rectangle cropRect = new Rectangle(50, 50, 150, 150);
            //Bitmap src = Image.FromFile("C:/Users/fernandesdf/Desktop/Maria/Maria(teste1)/bin/Debug/Selena/tumblr_p1myt7n1Jq1wms9iao4_400.png") as Bitmap;
            //Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

            //using(Graphics g = Graphics.FromImage(target))
            //{
            //        g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height), 
            //        cropRect,                        
            //        GraphicsUnit.Pixel);            
            //}

            //-----------------/\----------------\\

            
            DoubleBuffered = true;



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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string mes = DateTime.Now.ToString("MMMMMM");
            mes = char.ToUpper(mes[0]) + mes.Substring(1);
            label1.Text = DateTime.Now.ToString("HH:mm");
            string dia = DateTime.Now.ToString("dddd");
            dia = char.ToUpper(dia[0]) + dia.Substring(1);
            label2.Text = dia + DateTime.Now.ToString(", dd") + " de " + mes + " de " + DateTime.Now.ToString("yyyy");


            bunifuCustomLabel3.Text = "";
            bunifuCustomLabel4.Text = "Sem eventos";
            bunifuCustomLabel2.Text = "";
            bunifuCustomLabel1.Text = "Sem eventos";
            bunifuCustomLabel6.Text = "";
            bunifuCustomLabel5.Text = "Sem eventos";
            bunifuCustomLabel8.Text = "";
            bunifuCustomLabel7.Text = "Sem eventos";


            //Para visualizar o horario
            string horaN = DateTime.Now.ToString("HH:mm");

            DataTable dtL = BLL.Alarmes.LoadOrdenadoHora(horaN);

            if (dtL.Rows.Count != 0)
            {
                for (int i = 0; i < dtL.Rows.Count; i++)
                {
                    if (va1 <= 4)
                    {

                        if (va1 == 0)
                        {
                            if (Convert.ToInt32(dtL.Rows[i][3]) == 1)
                            {
                                va1 += 1;
                                string hora = dtL.Rows[i][4].ToString();
                                string descricao = dtL.Rows[i][2].ToString();

                                bunifuCustomLabel3.Text = hora;
                                bunifuCustomLabel4.Text = descricao;

                            }
                            else if (Convert.ToInt32(dtL.Rows[i][3]) == 2)
                            {
                                int id_alarme = Convert.ToInt32(dtL.Rows[i][0]);
                                DataTable dtL2 = BLL.Alarmes.queryAlarmePontuais(id_alarme);
                                if (dtL2.Rows.Count != 0)
                                {
                                    string data = dtL2.Rows[0][1].ToString();
                                    DateTime today = DateTime.Today;
                                    string today1 = today.ToString();
                                    if (data.Equals(today1))
                                    {
                                        va1 += 1;
                                        string hora = dtL.Rows[i][4].ToString();
                                        string descricao = dtL.Rows[i][2].ToString();

                                        bunifuCustomLabel3.Text = hora;
                                        bunifuCustomLabel4.Text = descricao;

                                    }
                                }



                            }
                            else if (Convert.ToInt32(dtL.Rows[i][3]) == 3)
                            {
                                int id_alarme1 = Convert.ToInt32(dtL.Rows[i][0]);
                                DataTable dtL3 = BLL.Alarmes.queryAlarmeSemanais(id_alarme1);
                                if (dtL3.Rows.Count != 0)
                                {
                                    string diaS = dtL3.Rows[0][1].ToString();
                                    DateTime dateV = DateTime.Now;
                                    //MessageBox.Show(dateV.ToString("ddd"));
                                    if (diaS.Equals(dateV.ToString("ddd")))
                                    {
                                        va1 += 1;
                                        string hora = dtL.Rows[i][4].ToString();
                                        string descricao = dtL.Rows[i][2].ToString();

                                        bunifuCustomLabel3.Text = hora;
                                        bunifuCustomLabel4.Text = descricao;

                                    }
                                }
                            }
                            else if (Convert.ToInt32(dtL.Rows[i][3]) == 4)
                            {
                                int id_alarme2 = Convert.ToInt32(dtL.Rows[i][0]);
                                DataTable dtL4 = BLL.Alarmes.queryAlarmeMensais(id_alarme2);
                                if (dtL4.Rows.Count != 0)
                                {
                                    string diaM = dtL4.Rows[0][1].ToString();
                                    //string diaM1= diaM +
                                    DateTime dateV = DateTime.Now;
                                    //MessageBox.Show(dateV.ToString("dd"));
                                    if (diaM.Equals(dateV.ToString("dd")))
                                    {
                                        va1 += 1;
                                        string hora = dtL.Rows[i][4].ToString();
                                        string descricao = dtL.Rows[i][2].ToString();

                                        bunifuCustomLabel3.Text = hora;
                                        bunifuCustomLabel4.Text = descricao;

                                    }
                                }
                            }



                        }
                        else if (va1 == 1)
                        {
                            if (Convert.ToInt32(dtL.Rows[i][3]) == 1)
                            {
                                va1 += 1;
                                string hora = dtL.Rows[i][4].ToString();
                                string descricao = dtL.Rows[i][2].ToString();

                                bunifuCustomLabel2.Text = hora;
                                bunifuCustomLabel1.Text = descricao;

                            }
                            else if (Convert.ToInt32(dtL.Rows[i][3]) == 2)
                            {
                                int id_alarme = Convert.ToInt32(dtL.Rows[i][0]);
                                DataTable dtL2 = BLL.Alarmes.queryAlarmePontuais(id_alarme);
                                if (dtL2.Rows.Count != 0)
                                {
                                    string data = dtL2.Rows[0][1].ToString();
                                    DateTime today = DateTime.Today;
                                    string today1 = today.ToString();
                                    if (data.Equals(today1))
                                    {
                                        va1 += 1;
                                        string hora = dtL.Rows[i][4].ToString();
                                        string descricao = dtL.Rows[i][2].ToString();

                                        bunifuCustomLabel2.Text = hora;
                                        bunifuCustomLabel1.Text = descricao;

                                    }
                                }



                            }
                            else if (Convert.ToInt32(dtL.Rows[i][3]) == 3)
                            {
                                int id_alarme1 = Convert.ToInt32(dtL.Rows[i][0]);
                                DataTable dtL3 = BLL.Alarmes.queryAlarmeSemanais(id_alarme1);
                                if (dtL3.Rows.Count != 0)
                                {
                                    string diaS = dtL3.Rows[0][1].ToString();
                                    DateTime dateV = DateTime.Now;
                                    //MessageBox.Show(dateV.ToString("ddd"));
                                    if (diaS.Equals(dateV.ToString("ddd")))
                                    {
                                        va1 += 1;
                                        string hora = dtL.Rows[i][4].ToString();
                                        string descricao = dtL.Rows[i][2].ToString();

                                        bunifuCustomLabel2.Text = hora;
                                        bunifuCustomLabel1.Text = descricao;

                                    }
                                }
                            }
                            else if (Convert.ToInt32(dtL.Rows[i][3]) == 4)
                            {
                                int id_alarme2 = Convert.ToInt32(dtL.Rows[i][0]);
                                DataTable dtL4 = BLL.Alarmes.queryAlarmeMensais(id_alarme2);
                                if (dtL4.Rows.Count != 0)
                                {
                                    string diaM = dtL4.Rows[0][1].ToString();
                                    //string diaM1= diaM +
                                    DateTime dateV = DateTime.Now;
                                    //MessageBox.Show(dateV.ToString("dd"));
                                    if (diaM.Equals(dateV.ToString("dd")))
                                    {
                                        va1 += 1;
                                        string hora = dtL.Rows[i][4].ToString();
                                        string descricao = dtL.Rows[i][2].ToString();

                                        bunifuCustomLabel2.Text = hora;
                                        bunifuCustomLabel1.Text = descricao;

                                    }
                                }
                            }


                        }
                        else if (va1 == 2)
                        {
                            if (Convert.ToInt32(dtL.Rows[i][3]) == 1)
                            {
                                va1 += 1;
                                string hora = dtL.Rows[i][4].ToString();
                                string descricao = dtL.Rows[i][2].ToString();

                                bunifuCustomLabel6.Text = hora;
                                bunifuCustomLabel5.Text = descricao;

                            }
                            else if (Convert.ToInt32(dtL.Rows[i][3]) == 2)
                            {
                                int id_alarme = Convert.ToInt32(dtL.Rows[i][0]);
                                DataTable dtL2 = BLL.Alarmes.queryAlarmePontuais(id_alarme);
                                if (dtL2.Rows.Count != 0)
                                {
                                    string data = dtL2.Rows[0][1].ToString();
                                    DateTime today = DateTime.Today;
                                    string today1 = today.ToString();
                                    if (data.Equals(today1))
                                    {
                                        va1 += 1;
                                        string hora = dtL.Rows[i][4].ToString();
                                        string descricao = dtL.Rows[i][2].ToString();

                                        bunifuCustomLabel6.Text = hora;
                                        bunifuCustomLabel5.Text = descricao;

                                    }
                                }



                            }
                            else if (Convert.ToInt32(dtL.Rows[i][3]) == 3)
                            {
                                int id_alarme1 = Convert.ToInt32(dtL.Rows[i][0]);
                                DataTable dtL3 = BLL.Alarmes.queryAlarmeSemanais(id_alarme1);
                                if (dtL3.Rows.Count != 0)
                                {
                                    string diaS = dtL3.Rows[0][1].ToString();
                                    DateTime dateV = DateTime.Now;
                                    //MessageBox.Show(dateV.ToString("ddd"));
                                    if (diaS.Equals(dateV.ToString("ddd")))
                                    {
                                        va1 += 1;
                                        string hora = dtL.Rows[i][4].ToString();
                                        string descricao = dtL.Rows[i][2].ToString();

                                        bunifuCustomLabel6.Text = hora;
                                        bunifuCustomLabel5.Text = descricao;

                                    }
                                }
                            }
                            else if (Convert.ToInt32(dtL.Rows[i][3]) == 4)
                            {
                                int id_alarme2 = Convert.ToInt32(dtL.Rows[i][0]);
                                DataTable dtL4 = BLL.Alarmes.queryAlarmeMensais(id_alarme2);
                                if (dtL4.Rows.Count != 0)
                                {
                                    string diaM = dtL4.Rows[0][1].ToString();
                                    //string diaM1= diaM +
                                    DateTime dateV = DateTime.Now;
                                    //MessageBox.Show(dateV.ToString("dd"));
                                    if (diaM.Equals(dateV.ToString("dd")))
                                    {
                                        va1 += 1;
                                        string hora = dtL.Rows[i][4].ToString();
                                        string descricao = dtL.Rows[i][2].ToString();

                                        bunifuCustomLabel6.Text = hora;
                                        bunifuCustomLabel5.Text = descricao;

                                    }
                                }
                            }


                        }
                        else if (va1 == 3)
                        {
                            if (Convert.ToInt32(dtL.Rows[i][3]) == 1)
                            {
                                va1 += 1;
                                string hora = dtL.Rows[i][4].ToString();
                                string descricao = dtL.Rows[i][2].ToString();

                                bunifuCustomLabel8.Text = hora;
                                bunifuCustomLabel7.Text = descricao;

                            }
                            else if (Convert.ToInt32(dtL.Rows[i][3]) == 2)
                            {
                                int id_alarme = Convert.ToInt32(dtL.Rows[i][0]);
                                DataTable dtL2 = BLL.Alarmes.queryAlarmePontuais(id_alarme);
                                if (dtL2.Rows.Count != 0)
                                {
                                    string data = dtL2.Rows[0][1].ToString();
                                    DateTime today = DateTime.Today;
                                    string today1 = today.ToString();
                                    if (data.Equals(today1))
                                    {
                                        va1 += 1;
                                        string hora = dtL.Rows[i][4].ToString();
                                        string descricao = dtL.Rows[i][2].ToString();

                                        bunifuCustomLabel8.Text = hora;
                                        bunifuCustomLabel7.Text = descricao;

                                    }
                                }



                            }
                            else if (Convert.ToInt32(dtL.Rows[i][3]) == 3)
                            {
                                int id_alarme1 = Convert.ToInt32(dtL.Rows[i][0]);
                                DataTable dtL3 = BLL.Alarmes.queryAlarmeSemanais(id_alarme1);
                                if (dtL3.Rows.Count != 0)
                                {
                                    string diaS = dtL3.Rows[0][1].ToString();
                                    DateTime dateV = DateTime.Now;
                                    //MessageBox.Show(dateV.ToString("ddd"));
                                    if (diaS.Equals(dateV.ToString("ddd")))
                                    {
                                        va1 += 1;
                                        string hora = dtL.Rows[i][4].ToString();
                                        string descricao = dtL.Rows[i][2].ToString();

                                        bunifuCustomLabel8.Text = hora;
                                        bunifuCustomLabel7.Text = descricao;

                                    }
                                }
                            }
                            else if (Convert.ToInt32(dtL.Rows[i][3]) == 4)
                            {
                                int id_alarme2 = Convert.ToInt32(dtL.Rows[i][0]);
                                DataTable dtL4 = BLL.Alarmes.queryAlarmeMensais(id_alarme2);
                                if (dtL4.Rows.Count != 0)
                                {
                                    string diaM = dtL4.Rows[0][1].ToString();
                                    //string diaM1= diaM +
                                    DateTime dateV = DateTime.Now;
                                    //MessageBox.Show(dateV.ToString("dd"));
                                    if (diaM.Equals(dateV.ToString("dd")))
                                    {
                                        va1 += 1;
                                        string hora = dtL.Rows[i][4].ToString();
                                        string descricao = dtL.Rows[i][2].ToString();

                                        bunifuCustomLabel8.Text = hora;
                                        bunifuCustomLabel7.Text = descricao;

                                    }
                                }
                            }


                        }
                        
                    }
                }
            }



            va1 = 0;
            if (lemT == 0)
            {
                
                //lembrete

                DataTable dtLHoraAtual = BLL.Alarmes.LoadHoraAtual(horaN);

                if (dtLHoraAtual.Rows.Count != 0)
                {
                    for (int i = 0; i < dtLHoraAtual.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dtLHoraAtual.Rows[i][3]) == 1)
                        {
                            string hora = dtLHoraAtual.Rows[i][4].ToString();
                            string descricao = dtLHoraAtual.Rows[i][2].ToString();

                            bunifuCustomLabel12.Text = hora;
                            bunifuCustomLabel11.Text = descricao;


                            //animacao e toque
                            pictureBox5.Visible = true;
                            pictureBox6.Visible = true;
                            bunifuCustomLabel12.Visible=true;
                            bunifuCustomLabel11.Visible = true;
                            DataTable dt = BLL.Toques.queryToque(Convert.ToInt32(dtLHoraAtual.Rows[i][1]));
                            string som = "" + dt.Rows[0][1];
                            Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
                            Toque.Play();
                            toqueA = true;
                            timer3.Start();
                            timer4.Start();
                        }
                        else if (Convert.ToInt32(dtLHoraAtual.Rows[i][3]) == 2)
                        {
                            int id_alarme = Convert.ToInt32(dtLHoraAtual.Rows[i][0]);
                            DataTable dtL2 = BLL.Alarmes.queryAlarmePontuais(id_alarme);
                            if (dtL2.Rows.Count != 0)
                            {
                                string data = dtL2.Rows[0][1].ToString();
                                DateTime today = DateTime.Today;
                                string today1 = today.ToString();
                                if (data.Equals(today1))
                                {
                                    string hora = dtLHoraAtual.Rows[i][4].ToString();
                                    string descricao = dtLHoraAtual.Rows[i][2].ToString();

                                    bunifuCustomLabel12.Text = "hora";
                                    bunifuCustomLabel11.Text = "descricao";
                                    MessageBox.Show("awd");
                                    //animacao e toque
                                    pictureBox5.Visible = true;
                                    pictureBox6.Visible = true;
                                    bunifuCustomLabel12.Visible = true;
                                    bunifuCustomLabel11.Visible = true;
                                    DataTable dt = BLL.Toques.queryToque(Convert.ToInt32(dtLHoraAtual.Rows[i][1]));
                                    string som = "" + dt.Rows[0][1];
                                    Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
                                    Toque.Play();
                                    toqueA = true;
                                    timer3.Start();
                                    timer4.Start();
                                    
                                }
                            }



                        }
                        else if (Convert.ToInt32(dtLHoraAtual.Rows[i][3]) == 3)
                        {
                            int id_alarme1 = Convert.ToInt32(dtLHoraAtual.Rows[i][0]);
                            DataTable dtL3 = BLL.Alarmes.queryAlarmeSemanais(id_alarme1);
                            if (dtL3.Rows.Count != 0)
                            {
                                string diaS = dtL3.Rows[0][1].ToString();
                                DateTime dateV = DateTime.Now;
                                if (diaS.Equals(dateV.ToString("ddd")))
                                {
                                    string hora = dtLHoraAtual.Rows[i][4].ToString();
                                    string descricao = dtLHoraAtual.Rows[i][2].ToString();

                                    bunifuCustomLabel12.Text = "hora";
                                    bunifuCustomLabel11.Text = descricao;
                                   // MessageBox.Show("diaS");

                                    //animacao e toque
                                    pictureBox5.Visible = true;
                                    pictureBox6.Visible = true;
                                    bunifuCustomLabel12.Visible = true;
                                    bunifuCustomLabel11.Visible = true;
                                    DataTable dt = BLL.Toques.queryToque(Convert.ToInt32(dtLHoraAtual.Rows[i][1]));
                                    string som = "" + dt.Rows[0][1];
                                    Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
                                    Toque.Play();
                                    toqueA = true;
                                    timer3.Start();
                                    timer4.Start();
                                    label5.Text = bunifuCustomLabel12.Visible.ToString();
                                }
                            }
                        }
                        else if (Convert.ToInt32(dtLHoraAtual.Rows[i][3]) == 4)
                        {
                            int id_alarme2 = Convert.ToInt32(dtLHoraAtual.Rows[i][0]);
                            DataTable dtL4 = BLL.Alarmes.queryAlarmeMensais(id_alarme2);
                            if (dtL4.Rows.Count != 0)
                            {
                                string diaM = dtL4.Rows[0][1].ToString();
                                DateTime dateV = DateTime.Now;
                                if (diaM.Equals(dateV.ToString("dd")))
                                {
                                    string hora = dtLHoraAtual.Rows[i][4].ToString();
                                    string descricao = dtLHoraAtual.Rows[i][2].ToString();

                                    bunifuCustomLabel12.Text = hora;
                                    bunifuCustomLabel11.Text = descricao;

                                    //animacao e toque
                                    pictureBox5.Visible = true;
                                    pictureBox6.Visible = true;
                                    bunifuCustomLabel12.Visible = true;
                                    bunifuCustomLabel11.Visible = true;
                                    DataTable dt = BLL.Toques.queryToque(Convert.ToInt32(dtLHoraAtual.Rows[i][1]));
                                    string som = "" + dt.Rows[0][1];
                                    Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
                                    Toque.Play();
                                    toqueA = true;
                                    timer3.Start();
                                    timer4.Start();
                                }
                            }
                        }



                    }

                }
            }

            label7.Text = globais.time2.ToString();
            label8.Text = lemT.ToString();
            label9.Text = toqueA.ToString();
            
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath =
        new System.Drawing.Drawing2D.GraphicsPath();

            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            System.Drawing.Rectangle newRectangle = button2.ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-10, -10);

            // Draw the button's border.
            e.Graphics.DrawEllipse(System.Drawing.Pens.LightSalmon, newRectangle);

            // Increase the size of the rectangle to include the border.
            newRectangle.Inflate(1, 1);

            // Create a circle within the new rectangle.
            buttonPath.AddEllipse(newRectangle);

            // Set the button's Region property to the newly created 
            // circle region.
            button2.Region = new System.Drawing.Region(buttonPath);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (globais.btn == false)
            {
               
                int xis1 = 0;
                int yps1 = 0;
                int ret1 = 0;
                xis1 = pictureBox11.Location.X;
                yps1 = pictureBox11.Location.Y;
                ret1 = (845 - xis1) / 2;
                xis1 = xis1 + ret1;
                ret1 = (895 - yps1) / 2;
                // yps1 = yps1 + ret1;
                Point ponto1 = new Point(xis1, yps1);
                pictureBox11.Location = ponto1;

                int xis2 = 0;
                int yps2 = 0;
                int ret2 = 0;
                xis2 = pictureBox8.Location.X;
                yps2 = pictureBox8.Location.Y;
                ret2 = (750 - xis2) / 2;
                xis2 = xis2 + ret2;
                ret2 = (785 - yps2) / 2;
                yps2 = yps2 + ret2;
                Point ponto2 = new Point(xis2, yps2);
                pictureBox8.Location = ponto2;

                int xis3 = 0;
                int yps3 = 0;
                int ret3 = 0;
                xis3 = pictureBox9.Location.X;
                yps3 = pictureBox9.Location.Y;
                ret3 = (610 - xis3) / 2;
                //xis3 = xis3 + ret3;
                ret3 = (740 - yps3) / 2;
                yps3 = yps3 + ret3;
                Point ponto3 = new Point(xis3, yps3);
                pictureBox9.Location = ponto3;

                int xis4 = 0;
                int yps4 = 0;
                int ret4 = 0;
                xis4 = pictureBox10.Location.X;
                yps4 = pictureBox10.Location.Y;
                ret4 = (470 - xis4) / 2;
                xis4 = xis4 + ret4;
                ret4 = (785 - yps4) / 2;
                yps4 = yps4 + ret4;
                Point ponto4 = new Point(xis4, yps4);
                pictureBox10.Location = ponto4;

                int xis5 = 0;
                int yps5 = 0;
                int ret5 = 0;
                xis5 = pictureBox7.Location.X;
                yps5 = pictureBox7.Location.Y;
                ret5 = (375 - xis5) / 2;
                xis5 = xis5 + ret5;
                ret5 = (895 - yps5) / 2;
                yps5 = yps5 + ret5;
                Point ponto5 = new Point(xis5, yps5);
                pictureBox7.Location = ponto5;
            }
            else if (globais.btn == true)
            {
                int xis6 = 0;
                int yps6 = 0;
                int ret6 = 0;
                xis6 = pictureBox11.Location.X;
                yps6 = pictureBox11.Location.Y;
                ret6 = (610 - xis6) / 2;
                xis6 = xis6 + ret6;
                ret6 = (895 - yps6) / 2;
                // yps1 = yps1 + ret1;
                Point ponto6 = new Point(xis6, yps6);
                pictureBox11.Location = ponto6;

                int xis7 = 0;
                int yps7 = 0;
                int ret7 = 0;
                xis7 = pictureBox8.Location.X;
                yps7 = pictureBox8.Location.Y;
                ret7 = (610 - xis7) / 2;
                xis7 = xis7 + ret7;
                ret7 = (895 - yps7) / 2;
                yps7 = yps7 + ret7;
                Point ponto7 = new Point(xis7, yps7);
                pictureBox8.Location = ponto7;

                int xis8 = 0;
                int yps8 = 0;
                int ret8 = 0;
                xis8 = pictureBox9.Location.X;
                yps8 = pictureBox9.Location.Y;
                ret8 = (610 - xis8) / 2;
                // xis8 = xis8 + ret8;
                ret8 = (895 - yps8) / 2;
                yps8 = yps8 + ret8;
                Point ponto8 = new Point(xis8, yps8);
                pictureBox9.Location = ponto8;

                int xis9 = 0;
                int yps9 = 0;
                int ret9 = 0;
                xis9 = pictureBox10.Location.X;
                yps9 = pictureBox10.Location.Y;
                ret9 = (610 - xis9) / 2;
                xis9 = xis9 + ret9;
                ret9 = (895 - yps9) / 2;
                yps9 = yps9 + ret9;
                Point ponto9 = new Point(xis9, yps9);
                pictureBox10.Location = ponto9;

                int xis10 = 0;
                int yps10 = 0;
                int ret10 = 0;
                xis10 = pictureBox7.Location.X;
                yps10 = pictureBox7.Location.Y;
                ret10 = (610 - xis10) / 2;
                xis10 = xis10 + ret10;
                ret10 = (895 - yps10) / 2;
                yps10 = yps10 + ret10;
                Point ponto10 = new Point(xis10, yps10);
                pictureBox7.Location = ponto10;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            if (globais.btn == false)
            {
                globais.btn = true;
            }
            else if (globais.btn == true)
            {
                globais.btn = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            timer2.Start();
            if (globais.btn == false)
            {
                globais.btn = true;
            }
            else if (globais.btn == true)
            {
                globais.btn = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {           
            if (globais.time2 == true)
            {
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                bunifuCustomLabel12.Visible = true;
                bunifuCustomLabel11.Visible = true;
                bunifuFlatButton15.Visible = false;
                bunifuFlatButton15.Enabled = false;
                int xis11 = 0;
                int yps11 = 0;
                int ret11 = 0;
                xis11 = pictureBox5.Location.X;
                yps11 = pictureBox5.Location.Y;
                ret11 = (350 - xis11) / 2;

                xis11 = xis11 + ret11;
                ret11 = (260 - yps11) / 2;
                yps11 = yps11 + ret11;
                Point ponto11 = new Point(xis11, yps11);
                Point ponto14 = new Point(xis11 - 7, yps11 - 7);
                Point ponto15 = new Point(xis11 + 7, yps11 + 7);
                Point ponto16 = new Point(xis11 + 7, ((yps11 + 7)+bunifuCustomLabel12.Size.Height));
                //74
                //125
                pictureBox5.Location = ponto11;
                pictureBox6.Location = ponto14;
                bunifuCustomLabel12.Location = ponto15;
                bunifuCustomLabel12.Font = new Font("Century Gothic", globais.siz, FontStyle.Regular);
                bunifuCustomLabel11.Location = ponto16;
                bunifuCustomLabel11.Font = new Font("Century Gothic", globais.siz2, FontStyle.Regular);
                
                globais.siz2 = globais.siz2 + 2;
                if (globais.siz2 >= 34 )
                {
                    globais.siz2 = 34;
                }
                globais.siz = globais.siz + 4;
                if (globais.siz >= 50)
                {
                    globais.siz = 50;
                    
                }
                //Century Gothic; 18pt
                    label3.Text = globais.sx.ToString();
                    label6.Text = globais.sy.ToString();
                if (globais.sx < 650)
                {
                    globais.sx = globais.sx + 40;
                    globais.lbsx = globais.lbsx + 40;
                    
                }
                if (globais.sy < 325)
                {
                    globais.sy = globais.sy + 20;
                    globais.lbsy = globais.lbsy + 15;
                }


                if (globais.sx < 650 || globais.sy < 325)
                {
                    this.bunifuCustomLabel11.Size = new System.Drawing.Size(globais.lbsx, globais.lbsy);
                    // Set the size of the PictureBox control.
                    this.pictureBox5.Size = new System.Drawing.Size(globais.sx, globais.sy);
                    this.pictureBox6.Size = new System.Drawing.Size(globais.sx + 15, globais.sy + 15);
                    //Set the SizeMode to center the image.
                    this.pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
                    this.pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
                    // Set the border style to a three-dimensional border.
                    this.pictureBox5.BorderStyle = BorderStyle.Fixed3D;

                    // Set the image property.
                    //this.pictureBox5.Image = imagem1;
                    //this.pictureBox6.Image = imagem2;
                    // Set the SizeMode property to the StretchImage value.  This
                    // will enlarge the image as needed to fit into
                    // the PictureBox.
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    timer3.Stop();
                    globais.time2 = false;
                  
                    bunifuFlatButton15.Visible = true;
                    bunifuFlatButton15.Enabled = true;
                }
            }
            else if (globais.time2 == false)
            {
                bunifuFlatButton15.Visible = false;
                bunifuFlatButton15.Enabled = false;
                int xis12 = 0;
                int yps12 = 0;
                int ret12 = 0;
                xis12 = pictureBox5.Location.X;
                yps12 = pictureBox5.Location.Y;
                ret12 = (441 - xis12) / 2;

                xis12 = xis12 + ret12;
                ret12 = (210 - yps12) / 2;
                yps12 = yps12 + ret12;
                Point ponto12 = new Point(xis12, yps12);
                Point ponto13 = new Point(xis12 - 7, yps12 - 7);
                Point ponto17 = new Point(xis12 + 7, yps12 + 7);
                Point ponto18 = new Point(xis12 + 7, yps12 + 74);
                pictureBox5.Location = ponto12;
                pictureBox6.Location = ponto13;
                bunifuCustomLabel12.Location = ponto17;
                bunifuCustomLabel12.Font = new Font("Century Gothic", globais.siz, FontStyle.Regular);
                bunifuCustomLabel11.Location = ponto18;
                bunifuCustomLabel11.Font = new Font("Century Gothic", globais.siz2, FontStyle.Regular);
                globais.siz2 = globais.siz2 - 2;
                if (globais.siz2 <= 18)
                {
                    globais.siz2 = 18;
                }
                globais.siz = globais.siz - 2;
                if (globais.siz <= 36)
                {
                    globais.siz = 36;
                }
                if (globais.sx > 300)
                {
                    globais.sx = globais.sx - 40;
                    globais.lbsx = globais.lbsx - 40;
                }
                if (globais.sy > 150)
                {
                    globais.sy = globais.sy - 20;
                    globais.lbsy = globais.lbsy - 15;
                }

                label3.Text = globais.sx.ToString();
                label6.Text = globais.sy.ToString();
                if (globais.sx > 300 || globais.sy > 150)
                {
                    this.bunifuCustomLabel11.Size = new System.Drawing.Size(globais.lbsx, globais.lbsy);
                    // Set the size of the PictureBox control.
                    this.pictureBox5.Size = new System.Drawing.Size(globais.sx, globais.sy);
                    this.pictureBox6.Size = new System.Drawing.Size(globais.sx + 15, globais.sy + 15);
                    //Set the SizeMode to center the image.
                    this.pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
                    this.pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
                    // Set the border style to a three-dimensional border.
                    this.pictureBox5.BorderStyle = BorderStyle.Fixed3D;
                    this.pictureBox6.BorderStyle = BorderStyle.Fixed3D;
                    // Set the image property.
                    //this.pictureBox5.Image = imagem1;
                    //this.pictureBox6.Image = imagem2;
                    // Set the SizeMode property to the StretchImage value.  This
                    // will enlarge the image as needed to fit into
                    // the PictureBox.
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    timer3.Stop();
                    globais.time2 = true;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    bunifuCustomLabel12.Visible = false;
                    bunifuCustomLabel11.Visible = false;
                }
            }
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
            f2.Focus();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Login f2 = new Login();
            f2.Focus();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
            f2.Show();
            globais.sec = 0;
            globais.ver = true;
        }

        private void pictureBox8_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath pictureboxPath =
       new System.Drawing.Drawing2D.GraphicsPath();

            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            System.Drawing.Rectangle newRectangle = pictureBox8.ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-10, -10);

            // Draw the button's border.
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);

            // Increase the size of the rectangle to include the border.
            newRectangle.Inflate(1, 1);

            // Create a circle within the new rectangle.
            pictureboxPath.AddEllipse(newRectangle);

            // Set the button's Region property to the newly created 
            // circle region.
            pictureBox8.Region = new System.Drawing.Region(pictureboxPath);
        }

        private void pictureBox11_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath pictureboxPath =
       new System.Drawing.Drawing2D.GraphicsPath();

            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            System.Drawing.Rectangle newRectangle = pictureBox11.ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-10, -10);

            // Draw the button's border.
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);

            // Increase the size of the rectangle to include the border.
            newRectangle.Inflate(1, 1);

            // Create a circle within the new rectangle.
            pictureboxPath.AddEllipse(newRectangle);

            // Set the button's Region property to the newly created 
            // circle region.
            pictureBox11.Region = new System.Drawing.Region(pictureboxPath);
        }

        private void pictureBox9_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath pictureboxPath =
       new System.Drawing.Drawing2D.GraphicsPath();

            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            System.Drawing.Rectangle newRectangle = pictureBox9.ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-10, -10);

            // Draw the button's border.
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);

            // Increase the size of the rectangle to include the border.
            newRectangle.Inflate(1, 1);

            // Create a circle within the new rectangle.
            pictureboxPath.AddEllipse(newRectangle);

            // Set the button's Region property to the newly created 
            // circle region.
            pictureBox9.Region = new System.Drawing.Region(pictureboxPath);
        }

        private void pictureBox10_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath pictureboxPath =
       new System.Drawing.Drawing2D.GraphicsPath();

            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            System.Drawing.Rectangle newRectangle = pictureBox10.ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-10, -10);

            // Draw the button's border.
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);

            // Increase the size of the rectangle to include the border.
            newRectangle.Inflate(1, 1);

            // Create a circle within the new rectangle.
            pictureboxPath.AddEllipse(newRectangle);

            // Set the button's Region property to the newly created 
            // circle region.
            pictureBox10.Region = new System.Drawing.Region(pictureboxPath);
        }

        private void pictureBox7_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath pictureboxPath =
       new System.Drawing.Drawing2D.GraphicsPath();

            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            System.Drawing.Rectangle newRectangle = pictureBox7.ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-10, -10);

            // Draw the button's border.
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);
           
            // Increase the size of the rectangle to include the border.
            newRectangle.Inflate(1, 1);

            // Create a circle within the new rectangle.
            pictureboxPath.AddEllipse(newRectangle);

            // Set the button's Region property to the newly created 
            // circle region.
            pictureBox7.Region = new System.Drawing.Region(pictureboxPath);



           
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            timer3.Start();
            if (toqueA == true)
            {
                Toque.Stop();
                toqueA = false;
            }
            //globais.time2 = true;
            //timer4.Stop();
            
            //lemT = 0;

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            lemT += 1;
            if (lemT == 30 && toqueA==true)
            {
                timer3.Start();

                //DataTable dt = BLL.Toques.queryToque(id_toque);
                //string som = "" + dt.Rows[0][1];
                //Toque = new System.Media.SoundPlayer(System.Windows.Forms.Application.StartupPath + @som);
                //Toque.Play();


                //toqueA = true;
                //lemT = 0;
                //timer4.Stop();
            }
            else if (lemT == 60)
            {
                lemT = 0;
                if (toqueA == true)
                {
                    Toque.Stop();
                    toqueA = false;
                }
                timer4.Stop();
                
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (GaleriaFam == true)
            {

                DataTable dt = BLL.Galeria.Load();
                GalCf = dt.Rows.Count;
                if (GalCf != 0)
                {
                    if (GalCf == GalCi)
                    {
                        GalCi = 0;
                        DataTable dtG = BLL.Galeria.Load();

                        if (dtG.Rows.Count != 0)
                        {
                            pictureBox4.Image = byteArrayToImage((Byte[])dtG.Rows[GalCi][1]);
                            label4.Text = dtG.Rows[GalCi][2] + " - " + dtG.Rows[GalCi][3];
                            label4.Visible = true;
                            GalCi += 1;
                        }
                    }
                    else
                    {

                        DataTable dtG = BLL.Galeria.Load();

                        if (dtG.Rows.Count != 0)
                        {
                            pictureBox4.Image = byteArrayToImage((Byte[])dtG.Rows[GalCi][1]);
                            label4.Text = dtG.Rows[GalCi][2] + " - " + dtG.Rows[GalCi][3];
                            label4.Visible = true;
                            GalCi += 1;
                        }

                    }

                }
                else
                { }
            }
            else
            {
                DataTable dt2 = BLL.Galeria.LoadGaleriaDefault();
                GalDefaultF = dt2.Rows.Count;
                if (GalDefaultI == GalDefaultF)
                {
                    GalDefaultI = 0;
                    string imagem = dt2.Rows[GalDefaultI][1].ToString();
                    pictureBox4.ImageLocation = System.Windows.Forms.Application.StartupPath + @imagem;
                    label4.Visible = false;
                    GalDefaultI += 1;
                }
                else
                {
                    string imagem = dt2.Rows[GalDefaultI][1].ToString();
                    pictureBox4.ImageLocation = System.Windows.Forms.Application.StartupPath + @imagem;
                    label4.Visible = false;
                    GalDefaultI += 1;
                }

            }
                label10.Text = GalCi.ToString();
                label11.Text = GalCf.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer2.Start();
            if (globais.btn == false)
            {
                globais.btn = true;
            }
            else if (globais.btn == true)
            {
                globais.btn = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            GaleriaFam = false;
            if (GaleriaFam == true)
            {

                
            }
            else
            {
                DataTable dt2 = BLL.Galeria.LoadGaleriaDefault();
                GalDefaultF = dt2.Rows.Count;
                if (GalDefaultI == GalDefaultF)
                {
                    GalDefaultI = 0;
                    string imagem = dt2.Rows[GalDefaultI][1].ToString();
                    pictureBox4.ImageLocation = System.Windows.Forms.Application.StartupPath + @imagem;
                    label4.Visible = false;
                    GalDefaultI += 1;
                    pictureBox15.BringToFront();
                    pictureBox16.BringToFront();
                }
                else
                {
                    string imagem = dt2.Rows[GalDefaultI][1].ToString();
                    pictureBox4.ImageLocation = System.Windows.Forms.Application.StartupPath + @imagem;
                    label4.Visible = false;
                    GalDefaultI += 1;
                    pictureBox15.BringToFront();
                    pictureBox16.BringToFront();
                }

            }
            label10.Text = GalCi.ToString();
            label11.Text = GalCf.ToString();
            
            timer5.Stop();
            timer5.Start();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            GaleriaFam = true;
            if (GaleriaFam == true)
            {

                DataTable dt = BLL.Galeria.Load();
                GalCf = dt.Rows.Count;
                if (GalCf != 0)
                {
                    if (GalCf == GalCi)
                    {
                        GalCi = 0;
                        DataTable dtG = BLL.Galeria.Load();

                        if (dtG.Rows.Count != 0)
                        {
                            pictureBox4.Image = byteArrayToImage((Byte[])dtG.Rows[GalCi][1]);
                            label4.Text = dtG.Rows[GalCi][2] + " - " + dtG.Rows[GalCi][3];
                            label4.Visible = true;
                            GalCi += 1;
                            pictureBox12.BringToFront();
                            pictureBox17.BringToFront();
                        }
                    }
                    else
                    {

                        DataTable dtG = BLL.Galeria.Load();

                        if (dtG.Rows.Count != 0)
                        {
                            pictureBox4.Image = byteArrayToImage((Byte[])dtG.Rows[GalCi][1]);
                            label4.Text = dtG.Rows[GalCi][2] + " - " + dtG.Rows[GalCi][3];
                            label4.Visible = true;
                            GalCi += 1;
                            pictureBox12.BringToFront();
                            pictureBox17.BringToFront();
                        }

                    }

                }
                else
                { }
            }
            else
            {
                

            }
            label10.Text = GalCi.ToString();
            label11.Text = GalCf.ToString();

            timer5.Stop();
            timer5.Start();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            GaleriaFam = false;
            if (GaleriaFam == true)
            {


            }
            else
            {
                DataTable dt2 = BLL.Galeria.LoadGaleriaDefault();
                GalDefaultF = dt2.Rows.Count;
                if (GalDefaultI == GalDefaultF)
                {
                    GalDefaultI = 0;
                    string imagem = dt2.Rows[GalDefaultI][1].ToString();
                    pictureBox4.ImageLocation = System.Windows.Forms.Application.StartupPath + @imagem;
                    label4.Visible = false;
                    GalDefaultI += 1;
                    pictureBox15.BringToFront();
                    pictureBox16.BringToFront();
                }
                else
                {
                    string imagem = dt2.Rows[GalDefaultI][1].ToString();
                    pictureBox4.ImageLocation = System.Windows.Forms.Application.StartupPath + @imagem;
                    label4.Visible = false;
                    GalDefaultI += 1;
                    pictureBox15.BringToFront();
                    pictureBox16.BringToFront();
                }

            }
            label10.Text = GalCi.ToString();
            label11.Text = GalCf.ToString();

            timer5.Stop();
            timer5.Start();
        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {
            GaleriaFam = true;
            if (GaleriaFam == true)
            {

                DataTable dt = BLL.Galeria.Load();
                GalCf = dt.Rows.Count;
                if (GalCf != 0)
                {
                    if (GalCf == GalCi)
                    {
                        GalCi = 0;
                        DataTable dtG = BLL.Galeria.Load();

                        if (dtG.Rows.Count != 0)
                        {
                            pictureBox4.Image = byteArrayToImage((Byte[])dtG.Rows[GalCi][1]);
                            label4.Text = dtG.Rows[GalCi][2] + " - " + dtG.Rows[GalCi][3];
                            label4.Visible = true;
                            GalCi += 1;
                            pictureBox12.BringToFront();
                            pictureBox17.BringToFront();
                        }
                    }
                    else
                    {

                        DataTable dtG = BLL.Galeria.Load();

                        if (dtG.Rows.Count != 0)
                        {
                            pictureBox4.Image = byteArrayToImage((Byte[])dtG.Rows[GalCi][1]);
                            label4.Text = dtG.Rows[GalCi][2] + " - " + dtG.Rows[GalCi][3];
                            label4.Visible = true;
                            GalCi += 1;
                            pictureBox12.BringToFront();
                            pictureBox17.BringToFront();
                        }

                    }

                }
                else
                { }
            }
            else
            {


            }
            label10.Text = GalCi.ToString();
            label11.Text = GalCf.ToString();

            timer5.Stop();
            timer5.Start();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Jogo_GaleriaFam f1 = new Jogo_GaleriaFam();
            f1.Show();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        
    }
}
