using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowTestTask
{
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
                    Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))),
                        ((int)(((byte)(80)))),
                        ((int)(((byte)(80)))));
                    break;
                default:
                    base.SetColorView(color);
                    break;
            }
        }
    }
}
