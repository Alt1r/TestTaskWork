using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskLibrary.ElementsModel
{
    [Serializable]
    public class ModelSensor : ExtendedSubElementModel
    {
        ModelSensor()
        {
        }

        ModelSensor(string id, string name, string temperature, string location, string parentId, string elementState)
        :base(id,name,temperature,location,parentId,elementState)
        { }
    }
}
