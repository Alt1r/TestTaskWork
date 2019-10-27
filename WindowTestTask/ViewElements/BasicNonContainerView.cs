using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowTestTask
{
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
                    Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))),
                        ((int)(((byte)(255)))),
                        ((int)(((byte)(0)))));
                    break;
                case "Alarm":
                    Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))),
                        ((int)(((byte)(0)))),
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
}
