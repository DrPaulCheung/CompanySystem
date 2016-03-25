using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace TempSys
{
    class TransitionAnimationFac
    {
        public static void swipIn(Control node,int time,  int offset,string direct = "Left")
        {
            Transition transasition = new Transitions.Transition(new TransitionType_EaseInEaseOut(time));
            transasition.add(node, direct, offset);
            transasition.run();
        }

        public static void swipOut(Control node, int time, int offset, string direct = "Left")
        {
            Transition transasition = new Transitions.Transition(new TransitionType_EaseInEaseOut(time));
            transasition.add(node, direct, offset);
            transasition.run();
        }
    }
}
