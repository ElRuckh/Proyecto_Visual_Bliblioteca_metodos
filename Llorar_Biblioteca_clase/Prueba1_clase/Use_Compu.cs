using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1_clase
{
    public partial class Use_Compu : UserControl
    {
        public Use_Compu()
        {
            InitializeComponent();
        }
        //variables


        private void Use_Compu_Load(object sender, EventArgs e)
        {
            //Cambia los botones 
            llenar();
        }
        public void Imagen1()
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\Libre.png");
            pictureBox2.Image = Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\Libre.png");
            pictureBox3.Image = Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\Libre.png");
            pictureBox4.Image = Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\Libre.png");
            pictureBox5.Image = Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\Libre.png");
            pictureBox6.Image = Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\Libre.png");
            pictureBox7.Image = Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\Libre.png");
            pictureBox8.Image = Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\Libre.png");
        }
        //sadasd
        public void llenar()
        {
            button1.Text = "LIBRE";
            button1.BackColor = Color.Lime;
            button1.Enabled = true;
            //
            button2.Text = "LIBRE";
            button2.BackColor = Color.Lime;
            button2.Enabled = true;
            //
            button3.Text = "LIBRE";
            button3.BackColor = Color.Lime;
            button3.Enabled = true;
            //
            button4.Text = "LIBRE";
            button4.BackColor = Color.Lime;
            button4.Enabled = true;
            //
            button5.Text = "LIBRE";
            button5.BackColor = Color.Lime;
            button5.Enabled = true;
            //
            button6.Text = "LIBRE";
            button6.BackColor = Color.Lime;
            button6.Enabled = true;
            //
            button7.Text = "LIBRE";
            button7.BackColor = Color.Lime;
            button7.Enabled = true;
            //
            button8.Text = "LIBRE";
            button8.BackColor = Color.Lime;
            button8.Enabled = true;
            
        }
        

       
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                button1.Text = "Ocupado";
                button1.BackColor = Color.Red;
                button1.Enabled = false;

                // BackgroundImage 
                // PictureBox.= Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\OCUPADO.png");
                pictureBox1.Image = Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\OCUPADO.png");
                
            }
            catch (Exception)
            {


            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                button2.Text = "Ocupado";
                button2.BackColor = Color.Red;
                button2.Enabled = false;
                pictureBox2.Image = Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\OCUPADO.png");
            }
            catch (Exception)
            {


            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                button3.Text = "Ocupado";
                button3.BackColor = Color.Red;
                button3.Enabled = false;
                pictureBox3.Image = Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\OCUPADO.png");
            }
            catch (Exception)
            {


            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                button4.Text = "Ocupado";
                button4.BackColor = Color.Red;
                button4.Enabled = false;
                pictureBox4.Image = Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\OCUPADO.png");
            }
            catch (Exception)
            {


            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                button6.Text = "Ocupado";
                button6.BackColor = Color.Red;
                button6.Enabled = false;
                pictureBox6.Image = Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\OCUPADO.png");
            }
            catch (Exception)
            {


            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                button5.Text = "Ocupado";
                button5.BackColor = Color.Red;
                button5.Enabled = false;
                pictureBox5.Image = Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\OCUPADO.png");
            }
            catch (Exception)
            {


            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                button7.Text = "Ocupado";
                button7.BackColor = Color.Red;
                button7.Enabled = false;
                pictureBox7.Image = Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\OCUPADO.png");
            }
            catch (Exception)
            {


            }

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                button8.Text = "Ocupado";
                button8.BackColor = Color.Red;
                button8.Enabled = false;
                pictureBox8.Image = Image.FromFile("C:\\Users\\Moreno\\Documents\\Visual Studio 2015\\Projects\\Llorar_Biblioteca_clase\\imge\\OCUPADO.png");
            }
            catch (Exception)
            {


            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            try
            {
                button1.Text = "LIBRE";
                button1.BackColor = Color.Lime;
                button1.Enabled = true;

                //
                button2.Text = "LIBRE";
                button2.BackColor = Color.Lime;
                button2.Enabled = true;
                //
                button3.Text = "LIBRE";
                button3.BackColor = Color.Lime;
                button3.Enabled = true;
                //
                button4.Text = "LIBRE";
                button4.BackColor = Color.Lime;
                button4.Enabled = true;
                //
                button5.Text = "LIBRE";
                button5.BackColor = Color.Lime;
                button5.Enabled = true;
                //
                button6.Text = "LIBRE";
                button6.BackColor = Color.Lime;
                button6.Enabled = true;
                //
                button7.Text = "LIBRE";
                button7.BackColor = Color.Lime;
                button7.Enabled = true;
                //
                button8.Text = "LIBRE";
                button8.BackColor = Color.Lime;
                button8.Enabled = true;
                Imagen1();
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text== "Usuario 1")
            {
                label3.Text = "ASIGNADO";
            }
            if (comboBox1.Text == "Usuario 2")
            {
                label4.Text = "ASIGNADO";
            }
            if (comboBox1.Text == "Usuario 3")
            {
                label5.Text = "ASIGNADO";
            }
            if (comboBox1.Text == "Usuario 4")
            {
                label6.Text = "ASIGNADO";
            }
            if (comboBox1.Text == "Usuario 5")
            {
                label7.Text = "ASIGNADO";
            }
            if (comboBox1.Text == "Usuario 6")
            {
                label8.Text = "ASIGNADO";
            }
            if (comboBox1.Text == "Usuario 7")
            {
                label9.Text = "ASIGNADO";
            }
            if (comboBox1.Text == "Usuario 8")
            {
                label10.Text = "ASIGNADO";
            }
            //label3.Text = comboBox1.Text = "";
            MessageBox.Show("Asignado");
            
        }
    }
}
