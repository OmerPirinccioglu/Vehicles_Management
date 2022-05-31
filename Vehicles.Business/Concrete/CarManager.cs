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
    public class CarManager : ICarService
    {
        private List<Car> _cars;
        public CarManager()
        {
             _cars = FakeDataInsert.GetCars();
        }
        public List<Car> GetLists()
        {
            return _cars;
        }

        public List<Car> GetSelectedColor(string color)
        {
            List<Car> _carList = new List<Car>();

            foreach (var item in _cars)
            {
                if (item.Color == color)
                {
                    _carList.Add(item);
                }
            }

            return _carList;
        }
        public Car HeadLight(Car car)
        {
            var headLight = _cars.FirstOrDefault(x => x.Id == car.Id);
            headLight.Headlight = car.Headlight;
            return car;
        }
        public void Delete(int id)
        {
            var deletedCar = _cars.FirstOrDefault(x => x.Id == id);
            _cars.Remove(deletedCar);
        }
    }
}
