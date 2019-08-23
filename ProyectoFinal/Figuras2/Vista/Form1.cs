using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            button7.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button5.Visible = true;
            label1.Visible = false;
            button6.Visible = false;
            button4.Visible = false;
            button3.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button3.Visible = false;

        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            button7.Visible = false;
        }


        private void Button1_Click_1(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            label1.Visible = true;
            label1.Text = "altura";
            label2.Visible = true;
            label2.Text = "base";
            textBox1.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;
            button7.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            label1.Visible = true;
            label1.Text = "lado";
            textBox1.Visible = true;
            button4.Visible = true;
            button7.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            textBox4.Visible = true;
            int a = 0, b = 0;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            Control.Controlador.obtenerControl().CrearRectangulo(a, b);// enviamos los parametros 
            textBox3.Text = Convert.ToString(Control.Controlador.obtenerControl().ConsultarPerimetro());
            textBox4.Text = Convert.ToString(Control.Controlador.obtenerControl().ConsultarArea());

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            textBox4.Visible = true;
            int a = 0;
            a = Convert.ToInt32(textBox1.Text);
            Control.Controlador.obtenerControl().CrearCuadra(a);

            textBox3.Text = Convert.ToString(Control.Controlador.obtenerControl().ConsultarPerimetro());
            textBox4.Text = Convert.ToString(Control.Controlador.obtenerControl().ConsultarArea());

        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            label1.Visible = true;
            label1.Text = "diagonal 1";
            label2.Visible = true;
            label2.Text = "diagonal 2";
            textBox1.Visible = true;
            textBox2.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            textBox4.Visible = true;
            int a1 = 0, b1 = 0;
            a1 = Convert.ToInt32(textBox1.Text);
            b1 = Convert.ToInt32(textBox2.Text);
            Control.Controlador.obtenerControl().crearRombo(a1, b1);

            textBox3.Text = Convert.ToString(Control.Controlador.obtenerControl().ConsultarPerimetro());
            textBox4.Text = Convert.ToString(Control.Controlador.obtenerControl().ConsultarArea());
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            button7.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button5.Visible = true;
            label1.Visible = false;
            button6.Visible = false;
            button4.Visible = false;
            button3.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button3.Visible = false;
        }
    }
}
