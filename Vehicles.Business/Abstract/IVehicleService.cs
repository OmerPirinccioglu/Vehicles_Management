using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Business.Abstract
{
    public interface IVehicleService<T> where T : class
    {
        List<T> GetLists();
        List<T> GetSelectedColor(string color);

    }
}
