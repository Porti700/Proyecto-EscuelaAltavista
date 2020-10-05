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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btnestudiantes_Click(object sender, EventArgs e)
        {
            Estudiantes frm2 = new Estudiantes();
            frm2.Show();
            this.Hide();
        }

        private void Btnnotas_Click(object sender, EventArgs e)
        {
            Notas frm3 = new Notas(); ;
            frm3.Show();
            this.Hide();
        }

        private void Btnarchivo_Click(object sender, EventArgs e)
        {
            Archivo frm4 = new Archivo();
            frm4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
