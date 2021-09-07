using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Models;

namespace OnlineShop.DataAccess
{
    class TextConnector : IDataConnection
    {
        public void CreateUser(UserModel user)
        {
            List<UserModel> users = GlobalConfig.UserFile.FullFilePath().LoadFile().ConvertToUserModels();

            int currId = 1;
            if (users.Count > 0)
            {
                currId = users.OrderByDescending(x => x.Id).First().Id + 1;
            }

            user.Id = currId;
            users.Add(user);
            users.SaveToUsersFile();
        }

        public void CreateProduct(ProductModel product)
        {
            List<ProductModel> products = GlobalConfig.ProductFile.FullFilePath().LoadFile().ConvertToProductModels();
            int currId = 1;
            if (products.Count > 0)
            {
                currId = products.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
            }
            product.Id = currId;
            products.Add(product);
            products.SaveToProductsFile();
        }

        

        public void RemoveProduct(ProductModel product)
        {
            List<ProductModel> products = GlobalConfig.ProductFile.FullFilePath().LoadFile().ConvertToProductModels();

            products.RemoveAll(x => x.Id == product.Id);
            products.SaveToProductsFile();
        }


        public List<CategoryModel> GetCategories()
        {
            return GlobalConfig.CategoryFile.FullFilePath().LoadFile().ConvertToCategoryModel();
        }

        public List<UserModel> GetUserAll()
        {
            return GlobalConfig.UserFile.FullFilePath().LoadFile().ConvertToUserModels();
        }

        public void CreateCategory(CategoryModel category)
        {
            List<CategoryModel> categories = GlobalConfig.CategoryFile.FullFilePath().LoadFile().ConvertToCategoryModel();
            int currId = 1;
            if (categories.Count > 0)
            {
                currId = categories.OrderByDescending(x => x.Id).First().Id + 1;
            }
            category.Id = currId;
            categories.Add(category);
            categories.SaveToCategoryFile();
        }

        public List<ProductModel> GetProducts()
        {

                return GlobalConfig.ProductFile.FullFilePath().LoadFile().ConvertToProductModels();
        }

        public List<ProductModel> GetSelectedProducts()
        {

            return GlobalConfig.SelectedProductsFile.FullFilePath().LoadFile().ConvertToSelectedProductModels();
        }


        public void CreateShopingCart(List<ProductModel> productList, UserModel shopingCartOwner, decimal TotalPrize)
        {
            productList.SaveToShopingCartFile(shopingCartOwner,TotalPrize);
        }

        public void CreateSelectedProductsList(List<ProductModel> selectedProductList)
        {
            selectedProductList.SaveToSelectedProductsFile();
        }

        public void DeleteSelectedProductList(List<ProductModel> selectedProductList)
        {
            selectedProductList.DeleteSelectedFile();
        }



    }
}
