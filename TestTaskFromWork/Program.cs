using System;
using System.IO;
using System.Xml.Serialization;
using TestTaskLibrary.ElementsModel;
using TestTaskLibrary;


namespace TestTaskFromWork
{
    class Program
    {
        static void Main(string[] args)
        {

            Model newmodel = new Model("input.xml");
            foreach (var hp in newmodel.Diagram.element.HeatingPanel)
            {
                hp.PrintConsoleInfo("Hpanel");
            }

            foreach (var sensor in newmodel.Diagram.element.Sensor)
            {
                sensor.PrintConsoleInfo("Sensor");
            }

            foreach (var hp in newmodel.Diagram.element.HeatingLine)
            {
                hp.PrintConsoleInfo("HLine");
            }
            

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
