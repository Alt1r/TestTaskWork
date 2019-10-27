using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowTestTask
{
    class ViewSensor : BasicNonContainerView
    {
        internal ViewSensor(string textOnDisplay, string stateOfShape, float locationX, float locationY)
            : base(textOnDisplay, stateOfShape, locationX, locationY)
        {
            Shape = DevExpress.Diagram.Core.BasicShapes.RoundedRectangle;
        }

        protected override void SetColorView(string color)
        {
            switch (color)
            {
                case "GoodOrOff":
                    Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))),
                        ((int)(((byte)(150)))),
                        ((int)(((byte)(0)))));
                    break;
                default:
                    base.SetColorView(color);
                    break;
            }
        }
    }
}
