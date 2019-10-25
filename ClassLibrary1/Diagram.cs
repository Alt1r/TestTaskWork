using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using TestTaskLibrary.ElementsModel;

namespace TestTaskLibrary
{
    [Serializable]
    [XmlRoot("Diagram")]
    public class Diagram
    {
        [XmlElement("Elements")] public Elements element = new Elements();


        [Serializable]
        public class Elements
        {
            [XmlElement("HeatingPanel")] public ModelHeatingPanel[] HeatingPanel;
            [XmlElement("Sensor")] public ModelSensor[] Sensor;
            [XmlElement("HeatingLine")] public ModelHeatingLine[] HeatingLine;

            //public ModelHeatingPanel HeatingPanel = new ModelHeatingPanel("0", "ЩУЭ-1", "300;200", "12", "true", "0", "-1", "1", "0");

            public Elements()
            {
            }
        }


    }
}
