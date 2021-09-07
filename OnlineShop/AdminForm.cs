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
using OnlineShop.Models;

namespace OnlineShop
{
    public partial class AdminForm : Form, IServiceList, ICategoryRequester
    {
        
        private List<CategoryModel> availableCategory = GlobalConfig.Connection.GetCategories();
        private List<ProductModel> availableProducts = GlobalConfig.Connection.GetProducts();
        

        public AdminForm()
        {
            InitializeComponent();
            WireUpLists();

        }

        public bool ValidatedForm()
        {
            bool output = true;
            decimal priceValue = 0;
            if(adminFormNameValue.Text.Length == 0)
            {
                output = false;
            }
            if(adminFormDescriptionValue.Text.Length == 0)
            {
                output = false;
            }
            if(adminFormPriceValue.Text.Length == 0)
            {
                output = false;
            }
            bool priceValueControl = decimal.TryParse(adminFormPriceValue.Text, out priceValue);
            if(priceValueControl == false)
            {
                output = false;
            }
            if(priceValue <= 0)
            {
                output = false;
            }

            return output;
        }

        public void WireUpLists()
        {
            adminFormCategoryComboBox.DataSource = null;
            adminFormCategoryComboBox.DataSource = availableCategory;
            adminFormCategoryComboBox.DisplayMember = "CategoryName";

            adminFormProductsListBox.DataSource = null;
            adminFormProductsListBox.DataSource = availableProducts;
            adminFormProductsListBox.DisplayMember = "Name";

            adminFormCategoryProductsListBox.DataSource = null;
            adminFormCategoryProductsListBox.DataSource = availableProducts;
            adminFormCategoryProductsListBox.DisplayMember = "Category";

        }

        private void adminFormCreateNewCategoryLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewCategoryForm frm = new NewCategoryForm(this);
            frm.Show();
        }

        private void adminFormAddButton_Click(object sender, EventArgs e)
        {
            if (ValidatedForm())
            {
                CategoryModel category = (CategoryModel)adminFormCategoryComboBox.SelectedItem;


                ProductModel product = new ProductModel(
                    category.CategoryName.ToString(),
                    adminFormNameValue.Text,
                    adminFormDescriptionValue.Text,
                    adminFormPriceValue.Text);

                GlobalConfig.Connection.CreateProduct(product);
                availableProducts.Add(product);
                WireUpLists();

                adminFormNameValue.Text = "";
                adminFormDescriptionValue.Text = "";
                adminFormPriceValue.Text = "";
               
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
            

        }

        public void CategoryComplete(CategoryModel model)
        {
            availableCategory.Add(model);
            WireUpLists();
        }

        private void adminFormDoneButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void adminFormRemoveButton_Click(object sender, EventArgs e)
        {
            
            ProductModel product = (ProductModel)adminFormProductsListBox.SelectedItem;
            if(product!= null)
            {
                availableProducts.Remove(product);
                GlobalConfig.Connection.RemoveProduct(product);
                
                WireUpLists();
            }

            
        }

    }
}
