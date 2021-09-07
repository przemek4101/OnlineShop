using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OnlineShop
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerFormRegisterButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                UserModel user = new UserModel();
                user.Login = registerFormLoginValue.Text;
                user.Password = registerFormPasswordValue.Text;
                user.FirstName = registerFormFirstNameValue.Text;
                user.LastName = registerFormLastNameValue.Text;
                user.EmailAdress = registerFormEmailValue.Text;
                user.CellphoneNumber = registerFormCellphoneValue.Text;

                if (CheckIfThereIsSuchAnAccount(user.Login))
                {
                    GlobalConfig.Connection.CreateUser(user);
                   
                    var selectedProductList = GlobalConfig.Connection.GetSelectedProducts();
                    GlobalConfig.Connection.DeleteSelectedProductList(selectedProductList);
                    HomeForm frm = new HomeForm(user);
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("A user with such a login exists.");
                    
                }
                

            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again."+
                    "\nRemember to enter a valid email and cellphone number");
            }
            
        }



        private bool ValidateForm()
        {
            bool output = true;
            int tryParseOutput = 0;

            if (registerFormLoginValue.Text.Length == 0)
            {
                output = false;
            }
            if (registerFormPasswordValue.Text.Length == 0)
            {
                output = false;
            }
            if (registerFormFirstNameValue.Text.Length == 0)
            {
                output = false;
            }
            if (registerFormLastNameValue.Text.Length == 0)
            {
                output = false;
            }
            if (registerFormEmailValue.Text.Length == 0 || isValidEmail(registerFormEmailValue.Text.ToString()) != true)
            {
                output = false;
            }
            if (registerFormCellphoneValue.Text.Length == 0 || int.TryParse(registerFormCellphoneValue.Text, out tryParseOutput)!=true)
            {
                output = false;
            }
                
            return output;
            
        }

        private bool CheckIfThereIsSuchAnAccount(string login)
        {
            var CreatedAccounts = GlobalConfig.Connection.GetUserAll();

            foreach (UserModel account in CreatedAccounts)
            {
                if(account.Login == login)
                {
                    return false;
                }
            }
            return true;
        }

        public bool isValidEmail(string source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }
        private void registerFormBackButton_Click(object sender, EventArgs e)
        {
            welcomeForm frm = new welcomeForm();
            frm.Show();
            this.Close();
        }

    }
}
