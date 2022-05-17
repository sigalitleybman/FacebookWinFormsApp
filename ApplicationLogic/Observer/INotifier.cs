using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic.Observer
{
    internal interface INotifier
    {
        void addListener(IListener i_Listener);

        void removeListener(IListener i_Listener);

        void notifyAll(string i_FeedbackToDisplay);
    }
}
