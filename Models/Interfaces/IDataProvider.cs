using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chiropractic.Models
{
    interface IDataProvider
    {
        User GetUser(int Id);
    }
}
