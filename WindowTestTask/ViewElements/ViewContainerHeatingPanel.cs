using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowTestTask
{
    class ViewContainerHeatingPanel : DevExpress.XtraDiagram.DiagramContainer
    {
        protected float StartLocationElementX = 10F;
        protected float StartLocationElementY = 28F;
        protected float ElementSize;
        protected int CountElements = 0;
        protected float ContainerWidth = 130F;
        protected float ContainerHeight = 180F;

        internal ViewContainerHeatingPanel(float locationX, float locationY, string isEntryAutomated,
            string isInNetwork, string isPowerOn, string isOnUps, string name, string temperature, string alarm)
        {
            var namePanel = new ViewContainerText(name, 25F, 8F);
            namePanel.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            ElementSize = namePanel.elementSizeHeight;
            var automatedStatus = new ViewContainerTextWithSatus("Вв. автомат", isEntryAutomated,
                StartLocationElementX, GetNextLocationY());
            var networkStatus = new ViewContainerTextWithSatus("Связь", isInNetwork,
                StartLocationElementX, GetNextLocationY());
            var powerStatus = new ViewContainerTextWithSatus("Питание", isPowerOn,
                StartLocationElementX, GetNextLocationY());
            var upsStatus = new ViewContainerTextWithSatus("На ИБП", isOnUps,
                StartLocationElementX, GetNextLocationY());
            var temperatureStatus = new ViewContainerText($"Темп. {temperature} °C", StartLocationElementX, GetNextLocationY());

            if (alarm == "true")
            {
                var alarmStatus = new ViewAlarmOnContainer(25F, GetNextLocationY() + 10);
                Items.Add(alarmStatus);
            }

            Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[]
                {
                    namePanel,
                    automatedStatus,
                    networkStatus,
                    powerStatus,
                    upsStatus,
                    automatedStatus.statusTextView,
                    networkStatus.statusTextView,
                    powerStatus.statusTextView,
                    upsStatus.statusTextView,
                    temperatureStatus,
            });
            Position = new DevExpress.Utils.PointFloat(locationX, locationY);

            // постоянные для всех контейнеров этого типа
            BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Accent1;
            Shape = DevExpress.Diagram.Core.StandardContainers.Alternating;
            Size = new System.Drawing.SizeF(ContainerWidth, ContainerHeight);
            StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
        }

        private float GetNextLocationY()
        {
            float locationY = CountElements * ElementSize + StartLocationElementY;
            CountElements++;
            return locationY;
        }
    }
}
