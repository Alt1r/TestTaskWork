using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TestTaskLibrary.ElementsModel
{
    [Serializable]
    [XmlRoot("Elements")]
    public class Elements
    {
        [XmlElement("HeatingPanel")]
        public ModelHeatingPanel[] HeatingPanel;
        [XmlElement("Sensor")]
        public ModelSensor[] Sensor;
        [XmlElement("HeatingLine")]
        public ModelHeatingLine[] HeatingLine;

        //public ModelHeatingPanel HeatingPanel = new ModelHeatingPanel("0", "ЩУЭ-1", "300;200", "12", "true", "0", "-1", "1", "0");

        public Elements()
        {
        }
    }
}
