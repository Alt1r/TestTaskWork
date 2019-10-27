using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowTestTask
{
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
}
