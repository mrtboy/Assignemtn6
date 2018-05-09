using Assignment6.Controllers;
using Assignment6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        IUserController userController;
        public Form1()
        {
            InitializeComponent();
            userController = new UserController();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(txtUserName.Text, txtPassword.Text);
                if (userController.Login(user))
                {
                    CarCompany cc = new CarCompany();
                    cc.Show();
                    this.Hide();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        //private void btnSignUp_Click(object sender, EventArgs e)
        //{
        //    User user = new User(txtUserName.Text, txtUserName.Text);
        //    userController.Register(user);

        //    //lblRegisterTitle.Hide();
        //    //btnSignUp.Hide();
        //    btnLogin.Show();
        //   lblLoginTitle.Show();
        //}
    }
}
