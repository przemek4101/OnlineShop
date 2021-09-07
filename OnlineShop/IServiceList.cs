using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public interface IServiceList
    {
        bool ValidatedForm();

        void WireUpLists();
    }
}
