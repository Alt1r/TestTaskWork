using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TestTaskLibrary.ElementsModel
{
    [Serializable]
    
    public class ModelHeatingPanel : BasicElementModel
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IsEntryAutomateOn { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IsNetworkOn { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IsPowerOn { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IsOnUps { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IsInAlarm { get; set; }

        public enum HeatingPanelState : int
        {
            Unknown = -1,
            Off,
            On
        }

        public ModelHeatingPanel() : base()
        {
        }

        public ModelHeatingPanel(string id, string name,  string location, string temperature, string isInAlarm, string isEntryAutomateOn, string isNetworkOn, string isPowerOn, string isOnUps)
        :base(id,name,temperature,location)
        {
            IsInAlarm = isInAlarm;
            IsEntryAutomateOn = isEntryAutomateOn;
            IsNetworkOn = isNetworkOn;
            IsPowerOn = isPowerOn;
            IsOnUps = isOnUps;
        }

        public override void PrintConsoleInfo(string stringIdentificator)
        {
            base.PrintConsoleInfo(stringIdentificator);
            Console.WriteLine($"IsInAlarm={IsInAlarm} IsEntryAutomatedOn={IsEntryAutomateOn} IsNetworkOn={IsNetworkOn} IsPowerOn={IsPowerOn} IsOnUps={IsOnUps}");
        }
    }
}
