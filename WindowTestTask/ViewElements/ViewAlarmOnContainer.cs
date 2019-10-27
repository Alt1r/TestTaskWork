using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowTestTask
{
    class ViewAlarmOnContainer : BasicNonContainerView
    {
        internal ViewAlarmOnContainer(float locationX, float locationY)
            : base("Авария", "Alarm", locationX, locationY)
        {

        }
    }
}
