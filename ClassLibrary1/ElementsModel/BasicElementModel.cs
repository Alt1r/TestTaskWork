using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskLibrary.ElementsModel
{

    public abstract class BasicElementModel
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Temperature { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Location { get; set; }

        int LocationX { get; set; }
        int LocationY { get; set; }

        protected BasicElementModel()
        {
        }

        protected BasicElementModel(string id, string name, string temperature, string location)
        {
            Id = id;
            Name = name;
            Temperature = temperature;
            Location = location;
            /*LocationX = int.Parse(location.Split(new char[] { ';' })[0]);
            LocationY = int.Parse(location.Split(new char[] { ';' })[1]);
            */
        }

        public virtual void PrintConsoleInfo(string StringIdentificator)
        {
            Console.WriteLine($"Hi I'm {StringIdentificator}_{Id}! Look at this:");
            Console.WriteLine($"ID={Id} Name ={Name} Temperature={Temperature} Location={Location}");
        }


    }
}
