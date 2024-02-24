using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelHome.Entity;
using HotelHome.BLL;



namespace HotelHome.UI
{
    public partial class InicioLogin : Form
    {
        public InicioLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //private void txtuser_Enter(object sender, EventArgs e)
        //{
        //    if (txtuser.Text == "USUARIO")
        //    {
        //        txtuser.Text = "";
        //        txtuser.ForeColor = Color.White;
        //    }
        //}

        //private void txtuser_Leave(object sender, EventArgs e)
        //{
        //    if (txtuser.Text == "")
        //    {
        //        txtuser.Text = "USUARIO";
        //        txtuser.ForeColor = Color.White;

        //    }


        //}

        //private void txtpass_Enter(object sender, EventArgs e)
        //{
        //    if (txtpass.Text == "CONTRASEÑA")
        //    {
        //        txtpass.Text = "";
        //        txtpass.ForeColor = Color.White;
        //        txtpass.UseSystemPasswordChar = true;
        //    }
        //}

        //private void txtpass_Leave(object sender, EventArgs e)
        //{
        //    if (txtpass.Text == "")
        //    {
        //        txtpass.Text = "CONTRASEÑA";
        //        txtpass.ForeColor = Color.White;
        //        txtpass.UseSystemPasswordChar = false;
        //    }
        //}

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "USUARIO" )
            {
                if (txtpass.Text != "CONTRASEÑA")
                {

                    
                    var validLogin =B_Usuario.LoginUser(txtuser.Text,txtpass.Text);
                    if (validLogin == true) 
                    {
                        Home mainMenu = new Home();
                        MessageBox.Show("Bienvenido " + E_Usuario.FirstName + ", " + E_Usuario.LastName);
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Incorrect username or password entered.   \n         Please try again.");
                        txtpass.Text = "Password";
                        txtpass.UseSystemPasswordChar = false;
                        txtuser.Focus();
                    }
                }
                else msgError("Inserte la Contraseña.");
            }
            else msgError("Inserta el Usuario.");
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "      " + msg;
            lblErrorMessage.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            //txtpass.Text = "Password";
            //txtpass.UseSystemPasswordChar = false;
            //txtuser.Text = "Username";
            //lblErrorMessage.Visible = false;
            //this.Show();
        
          }

        private void InicioLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
    