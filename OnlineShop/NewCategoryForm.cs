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
    public partial class NewCategoryForm : Form
    {
        ICategoryRequester callingForm;
        public NewCategoryForm(ICategoryRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void createNewCategoryFormCreateButton_Click(object sender, EventArgs e)
        {
            if(createNewCategoryFormCategoryValue.Text.Length > 0)
            {
                CategoryModel newCategory = new CategoryModel();
                newCategory.CategoryName = createNewCategoryFormCategoryValue.Text;
                GlobalConfig.Connection.CreateCategory(newCategory);
                callingForm.CategoryComplete(newCategory);
                
                
            }
            createNewCategoryFormCategoryValue.Text = "";
           
        }
    }
}
