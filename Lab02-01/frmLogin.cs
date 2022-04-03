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
    public partial class frmLogin : Form
    {

        int attempt;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            PrincipalMDI principal = new PrincipalMDI();

            /*
            principal.Show();
            this.Hide();
            */

            String[] Username = { "user1", "user2", "user3", "user4", "user5", "user6" };
            String[] Password = { "user1", "user2", "user3", "user4", "user5", "user6" };

            if (Username.Contains(txtUsuario.Text) && Password.Contains(txtPassword.Text) && Array.IndexOf(Username, txtUsuario.Text)== Array.IndexOf(Password, txtPassword.Text))
                    {
                principal.Show();
                this.Hide();
                txtUsuario.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Datos invalidos");
                txtUsuario.Clear();
                txtPassword.Text = "";
                txtUsuario.Focus();
                attempt += 1;
                if (attempt == 3)
                {
                    Application.Exit();

                }
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
