using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskLibrary.ElementsModel
{
    [Serializable]
    public class ModelHeatingLine : ExtendedSubElementModel
    {
        ModelHeatingLine()
        {
        }

        ModelHeatingLine(string id, string name, string temperature, string location, string parentId, string elementState)
            : base(id, name, temperature, location, parentId, elementState)
        { }
    }
}
