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
    public partial class Loading : Form
    {
        string pri = "";
        int time = 0;
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();


            //Form1 f2 = new Form1();
            //f2.Show();
            //this.Hide();
            


            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 1;
            if (time == 1)
            {
                //DataTable dt = BLL.Primeira_sessao.queryCliente();
                //pri = dt.Rows[0][1].ToString();
                //if (pri == "False")
                //{
                //    int x = BLL.Primeira_sessao.updateCliente(true);
                Registo_Administrador f1 = new Registo_Administrador();
                f1.Show();
                //    this.Hide();
                //    timer1.Stop();
                //}
                //else
                //{
                    //Form1 f2 = new Form1();
                    //f2.Show();
                    this.Hide();
                    timer1.Stop();
                //}
            }

        }
    }
}
