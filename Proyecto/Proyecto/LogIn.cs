using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String usuario = txtusuario.Text;
            Int32 contra = Convert.ToInt32(txtcontra.Text);

            if(usuario == "admin")
            {
                if(contra == 123456)
                {
                    SPLASH frms = new SPLASH();
                    frms.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }
    }
}
