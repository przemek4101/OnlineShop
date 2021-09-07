using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Models;

namespace OnlineShop.DataAccess
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) // PrizeModels.csv
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }


        //USER_MODEL_________________________________________________________________
        public static List<UserModel> ConvertToUserModels(this List<string> lines)
        {
            List<UserModel> output = new List<UserModel>();
            foreach (string line in lines)
            {
                if (line!= null && line!="")
                {
                    string[] cols = line.Split('|');
                    UserModel user = new UserModel();
                    user.Id = int.Parse(cols[0]);
                    user.Login = cols[1];
                    user.Password = cols[2];
                    user.FirstName = cols[3];
                    user.LastName = cols[4];
                    user.EmailAdress = cols[5];
                    user.CellphoneNumber = cols[6];

                    output.Add(user); 
                }
            }
            return output;
        }

        public static void SaveToUsersFile(this List<UserModel> models)
        {
            List<string> lines = new List<string>();
            
            foreach(UserModel user in models)
            {
                lines.Add($"{ user.Id }|{ user.Login }|{ user.Password }|{ user.FirstName }|{ user.LastName }|{ user.EmailAdress }|{ user.CellphoneNumber }");
            }
            File.WriteAllLines(GlobalConfig.UserFile.FullFilePath(), lines);
        }

        //PRODUCT_MODEL_______________________________________________________________
        
        public static List<ProductModel> ConvertToProductModels(this List<string> lines)
        {
            List<ProductModel> output = new List<ProductModel>();

            foreach (string line in lines)
            {
                if (line != null && line != "")
                {
                    string[] cols = line.Split('|');
                    ProductModel product = new ProductModel();
                    product.Id = int.Parse(cols[0]);
                    product.Category = cols[1];
                    product.Name = cols[2];
                    product.Description = cols[3];
                    product.Price = decimal.Parse(cols[4]);
                    

                    output.Add(product);
                }
            }
            return output;
        }

        public static List<ProductModel> ConvertToSelectedProductModels(this List<string> lines)
        {
            List<ProductModel> output = new List<ProductModel>();

            foreach (string line in lines)
            {
                if (line != null && line != "")
                {
                    string[] cols = line.Split('|');
                    ProductModel product = new ProductModel();
                    product.Id = int.Parse(cols[0]);
                    product.Category = cols[1];
                    product.Name = cols[2];
                    product.Description = cols[3];
                    product.Price = decimal.Parse(cols[4]);
                    product.Quantity = int.Parse(cols[5]);

                    output.Add(product);
                }
            }
            return output;
        }

        public static void SaveToProductsFile(this List<ProductModel> products)
        {
            List<string> lines = new List<string>();
            foreach(ProductModel product in products)
            {
                lines.Add($"{ product.Id }|{ product.Category }|{ product.Name }|{ product.Description }|{ product.Price }");
                File.WriteAllLines(GlobalConfig.ProductFile.FullFilePath(), lines);
            }
        }

        //CATEGORY____________________________________________________________________

        public static List<CategoryModel> ConvertToCategoryModel(this List<string> lines)
        {

            List<CategoryModel> output = new List<CategoryModel>();
            foreach(string line in lines)
            {
                string[] cols = line.Split('|');
                CategoryModel category = new CategoryModel();
                category.Id = int.Parse(cols[0]);
                category.CategoryName = cols[1];
                output.Add(category);
            }
            return output;
        }

        public static void SaveToCategoryFile(this List<CategoryModel> categories)
        {
            List<string> lines = new List<string>();
            foreach (CategoryModel category in categories)
            {
                lines.Add($"{ category.Id }|{ category.CategoryName }");
                File.WriteAllLines(GlobalConfig.CategoryFile.FullFilePath(), lines);
            }
        }

        public static void SaveToShopingCartFile(this List<ProductModel> products, UserModel user, decimal TotalPrice)
        {
            List<string> lines = new List<string>();
            lines.Add($"{user.Login}|{user.FirstName}|{user.LastName}|{user.EmailAdress}|{user.CellphoneNumber}");
            foreach (ProductModel product in products)
            {
                lines.Add($"{ product.Id }|{ product.Category }|{ product.Name }|{ product.Description }|{ product.Price }|{ product.Quantity }");
                
                File.WriteAllLines(GlobalConfig.ShopingCartFile.FullFilePath(), lines);
            }
            lines.Add($"Total Price: { TotalPrice }");
            File.WriteAllLines(GlobalConfig.ShopingCartFile.FullFilePath(), lines);
            
        }

        public static void DeleteSelectedFile(this List<ProductModel> products)
        {
            File.Delete(GlobalConfig.SelectedProductsFile.FullFilePath());
        }
        public static void SaveToSelectedProductsFile(this List<ProductModel> products)
        {
            List<string> lines = new List<string>();
            
            foreach (ProductModel product in products)
            {
                lines.Add($"{ product.Id }|{ product.Category }|{ product.Name }|{ product.Description }|{ product.Price }|{ product.Quantity }");

                File.WriteAllLines(GlobalConfig.SelectedProductsFile.FullFilePath(), lines);
            }
           
        }
    }

   
}
