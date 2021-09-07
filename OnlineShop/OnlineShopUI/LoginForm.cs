using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineShop.DataAccess;
using System.IO;

namespace OnlineShop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginFormLoginButton_Click(object sender, EventArgs e)
        {
            if (CheckLogin() != null)
            {
                var selectedProductList = GlobalConfig.Connection.GetSelectedProducts();
                GlobalConfig.Connection.DeleteSelectedProductList(selectedProductList);
                HomeForm frm = new HomeForm(CheckLogin());
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login or password is invalid.");
            }
            
        }

        public UserModel CheckLogin()
        {   
            List<string> users = GlobalConfig.UserFile.FullFilePath().LoadFile();
            
                foreach (string user in users)
                {
                    if (user!= null && user!="" )
                    {
                        string[] cols = user.Split('|');

                        if (cols[1] == loginFormLoginValue.Text && cols[2] == loginFormPasswordValue.Text)
                        {
                            UserModel LoggedUser = new UserModel();
                            LoggedUser.Login = cols[1];
                            LoggedUser.Password = cols[2];
                            LoggedUser.FirstName = cols[3];
                            LoggedUser.LastName = cols[4];
                            LoggedUser.EmailAdress = cols[5];
                            LoggedUser.CellphoneNumber = cols[6];
                            return LoggedUser;
                        } 
                    }
                }
            return null;
        }

        private void loginFormBackButton_Click(object sender, EventArgs e)
        {
            
            welcomeForm frm = new welcomeForm();
            frm.Show();
            this.Close();
        }


    }
}
