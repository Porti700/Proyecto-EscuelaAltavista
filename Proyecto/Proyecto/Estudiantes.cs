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

    public partial class Estudiantes : Form
    {

        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn; 
        private List<Estudiante> Producto = new List<Estudiante>();
        private int edit_indice = -1;


        private void actualizarGrid()
        {

            dgvestudiantes.Rows.Clear();

            for (int i = 0; i < DatosEstudiantes.nombre.Count; i++)
            {
                dgvestudiantes.Rows.Add(
                    new object[] { DatosEstudiantes.nombre[i], DatosEstudiantes.apellidos [i], DatosEstudiantes.idgrado[i], DatosEstudiantes.id[i] });
            }
        }



        public Estudiantes()
        {
            actualizarGrid();
            InitializeComponent();

            Conexion cn = new Conexion();
            cn.conec();
            sCn = cn.cadena;
            conn = new SqlConnection(sCn);
        }

        private void Estudiantes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtningresarE_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                //Variable insertar
                string insertAlumno;
                insertAlumno = "INSERT INTO ALUMNOS(ID, Nombres, Apellidos, IdGrado)";
                insertAlumno += "VALUES (@ID, @Nombres, @Apellidos, @IdGrado)";
                insert1 = new SqlCommand(insertAlumno, conn);
                insert1.Parameters.Add(new SqlParameter("@ID", SqlDbType.Char));
                insert1.Parameters["@ID"].Value = txtidE.Text;
                insert1.Parameters.Add(new SqlParameter("@Nombres", SqlDbType.VarChar));
                insert1.Parameters["@Nombres"].Value = txtnombreE.Text;
                insert1.Parameters.Add(new SqlParameter("@Apellidos", SqlDbType.VarChar));
                insert1.Parameters["@Apellidos"].Value = txtapellidoE.Text;
                insert1.Parameters.Add(new SqlParameter("@IdGrado", SqlDbType.Char));
                insert1.Parameters["@IdGrado"].Value = txtgradoE.Text;
                insert1.ExecuteNonQuery();
                txtnombreE.Clear();
                txtapellidoE.Clear();
                txtgradoE.Clear();
                txtidE.Clear();
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
        private void btnmenuE_Click(object sender, EventArgs e)
        {
            MENU frm1 = new MENU();
            frm1.Show();
            this.Hide();
        }

       

        private void btnactualizarE_Click(object sender, EventArgs e)
        {
            conn.Open();
            string nombre = txtnombreE.Text;
            string apellido = txtapellidoE.Text;
            string id = txtidE.Text;
            string cadena = "update Alumnos set Nombres='" + nombre + "', Apellidos=" + apellido + "where codigo=" + txtidE;
            SqlCommand comando = new SqlCommand(cadena, conn);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del alumno");
                txtnombreE.Text = "";
                txtapellidoE.Text = "";
            }
            else
                MessageBox.Show("No existe un nombre con el código ingresado");
            conn.Close();
            btnactualizarE.Enabled = false;
        }
    
    
        private void txtnombreE_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void txtnombreEstu(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtapellido(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtgradoE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgradoestu(object sender, KeyPressEventArgs e)
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
            else if ((e.KeyChar == '.') && (!txtgradoE.Text.Contains(".")))
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

        private void dvglistado(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvestudiantes.SelectedRows[0];
            int posicion = dgvestudiantes.Rows.IndexOf(selected); //almacena en cual fila estoy 

            edit_indice = posicion; //copio esa variable en índice editado 


            Estudiante estudiant = Producto [posicion]; /*esta variable de tipo persona, se carga con los valores que le pasa el listado*/

            //lo que tiene el atributo se lo doy al textbox            
            txtnombreE.Text = estudiant.Nombre;
            txtapellidoE.Text = estudiant.Apellidos;
            txtgradoE.Text = Convert.ToString(estudiant.GradoE);
            txtidE.Text = Convert.ToString(estudiant.Id);
            

        }




        private void actualizarGrid()
        {
            dgvestudiantes.DataSource = null;
            dgvestudiantes.DataSource = Estudiante; /*los nombres de columna que veremos sonlos de las propiedades*/
        }
        private void reseteo()
        {
            txtnombreE.Clear();
            txtapellidoE.Clear();
            txtgradoE.Clear();
            txtidE.Clear();
        }
    }
}




