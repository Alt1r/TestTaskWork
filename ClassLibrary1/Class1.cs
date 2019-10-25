using System;
using System.Runtime.CompilerServices;

namespace TestTaskLibrary
{
    public interface IHeatingModel
    {
        int Id { get; set; }
        string Name { get; set; }
        double Temperature { get; set; }
    }

    public class ModelHeatingPanel : IHeatingModel
    {
        public int Id { get; set; }

        int IsEntryAutomateOn { get; set; }
        int IsNetworkOn { get; set; }
        int IsPowerOn { get; set; }
        int IsPoIsOnUpswerOn { get; set; }

        public string Name { get; set; }
        public double Temperature { get; set; }

        public enum Location : int
        {
            X,
            Y
        };

        public Boolean IsInAlarm { get; set; }
        
        

    }
}
