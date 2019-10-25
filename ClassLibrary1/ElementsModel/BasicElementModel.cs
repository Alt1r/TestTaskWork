using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskLibrary.ElementsModel
{
    public abstract class BasicElementModel
    {
        string Id { get; set; }
        string Name { get; set; }
        string Temperature { get; set; }
        int LocationX { get; set; }
        int LocationY { get; set; }

        protected BasicElementModel(string id, string name, string temperature, string location)
        {
            Id = id;
            Name = name;
            Temperature = temperature;
            LocationX = int.Parse(location.Split(new char[] { ';' })[0]);
            LocationY = int.Parse(location.Split(new char[] { ';' })[1]);

        }

        public virtual void PrintConsoleInfo(string StringIdentificator)
        {
            Console.WriteLine($"Hi I'm {StringIdentificator}! Look at this:");
            Console.WriteLine($"ID={Id} Name ={Name} Temperature={Temperature} X={LocationX} Y={LocationY}");
        }


    }
}
