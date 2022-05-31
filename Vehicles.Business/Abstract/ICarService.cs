using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Entities;

namespace Vehicles.Business.Abstract
{
    public interface ICarService:IVehicleService<Car>
    {
        Car HeadLight(Car car);
        void Delete(int id);
    }
}
