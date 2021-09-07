using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.DataAccess;

namespace OnlineShop
{
    public static class GlobalConfig
    {
        public const string UserFile = "UserModels.csv";
        public const string ProductFile = "ProductModels.csv";
        public const string CategoryFile = "CategoryModels.csv";
        public const string ShopingCartFile = "ShopingCartModels.csv";
        public const string SelectedProductsFile = "SelectedProductsModels.csv";
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections()
        {
            TextConnector text = new TextConnector();
            Connection = text;
        }
            
    }

    }

