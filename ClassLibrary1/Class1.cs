using System;
using System.Runtime.CompilerServices;

namespace TestTaskLibrary
{
    public abstract class BasicPanelModel
    {
        int Id { get; set; }
        string Name { get; set; }
        string Temperature { get; set; }
        public enum Location : int
        {
            X,
            Y
        };
    }

    public abstract class ElementsPanel : BasicPanelModel
    {
        public int ParentId { get; set; }
        public string State { get; set; }
    }

    public class ModelHeatingPanel : BasicPanelModel
    {
        int IsEntryAutomateOn { get; set; }
        int IsNetworkOn { get; set; }
        int IsPowerOn { get; set; }
        int IsOnUps { get; set; }

        public Boolean IsInAlarm { get; set; }

        public enum State : int
        {
            Unknown = -1,
            Off,
            On
        }
    }

    public class ModelSensor : ElementsPanel
    {
    }

    public class ModelHeatingLine : ElementsPanel
    {
    }

}
