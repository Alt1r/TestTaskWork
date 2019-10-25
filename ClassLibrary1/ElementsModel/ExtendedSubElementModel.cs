using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskLibrary.ElementsModel
{
    public abstract class ExtendedSubElementModel : BasicElementModel
    {
        public string ParentId { get; set; }
        public string State { get; set; }

        ExtendedSubElementModel(string id, string name, string temperature, string location, string parentId, string elementState) 
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


