using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowTestTask
{
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
}
