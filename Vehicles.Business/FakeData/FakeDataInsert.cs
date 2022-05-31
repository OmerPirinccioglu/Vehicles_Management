using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Entities;

namespace Vehicles.Business.FakeData
{
    public class FakeDataInsert
    {
       
            private static List<Car> _cars;
            private static List<Bus> _buses;
            private static List<Boat> _boats;



            public enum Colors
            {
                red = 1,
                blue = 2,
                black = 3,
                white = 4
            }

            public static List<Car> GetCars()
            {
                if (_cars == null)
                {
                    _cars = new Faker<Car>()
                           .RuleFor(x => x.Id, f => f.IndexFaker)
                           .RuleFor(x => x.Headlight, f => f.Random.Bool())
                           .RuleFor(x => x.Wheel, f => f.Random.Bool())
                           .RuleFor(x => x.Color, f => f.PickRandom<Colors>().ToString())
                           .Generate(10);

                }


                return _cars;

            }
            public static List<Bus> GetBuses()
            {
                if (_buses == null)
                {
                    _buses = new Faker<Bus>()
                         .RuleFor(x => x.Id, f => f.IndexFaker)
                         .RuleFor(x => x.Color, f => f.PickRandom<Colors>().ToString())
                         .Generate(10);
                }

                return _buses;
            }
            public static List<Boat> GetBoats()
            {
                if (_boats == null)
                {
                    _boats = new Faker<Boat>()
                         .RuleFor(x => x.Id, f => f.IndexFaker)
                         .RuleFor(x => x.Color, f => f.PickRandom<Colors>().ToString())
                         .Generate(10);
                }

                return _boats;
            }

        }
    }
