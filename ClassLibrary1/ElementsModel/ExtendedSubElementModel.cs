using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskLibrary.ElementsModel
{
    public abstract class ExtendedSubElementModel : BasicElementModel
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParentId { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string State { get; set; }

        protected ExtendedSubElementModel()
        {
        }

        protected ExtendedSubElementModel(string id, string name, string location, string temperature,  string parentId, string elementState) 
            : base(id, name, temperature, location)
        {
            ParentId = parentId;
            State = elementState;
        }



        public override void PrintConsoleInfo(string StringIdentificator)
        {
            base.PrintConsoleInfo(StringIdentificator);
            Console.WriteLine($"ParentId={ParentId} State={State}");
        }


    }
}


