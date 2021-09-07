using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Models;

namespace OnlineShop
{
    public interface ICategoryRequester
    {
        void CategoryComplete(CategoryModel model);
    }
}
