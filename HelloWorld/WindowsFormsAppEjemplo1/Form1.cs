using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEjemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaludo_Click(object sender, EventArgs e)
        {
           
            String nombre;
            //recogo el valor del TextBox
            nombre = txtNombre.Text;

            if  (string.IsNullOrEmpty(nombre))//compruebo si esta vacio el TextBox
            {
                MessageBox.Show("Esta vacio el mensaje","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                MessageBox.Show($"hola {nombre}","Perfecto");
            }
          

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
