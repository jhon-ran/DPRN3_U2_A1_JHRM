using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DPRN3_U2_A1_JHRM
{
    class Conexion
    {
        //Se declara un objeto de SQl connection
        SqlConnection con;
        //Se instancia el objeto SQL y se le pasa la cadena de conexión a la BD del programa 
        public Conexion()
        {
            con = new SqlConnection("Server = localhost\\SQLEXPRESS; Database = EmpresaABC; Trusted_Connection = True;");
        }

        //método para abrir conexión a la BD
        public SqlConnection conectar()
        {
            try 
            {
                con.Open();
                MessageBox.Show("Se conectó correctamente a la Base de Datos");
                return con;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar correctamente a la Base de Datos");
                return null; 
            }
            
        }

        //método para cerrar conexión a la BD
        public bool desconectar()
        {
            try
            {
                con.Close();
                MessageBox.Show("Se desconectó correctamente a la Base de Datos");
                return true;
            }
            catch (Exception e)
            { return false; }

        }

    }
}
