using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasTiempos
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            this.validateCredentials();
        }

       

        private void validateCredentials()
        {
            if (this.txtUserName.Text == "admin" && this.txtPassword.Text == "123456")
            {
                this.Hide();
                FrmMenu menu = new FrmMenu();
                menu.ShowDialog();
            }
            else
            {
                if (this.txtUserName.Text != "admin")
                {

                    MessageBox.Show("Usuario incorrecto");
                    this.txtUserName.Clear();
                    this.txtUserName.Focus();

                }
                else
                {
                    MessageBox.Show("Contrasena incorrecta");
                    this.txtPassword.Clear();
                    this.txtPassword.Focus();
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
               
                this.validateCredentials();
            }
        }
    }
}
