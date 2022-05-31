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
    public class BoatManager : IVehicleService<Boat>
    {
        private List<Boat> _boats;
        public BoatManager()
        {
            _boats = FakeDataInsert.GetBoats();
        }
        public List<Boat> GetLists()
        {
            return _boats;
        }

        public List<Boat> GetSelectedColor(string color)
        {
            List<Boat> _boatList = new List<Boat>();

            foreach (var item in _boats)
            {
                if (item.Color == color)
                {
                    _boatList.Add(item);
                }

            }


            return _boatList;
        }
    }
}
