using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Conexion c = new Conexion();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.loadUser(DgvPersonas);
            txtId.Enabled = false;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            add.Enabled = false;
            nombre.Enabled = false;
            app.Enabled = false;
            mat.Enabled = false;
            Tarea.Enabled = false;
            maestro.Enabled = false;
            addHw.Enabled = false;
            DgvPersonas.Visible = false;
            DgvUser.Visible = false;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.insertar(nombre.Text, app.Text, mat.Text,Tarea.Text,maestro.Text));
            DgvPersonas.Visible = true;
            DgvUser.Visible = false;
            c.loadUser(DgvPersonas);
            nombre.Text = "";
            app.Text = "";
            mat.Text = "";
            Tarea.Text = "";
            maestro.Text = "";
            txtId.Enabled = false;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            add.Enabled = false;
            nombre.Enabled = false;
            app.Enabled = false;
            mat.Enabled = false;
            Tarea.Enabled = false;
            maestro.Enabled = false;
            addHw.Enabled = false;

        }

        private void DgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {   
            if (RbModificar.Checked == true )
            {
                
               
                if (c.personaRegistrada(Convert.ToInt32(txtId.Text)) > 0)
                {
                    c.llenarTexBoxConsulta(Convert.ToInt32(txtId.Text), nombre, app, mat);
                    BtnModificar.Enabled = true; 
                }
                else
                {
                    
                    nombre.Text = "";
                    app.Text = "";
                    BtnModificar.Enabled = false;
                }
            }

            if (RbTareas.Checked == true)
            {


                if (c.personaRegistrada(Convert.ToInt32(txtId.Text)) > 0)
                {
                    c.llenarTexBoxConsulta(Convert.ToInt32(txtId.Text), nombre, app, mat);
                    addHw.Enabled = true;
                }
                else
                {

                    nombre.Text = "";
                    app.Text = "";
                    addHw.Enabled = false;
                }
            }

           
        }

        private void RbModificar_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled=true;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = false;
            add.Enabled = false;
            txtId.Enabled = true;
            nombre.Enabled = true;
            app.Enabled = true;
            mat.Enabled = true;
            Tarea.Enabled = false;
            maestro.Enabled = false;
            addHw.Enabled = false;
        }

        private void RbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            nombre.Enabled = false;
            app.Enabled = false;
            mat.Enabled = false;
            BtnEliminar.Enabled = true;
            add.Enabled = false;
            BtnModificar.Enabled = false;
            Tarea.Enabled = false;
            maestro.Enabled = false;
            addHw.Enabled = false;
          
        }

        private void RbInsertar_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            nombre.Enabled = true;
            app.Enabled = true;
            mat.Enabled = true;
            add.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            Tarea.Enabled = false;
            maestro.Enabled = false;
            addHw.Enabled = false;
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.eliminar(Convert.ToInt32(txtId.Text), nombre.Text, app.Text, mat.Text));
            DgvPersonas.Visible = true;
            DgvUser.Visible = false;
            c.loadUser(DgvPersonas);
            txtId.Text = "";
            nombre.Text = "";
            app.Text = "";
            mat.Text = "";
            txtId.Enabled = false;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            add.Enabled = false;
            nombre.Enabled = false;
            app.Enabled = false;
            mat.Enabled = false;
            Tarea.Enabled = false;
            maestro.Enabled = false;
            addHw.Enabled = false;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.actualizar(Convert.ToInt32(txtId.Text), nombre.Text, app.Text, mat.Text));
            DgvPersonas.Visible = true;
            DgvUser.Visible = false;
            c.loadUser(DgvPersonas);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            add.Enabled = false;
            nombre.Enabled = false;
            app.Enabled = false;
            mat.Enabled = false;
            Tarea.Enabled = true;
            maestro.Enabled = true;
            addHw.Enabled = true;

        }

        private void addHw_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.insertarHw(Convert.ToInt32(txtId.Text), Tarea.Text, maestro.Text));
            c.loadUser(DgvPersonas);
            nombre.Text = "";
            app.Text = "";
            mat.Text = "";
            Tarea.Text = "";
            maestro.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DgvPersonas.Visible = true;
            DgvUser.Visible = false;
            c.loadUser(DgvPersonas);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DgvUser.Visible = true;
            DgvPersonas.Visible = false;
            c.loadUserHw(DgvUser);
        }

       

    }
}
