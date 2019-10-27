using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowTestTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    abstract class BasicNonContainerView : DevExpress.XtraDiagram.DiagramShape
    {
        protected BasicNonContainerView()
        {
        }


        protected BasicNonContainerView(string textOnDisplay, string stateOfShape, float locationX, float locationY)
        {
            // зависимые от входных данных
            SetColorView(stateOfShape);
            Position = new DevExpress.Utils.PointFloat(locationX, locationY);
            Content = textOnDisplay;
            //постоянные для всех потомков
            ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            Size = new System.Drawing.SizeF(80F, 50F);
            StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
        }

        protected virtual void SetColorView(string color)
        {
            switch (color)
            {
                case "Warning":
                    Appearance.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))),
                        ((int) (((byte) (255)))),
                        ((int) (((byte) (0)))));
                    break;
                case "Alarm":
                    Appearance.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))),
                        ((int) (((byte) (0)))),
                        ((int) (((byte) (0)))));
                    break;

                default:
                    Appearance.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))),
                        ((int) (((byte) (255)))),
                        ((int) (((byte) (255)))));
                    break;
            }
        }
    }

     class ViewSensor : BasicNonContainerView
    {
        internal ViewSensor(string textOnDisplay, string stateOfShape, float locationX, float locationY)
        :base(textOnDisplay,  stateOfShape,  locationX,  locationY)
        {
            Shape= DevExpress.Diagram.Core.BasicShapes.RoundedRectangle;
        }

        protected override void SetColorView(string color)
        {
            switch (color)
            {
                case "GoodOrOff":
                    Appearance.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))),
                        ((int) (((byte) (150)))),
                        ((int) (((byte) (0)))));
                    break;
                default:
                    base.SetColorView(color);
                    break;
            }
        }

    }

     class ViewHeatingLine : BasicNonContainerView
     {
         internal ViewHeatingLine(string textOnDisplay, string stateOfShape, float locationX, float locationY)
             : base(textOnDisplay, stateOfShape, locationX, locationY)
         {
         }

         protected override void SetColorView(string color)
         {
             switch (color)
             {
                 case "GoodOrOff":
                     Appearance.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (80)))),
                         ((int) (((byte) (80)))),
                         ((int) (((byte) (80)))));
                     break;
                 default:
                     base.SetColorView(color);
                     break;
             }
         }
     }

     class ViewAlarmOnContainer : BasicNonContainerView
     {
         internal ViewAlarmOnContainer(float locationX, float locationY)
             : base("Авария", "Alarm", locationX, locationY)
         {
             
         }
     }

     class ViewContainerStatus : DevExpress.XtraDiagram.DiagramShape
     {
         internal ViewContainerStatus(string status, float locationX, float locationY)
         {
             // меняется для индикаторов статуса
             SetColorView(status);
             Position = new DevExpress.Utils.PointFloat(locationX, locationY);
             // стандартные для всех индикаторов статуса
             Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse;
             Size = new System.Drawing.SizeF(15F, 15F);
             StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
        }

         protected virtual void SetColorView(string color)
         {
             switch (color)
             {
                 case "-1":
                     Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))),
                         ((int)(((byte)(160)))),
                         ((int)(((byte)(160)))));
                     break;
                 case "0":
                    Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))),
                        ((int)(((byte)(0)))),
                        ((int)(((byte)(0)))));
                    break;
                case "1":
                     Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))),
                         ((int)(((byte)(150)))),
                         ((int)(((byte)(0)))));
                     break;
                default:
                    Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))),
                        ((int)(((byte)(255)))),
                        ((int)(((byte)(255)))));
                    break;
            }
        }
     }

     class ViewContainerText : DevExpress.XtraDiagram.DiagramShape
     {
         protected float elementSizeWidth = 95F;
         internal float elementSizeHeight = 15F;

         internal ViewContainerText(string text, float locationX, float locationY)
         {
             // меняется для текста контейнера
             Content = text;
             Position = new DevExpress.Utils.PointFloat(locationX, locationY);
            // Постоянные текста в контейнере
            Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
             Size = new System.Drawing.SizeF(elementSizeWidth, elementSizeHeight);
             StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Accent1;
            
         }
     }

     class ViewContainerTextWithSatus : ViewContainerText
     {
         internal ViewContainerStatus statusTextView;
         internal ViewContainerTextWithSatus(string text, string status, float locationX, float locationY)
         : base(text, locationX, locationY)
         {
             // добавить индикатор статуса
             statusTextView = new ViewContainerStatus(status, elementSizeWidth + locationX, locationY);
        }
     }

     class ViewContainerHeatingPanel : DevExpress.XtraDiagram.DiagramContainer
     {
        //protected string[] parametrsName = new string[] {"Вв. автомат", "Связь", "Питание", "На ИБП"};
        //protected List<ViewContainerTextWithSatus> TextWithStatus = new List<ViewContainerTextWithSatus>();
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
            var automatedStatus = new ViewContainerTextWithSatus("Вв. автомат",isEntryAutomated, 
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
                var alarmStatus = new ViewAlarmOnContainer(25F, GetNextLocationY()+10);
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
            float locationY = CountElements * ElementSize + StartLocationElementY ;
            CountElements++;
            return locationY;
        }
     }
}
