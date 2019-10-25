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

            ElemetsPanel panel = new ElemetsPanel();
            //var testheathpanel = new ModelHeatingPanel("0","ЩУЭ-1", "300;200", "12", "true", "0", "-1","1","0");
            
            XmlSerializer formatter = new XmlSerializer(typeof(ElemetsPanel));
            string pathXML = "input.xml";

            /*using (FileStream fs = new FileStream(pathXML, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, panel);
            }*/

            using (FileStream fs = new FileStream(pathXML, FileMode.OpenOrCreate))
            {
                ElemetsPanel newpanel = (ElemetsPanel)formatter.Deserialize(fs);
                foreach (var hp in newpanel.element.HeatingPanel)
                {
                    hp.PrintConsoleInfo("Hpanel");
                }

                foreach (var sensor in newpanel.element.Sensor)
                {
                    sensor.PrintConsoleInfo("Sensor");
                }

                foreach (var hp in newpanel.element.HeatingLine)
                {
                    hp.PrintConsoleInfo("HLine");
                }
            }
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
