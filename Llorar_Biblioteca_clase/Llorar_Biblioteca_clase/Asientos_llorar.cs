using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Llorar_Biblioteca_clase
{
    public partial class Asientos_llorar : UserControl
    {
        public Asientos_llorar()
        {
            InitializeComponent();
        }

        private void Asientos_llorar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Text = "Ocupado";
                button1.BackColor = Color.Red;
                button1.Enabled = false;
            }
            catch (Exception)
            {

                
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                button2.Text = "Ocupado";
                button2.BackColor = Color.Red;
                button2.Enabled = false;
            }
            catch (Exception)
            {

                
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                button4.Text = "Ocupado";
                button4.BackColor = Color.Red;
                button4.Enabled = false;
            }
            catch (Exception)
            {

                MessageBox.Show("Asiento asignado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                button3.Text = "Ocupado";
                button3.BackColor = Color.Red;
                button3.Enabled = false;
            }
            catch (Exception)
            {

                
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                button5.Text = "Ocupado";
                button5.BackColor = Color.Red;
                button5.Enabled = false;
            }
            catch (Exception)
            {

                
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                button6.Text = "Ocupado";
                button6.BackColor = Color.Red;
                button6.Enabled = false;
            }
            catch (Exception)
            {

                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                button7.Text = "Ocupado";
                button7.BackColor = Color.Red;
                button7.Enabled = false;
            }
            catch (Exception)
            {

                
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                button8.Text = "Ocupado";
                button8.BackColor = Color.Red;
                button8.Enabled = false;
            }
            catch (Exception)
            {

               
            }

        }

        private void button9_Click(object sender, EventArgs e)
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
            }
            catch (Exception)
            {

                
            }
           

        }
    }
}
