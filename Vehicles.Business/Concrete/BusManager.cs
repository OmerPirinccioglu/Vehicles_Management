using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Business.Abstract;
using Vehicles.Business.FakeData;
using Vehicles.Entities;

namespace Vehicles.Business.Concrete
{
    public class BusManager : IVehicleService<Bus>
    {
        private List<Bus> _buses;
        public BusManager()
        {
            _buses = FakeDataInsert.GetBuses();
        }
        public List<Bus> GetLists()
        {
            return _buses;
        }

        public List<Bus> GetSelectedColor(string color)
        {
            List<Bus> _busList = new List<Bus>();

            foreach (var item in _buses)
            {
                if (item.Color == color)
                {
                    _busList.Add(item);
                }

            }


            return _busList;
        }
    }
}
