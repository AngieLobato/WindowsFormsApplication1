using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    class Conexion
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader read;
        SqlDataAdapter da;
        DataTable dt;

        public Conexion()
        {
            try
            {
                con = new SqlConnection ("Data Source=CLUW006\\SQLEXPRESS;Initial Catalog=DatUsuario;Integrated Security=True");
                con.Open();
               
            }
            catch(Exception ex)
            {
                 MessageBox.Show ("Noooo Con"+ ex.ToString());
            }
        }

        public string insertar(string nombre, string apellido, string materia, string tarea,string maestro)
        {
            string salida = "GOOD USER!";
            try
            {
                cmd = new SqlCommand("insert into Usuarios (Nombre,Apellido,Materia) values ('" + nombre + "','" + apellido + "','"+materia+"')",con);
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                 salida = "BAD !"+ ex.ToString();
            }
            return salida;
        }

        public string insertarHw(int id, string tarea, string maestro)
        {
            string salida = "GOOD!";
            try
            {
                cmd = new SqlCommand("insert into Materia (idUser,Nombre,Profesor) values (" + id + ",'" + tarea + "','" + maestro + "')", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "BAD !" + ex.ToString();
            }
            return salida;
        }


        public void loadUser(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT Usuarios.IdUser, Usuarios.Nombre, Usuarios.Apellido FROM Usuarios", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DataGridview BADD: " + ex.ToString());
            }
        }



        public void loadUserHw(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT Usuarios.IdUser, Usuarios.Nombre, Usuarios.Apellido, Usuarios.Materia, Materia.Nombre AS Tema, Materia.Profesor FROM Usuarios INNER JOIN Materia ON Usuarios.IdUser = Materia.idUser", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DataGridview BADD: " + ex.ToString());
            }
        }

        public int personaRegistrada(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Usuarios where IdUser=" + id + "", con);
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    contador++;
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }


       
        public void llenarTexBoxConsulta(int id,TextBox nombre, TextBox app,TextBox mat)
        {
            try
            {
                cmd = new SqlCommand("Select * from Usuarios where IdUser=" + id + "", con);
                read = cmd.ExecuteReader();
                if (read.Read())
                {
                    nombre.Text = read["Nombre"].ToString();
                    app.Text = read["Apellido"].ToString();
                    mat.Text = read["Materia"].ToString();

                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" 00 No se pudo llenar los campos: " + ex.ToString());
            }
        }

        public string actualizar(int id, string nombre, string apellidos, string mat)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("Update Usuarios set Nombre ='" + nombre + "' ,Apellido='" + apellidos + "', Materia='" + mat + "' where IdUser=" + id + "", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "01 No se actualizo: " + ex.ToString();
            }
            return salida;
        }

        public string eliminar(int id, string nombre, string apellidos, string mat)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("delete from Usuarios where idUser=" + id + "", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "01 No se elimino: " + ex.ToString();
            }
            return salida;
        }

    }
}
