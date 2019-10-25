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
    public class ElemetsPanel
    {
        
       
        [XmlElement("Elements")]
        public Elements element = new Elements();
        /*public List<BasicElementModel> ElemetsList = new List<BasicElementModel>();
        XmlSerializer formatter = new XmlSerializer(typeof(BasicElementModel[]));*/


    }
}
