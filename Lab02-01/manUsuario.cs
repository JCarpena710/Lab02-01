using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class manUsuario : Form
    {
        int pos;

        public manUsuario()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string direccion = txtDireccion.Text;
            string fecha = txtFN.Text;

            dgvUsuarios.Rows.Add(dni, nombre, apellido, email, telefono, direccion, fecha);
            limpiar_campos();

        }

        private void Modificar_Click(object sender, EventArgs e)
        {

            dgvUsuarios[0, pos].Value = txtDNI.Text;
            dgvUsuarios[1, pos].Value = txtNombre.Text;
            dgvUsuarios[2, pos].Value = txtApellido.Text;
            dgvUsuarios[3, pos].Value = txtEmail.Text;
            dgvUsuarios[4, pos].Value = txtTelefono.Text;
            dgvUsuarios[5, pos].Value = txtDireccion.Text;
            dgvUsuarios[6, pos].Value = txtFN.Text;

            limpiar_campos();

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Rows.RemoveAt(dgvUsuarios.CurrentRow.Index);
            limpiar_campos();

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow Row in dgvUsuarios.Rows)
            {
                string Valor = Convert.ToString(Row.Cells["DNI"].Value);

                if (Valor == this.txtDNI.Text)
                {
                    txtNombre.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                    txtApellido.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                    txtEmail.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                    txtTelefono.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
                    txtDireccion.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
                    txtFN.Text = dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
                }
            }
            
        }


        private void dgvUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = dgvUsuarios.CurrentRow.Index;

            txtDNI.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
            txtFN.Text = dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
        }

        private void limpiar_campos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
        }
    }
}
