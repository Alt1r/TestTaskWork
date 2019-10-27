using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowTestTask
{
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
}
