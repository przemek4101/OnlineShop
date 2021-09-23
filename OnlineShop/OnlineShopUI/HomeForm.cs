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
    public partial class HomeForm : Form,IServiceList
    {
        private List<ProductModel> availableProducts = GlobalConfig.Connection.GetProducts();
        private List<ProductModel> selectedProducts = GlobalConfig.Connection.GetSelectedProducts();
        private List<string> sortCategories = new List<string>() {
            "Alphabetically: A->Z",
            "Alphabetically: Z->A",
            "Price: Low to High",
            "Price: High to Low" };
        
        
        
        private UserModel currentlyLoggedUser = new UserModel();
        
        public HomeForm(UserModel user)
        {
            
            InitializeComponent();
            currentlyLoggedUser = user;
            WireUpLists();
            DisplayAdminOptions(user);
            LoadCurrentlyLogged(user);
            homeFormSortBycomboBox.DataSource = null;
            homeFormSortBycomboBox.DataSource = sortCategories;



        }

        private void LoadCurrentlyLogged(UserModel user)
        {
            if (user != null)
            {
                homeFormCurrentlyLoggedLabel.Text = user.Login.ToString();
            }
        }

        private void DisplayAdminOptions(UserModel user)
        {
            if (user != null)
            {
                if (user.Login == "admin")
                {
                    adminFormAdminOptionsLink.Visible = true;
                    homeFormAdminRefreshButton.Visible = true;
                }
                else
                {
                    adminFormAdminOptionsLink.Visible = false;
                    homeFormAdminRefreshButton.Visible = false;
                }
            }
        }

        public bool ValidatedForm()
        {
            bool output = false;
            int quantity = 0;
            int.TryParse(homeFormQuantityValue.Text, out quantity);
            if(quantity > 0)
            {
                output = true;
            }
            else
            {
                MessageBox.Show("Product quantity must be greater than zero.");
            }
            return output;
            
        }

        public void WireUpLists()
        {

            //availableProducts = GlobalConfig.Connection.GetProducts();
            homeFormProductsNameListBox.DataSource = null;
            homeFormProductsNameListBox.DataSource = availableProducts;
            homeFormProductsNameListBox.DisplayMember = "Name";

            homeFormProductsDescriptionListBox.DataSource = null;
            homeFormProductsDescriptionListBox.DataSource = availableProducts;
            homeFormProductsDescriptionListBox.DisplayMember = "Description";

            homeFormProductsPriceListBox.DataSource = null;
            homeFormProductsPriceListBox.DataSource = availableProducts;
            homeFormProductsPriceListBox.DisplayMember = "Price";

            homeFormProductsCategoryListBox.DataSource = null;
            homeFormProductsCategoryListBox.DataSource = availableProducts;
            homeFormProductsCategoryListBox.DisplayMember = "Category";







        }

        private void SortListBy()
        {
            if (homeFormSortBycomboBox.SelectedItem.ToString() != null)
            {
                if (homeFormSortBycomboBox.SelectedItem.ToString() == "Alphabetically: A->Z")
                {
                    availableProducts = availableProducts.OrderBy(x => x.Name).ToList();
                }
                if (homeFormSortBycomboBox.SelectedItem.ToString() == "Alphabetically: Z->A")
                {
                    availableProducts = availableProducts.OrderByDescending(x => x.Name).ToList();
                }
                if (homeFormSortBycomboBox.SelectedItem.ToString() == "Price: Low to High")
                {
                    availableProducts = availableProducts.OrderBy(x => x.Price).ToList();
                }
                if (homeFormSortBycomboBox.SelectedItem.ToString() == "Price: High to Low")
                {
                    availableProducts = availableProducts.OrderByDescending(x => x.Price).ToList();
                }
                WireUpLists();
            }

        }

        private void SearchInList()
        {
            availableProducts = GlobalConfig.Connection.GetProducts();
            availableProducts = (List<ProductModel>)availableProducts.Where(x => x.Name.Contains(homeFormSearchValue.Text.ToString())).ToList();
            WireUpLists();
        }
        private void homeFormGoToCartButton_Click(object sender, EventArgs e)
        {
            GlobalConfig.Connection.CreateSelectedProductsList(selectedProducts);
            ShopingCartForm frm = new ShopingCartForm(currentlyLoggedUser);
            frm.Show();
            this.Close();
        }

        private void homeFormAddButton_Click(object sender, EventArgs e)
        {
            if(ValidatedForm())
            {
                
                ProductModel chosenModel = (ProductModel)homeFormProductsNameListBox.SelectedItem;
                chosenModel.Quantity = 0;
                
                chosenModel.Quantity = int.Parse(homeFormQuantityValue.Text);
                
                if(chosenModel!=null && chosenModel.Quantity > 0 )
                {
                    selectedProducts.Add(chosenModel);
                    homeFormQuantityValue.Text = "0";
                }
                
            }
        }

        private void adminFormAdminOptionsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminForm frm = new AdminForm();
            frm.Show();
        }

        private void homeFormQuantityPlusButton_Click(object sender, EventArgs e)
        {
                int outValue = 0 ;
            
                bool tryParseValue = int.TryParse(homeFormQuantityValue.Text, out outValue);
            if (tryParseValue)
            {
                outValue += 1;
            }
                homeFormQuantityValue.Text = outValue.ToString();
               
        }

        private void homeFormQuantityMinButton_Click(object sender, EventArgs e)
        {
            int outValue = 0;

            bool tryParseValue = int.TryParse(homeFormQuantityValue.Text, out outValue);
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
            homeFormQuantityValue.Text = outValue.ToString();
        }

        private void homeFormProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            homeFormQuantityValue.Text = "0";
            ProductModel chosenModel = (ProductModel)homeFormProductsNameListBox.SelectedItem;
            if (chosenModel != null)
            {
                homeFormTextProductNameValue.Text = chosenModel.Name;
            }
        }   

        public void ProductComplete(ProductModel model)
        {
            availableProducts.Add(model);
            WireUpLists();
        }

        private void homeFormAdminRefreshButton_Click(object sender, EventArgs e)
        {
            WireUpLists();
        }

      

        private void homeFormSortBycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SortListBy();
        }


        private void homeFormLogoutButton_Click(object sender, EventArgs e)
        {
            welcomeForm frm = new welcomeForm();
            frm.Show();
            this.Close();
        }

        private void homeFormSearchButton_Click(object sender, EventArgs e)
        {
            SearchInList();
        }

    }
}
