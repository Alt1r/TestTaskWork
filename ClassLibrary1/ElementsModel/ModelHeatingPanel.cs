using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskLibrary.ElementsModel
{
    [Serializable]
    public class ModelHeatingPanel : BasicElementModel
    {
        public string IsEntryAutomateOn { get; set; }
        public string IsNetworkOn { get; set; }
        public string IsPowerOn { get; set; }
        public string IsOnUps { get; set; }

        public Boolean IsInAlarm { get; set; }

        public enum HeatingPanelState : int
        {
            Unknown = -1,
            Off,
            On
        }

        public ModelHeatingPanel(string )
        {

        }
    }
}
