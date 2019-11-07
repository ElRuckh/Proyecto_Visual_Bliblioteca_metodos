using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asientos_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void asientos_llorar1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = new Button();
                btn.Text = "SALIR";
                btn.BackColor = Color.Red;
                btn.Size = new Size(95, 46);
                btn.Location = new Point(102, 458);
                Controls.Add(btn);
                btn.Click += Btn_Click;
            }
            catch (Exception)
            {

                throw; 
            }
           
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
