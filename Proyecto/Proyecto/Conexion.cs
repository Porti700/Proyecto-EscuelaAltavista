using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Proyecto
{
    class Conexion
    {
        public string servidor, usuario, clave, db;
        public string cadena;
        DataTable dt;
        SqlDataAdapter da;
        public void conec()
        {
           
            servidor = "DESKTOP-DU6G356\\SQLEXPRESS";
            db = "EscuelaAltavista";
            usuario = "sa";
            clave = "123456";
            cadena = "server=" + servidor + ";uid=" + usuario + ";pwd=" + clave + ";database=" + db;


        }

        public void estudiantes()
        {
            try
            {
                da = new SqlDataAdapter("Select * from Alumnos", conn);
                da = Fill(dt);

            }
            catch (Exception ex)
            {

            }
        }


    }
}
