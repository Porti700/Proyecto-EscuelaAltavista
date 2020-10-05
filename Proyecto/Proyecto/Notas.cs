using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto
{
    public partial class Notas : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        private String sCn;
        public Notas()
        {
            InitializeComponent();
            Conexion cn = new Conexion();
            cn.conec();
            sCn = cn.cadena;
            conn = new SqlConnection(sCn);
        }

        private void btningresarN_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                //Variable insertar
                String insertNotas;
                insertNotas = "INSERT INTO Notas(ID, IdMateria, IdAlumno, Act1, Act2, Act3, Examen, Promedio)";
                insertNotas += "VALUES (@ID, @IdMateria, @IdAlumno, @Act1, @Act2, @Act3, @Examen, @Promedio)";
                insert1 = new SqlCommand(insertNotas, conn);
                insert1.Parameters.Add(new SqlParameter("@ID", SqlDbType.Char));
                insert1.Parameters["@ID"].Value = txtidN.Text;
                insert1.Parameters.Add(new SqlParameter("@IdMateria", SqlDbType.Char));
                insert1.Parameters["@IdMateria"].Value = txtidmateriaN.Text;
                insert1.Parameters.Add(new SqlParameter("@IdAlumno", SqlDbType.Char));
                insert1.Parameters["@IdAlumno"].Value = txtidalumnoN.Text;
                insert1.Parameters.Add(new SqlParameter("@Act1", SqlDbType.Float));
                insert1.Parameters["@Act1"].Value = txtact1N.Text;
                insert1.Parameters.Add(new SqlParameter("@Act2", SqlDbType.Float));
                insert1.Parameters["@Act2"].Value = txtact2N.Text;
                insert1.Parameters.Add(new SqlParameter("@Act3", SqlDbType.Float));
                insert1.Parameters["@Act3"].Value = txtact3N.Text;
                insert1.Parameters.Add(new SqlParameter("@Examen", SqlDbType.Float));
                insert1.Parameters["@Examen"].Value = txtexamenN.Text;
                insert1.Parameters.Add(new SqlParameter("@Promedio", SqlDbType.Float));
                insert1.Parameters["@Promedio"].Value = txtpromedioN.Text;
                insert1.ExecuteNonQuery();
                txtidN.Clear();
                txtidmateriaN.Clear();
                txtidalumnoN.Clear();
                txtact1N.Clear();
                txtact3N.Clear();
                txtact2N.Clear();
                txtexamenN.Clear();
                txtpromedioN.Clear();
                MessageBox.Show("Registro ingresado...", "Ingresar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("El registro no fue ingresado...",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void gbnotas_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnmenuN_Click(object sender, EventArgs e)
        {
            MENU frm1 = new MENU();
            frm1.Show();
            this.Hide();
        }

        private void btnactualizarN_Click(object sender, EventArgs e)
        {

        }

        private void txt(object sender, KeyPressEventArgs e)
        {

        }

        private void txtactividad1(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtact1N.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtactividad2(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtact2N.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtactividad3(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtact3N.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtexamen(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtexamenN.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtpromedio(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtpromedioN.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}






