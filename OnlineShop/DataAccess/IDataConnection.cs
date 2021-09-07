using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Models;

namespace OnlineShop.DataAccess
{
    public interface IDataConnection
    {
        void CreateUser(UserModel user);
        void CreateProduct(ProductModel product);

        void CreateShopingCart(List<ProductModel> product, UserModel shopingCartOwner, decimal TotalPrize);

        void RemoveProduct(ProductModel product);
        void CreateCategory(CategoryModel category);
        void CreateSelectedProductsList(List<ProductModel> selectedProductList);
        void DeleteSelectedProductList(List<ProductModel> selectedProductList);
        List<CategoryModel> GetCategories();
        List<ProductModel> GetProducts();
        List<ProductModel> GetSelectedProducts();
        List<UserModel> GetUserAll();

    }
}
