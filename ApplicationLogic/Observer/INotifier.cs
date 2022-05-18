using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic.Observer
{
    internal interface INotifier
    {
        void AddListener(IListener i_Listener);

        void RemoveListener(IListener i_Listener);

        void NotifyAll(string i_FeedbackToDisplay);
    }
}
