using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
         ViewAlarmOnContainer(float locationX, float locationY)
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
                     Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))),
                         ((int)(((byte)(80)))),
                         ((int)(((byte)(80)))));
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
         private float elementSizeWidth = 100F;
         private float elementSizeHeight = 15F;

         internal ViewContainerText(string text, string status, float locationX, float locationY)
         {
             // меняется для текста контейнера
             Content = text;
             Position = new DevExpress.Utils.PointFloat(locationX, locationY);
             // Постоянные текста в контейнере
             ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
             Size = new System.Drawing.SizeF(elementSizeWidth, elementSizeHeight);
             StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Accent1;
            // добавить индикатор статуса
            ViewContainerStatus statusText = new ViewContainerStatus(status, elementSizeWidth + locationX, locationY);
         }
     }
}
