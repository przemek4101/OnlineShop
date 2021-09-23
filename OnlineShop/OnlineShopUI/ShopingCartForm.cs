using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineShop.Models;

namespace OnlineShop
{
    public partial class ShopingCartForm : Form, IServiceList
    {
        List<ProductModel> selectedProductList = GlobalConfig.Connection.GetSelectedProducts();
        UserModel currentlyLoggedUser = new UserModel();

        public ShopingCartForm( UserModel user)
        {
            currentlyLoggedUser = user;
            InitializeComponent();
            
            WireUpLists();
            LoadCurrentlyLogged(user);
            DisplayPayment();
            
        }
        private void LoadCurrentlyLogged(UserModel user)
        {
            if (user != null)
            {
                shopingFormCurrentlyLoggedLabel.Text = user.Login.ToString();
            }
        }
        public bool ValidatedForm()
        {
            bool output = false;
            int quantity = 0;
            int.TryParse(shopingFormQuantityValue.Text, out quantity);
            if (quantity > 0)
            {
                output = true;
            }
            return output;
        }

        public void WireUpLists()
        {
            
            ShopingCartFormCostListBox.DataSource = null;
            ShopingCartFormCostListBox.DataSource = selectedProductList;
            ShopingCartFormCostListBox.DisplayMember = "Name";

            ShopingCartFormCostPrizeListBox.DataSource = null;
            ShopingCartFormCostPrizeListBox.DataSource = selectedProductList;
            ShopingCartFormCostPrizeListBox.DisplayMember = "Price";

            ShopingCartFormCostQuantityListBox.DataSource = null;
            ShopingCartFormCostQuantityListBox.DataSource = selectedProductList;
            ShopingCartFormCostQuantityListBox.DisplayMember = "Quantity";

            ShopingCartFormCostDescribtionListBox.DataSource = null;
            ShopingCartFormCostDescribtionListBox.DataSource = selectedProductList;
            ShopingCartFormCostDescribtionListBox.DisplayMember = "Description";

            shopingFormCostLabel.Text = calculateTotalCost().ToString() + " zł.";
        }

        private void shopingFormQuantityPlusButton_Click(object sender, EventArgs e)
        {
            ProductModel selectedProduct = (ProductModel)ShopingCartFormCostListBox.SelectedItem;
            int outValue = 0;

            if (selectedProduct != null)
            {
                bool tryParseValue = int.TryParse(shopingFormQuantityValue.Text, out outValue);
                if (tryParseValue)
                {
                    outValue += 1;
                }
                selectedProduct.Quantity = outValue;
                shopingFormQuantityValue.Text = outValue.ToString();
                WireUpLists();
            };
        }

        private void shopingFormQuantityMinButton_Click(object sender, EventArgs e)
        {
            ProductModel selectedProduct = (ProductModel)ShopingCartFormCostListBox.SelectedItem;
            int outValue = 0;
            if (selectedProduct != null)
            {
                bool tryParseValue = int.TryParse(shopingFormQuantityValue.Text, out outValue);
                if (tryParseValue)
                {
                    if (outValue >= 1)
                    {
                        outValue -= 1;
                    }
                    else
                    {
                        outValue = 0;
                    }
                }
                selectedProduct.Quantity = outValue;
                shopingFormQuantityValue.Text = outValue.ToString();
                WireUpLists();
            };


        }

        private void ShopingCartFormRemoveButton_Click(object sender, EventArgs e)
        {
            ProductModel productToRemove = (ProductModel)ShopingCartFormCostListBox.SelectedItem;
            if (productToRemove != null)
            {
                selectedProductList.RemoveAll(x => x.Id == productToRemove.Id);
                GlobalConfig.Connection.CreateSelectedProductsList(selectedProductList);

            }
            WireUpLists();
        }

        private decimal calculateTotalCost()
        {
            decimal output = 0;
            foreach (ProductModel model in selectedProductList)
            {
                output = output + ((model.Price) * (model.Quantity));
            }
            return output;
        }

        private void checkAndShowCorrectCount()
        {
            ProductModel selectedProduct1 = (ProductModel)ShopingCartFormCostListBox.SelectedItem;
            ProductModel selectedProduct2 = (ProductModel)ShopingCartFormCostDescribtionListBox.SelectedItem;
            ProductModel selectedProduct3 = (ProductModel)ShopingCartFormCostQuantityListBox.SelectedItem;
            ProductModel selectedProduct4 = (ProductModel)ShopingCartFormCostPrizeListBox.SelectedItem;
            if (selectedProduct1 != null)
            {
                shopingFormQuantityValue.Text = selectedProduct1.Quantity.ToString();
            }
            else if (selectedProduct2 != null)
            {
                shopingFormQuantityValue.Text = selectedProduct2.Quantity.ToString();
            }
            else if (selectedProduct3 != null)
            {
                shopingFormQuantityValue.Text = selectedProduct3.Quantity.ToString();
            }
            else if (selectedProduct4 != null)
            {
                shopingFormQuantityValue.Text = selectedProduct4.Quantity.ToString();
            }
        }

        private void DisplayPayment()
        {
            bool isVisible = false;
            if(ShoppingCartFormCorrectCheckBox.Checked)
            {
                isVisible = true;
            }
            
            shopingCartFormPaymentButton.Visible = isVisible;
        }
        private void ShopingCartFormCostListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAndShowCorrectCount();
        }

        private void ShoppingCartFormCorrectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (ShoppingCartFormCorrectCheckBox.Checked == true)
            {
                
                var consumerInformationAlert = MessageBox.Show("The order will be placed." +
                    "\nThe products you selected have been removed from the cart." +
                    "\nPress Ok if you want to continue or Cancel if you want to go back to shopping.",
                    "Customer information",
                    MessageBoxButtons.OKCancel);
                if (consumerInformationAlert == DialogResult.OK)
                {
                    GlobalConfig.Connection.CreateShopingCart(selectedProductList, currentlyLoggedUser, calculateTotalCost());
                    GlobalConfig.Connection.DeleteSelectedProductList(selectedProductList);
                    WireUpLists();
                }
                if (consumerInformationAlert == DialogResult.Cancel)
                {
                    ShoppingCartFormCorrectCheckBox.Checked = false;
                    

                }
            }
            DisplayPayment();
            
        }

        private void shopingCartFormPaymentButton_Click(object sender, EventArgs e)
        {
            GoToSite("https://www.paypal.com/");
        }
        public static void GoToSite(string url)
        {
            System.Diagnostics.Process.Start(url);
        }

        private void shoppingCartFormBackButton_Click(object sender, EventArgs e)
        {
            GlobalConfig.Connection.CreateSelectedProductsList(selectedProductList);
            HomeForm frm = new HomeForm(currentlyLoggedUser);
            frm.Show();
            this.Close();
        }

        private void homeFormLogoutButton_Click(object sender, EventArgs e)
        {
            welcomeForm frm = new welcomeForm();
            frm.Show();
            this.Close();
        }
    }
}

        