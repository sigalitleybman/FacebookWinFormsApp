using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic.Observer
{
    internal class TriviaFormNotifier : INotifier
    {
        private readonly List<IListener> r_ListOfListeners = new List<IListener> { };

        public void addListener(IListener i_Listener)
        {
            r_ListOfListeners.Add(i_Listener);
        }

        public void notifyAll(string i_FeedbackToDisplay)
        {
            foreach (IListener listener in r_ListOfListeners)
            {
                listener.Update(i_FeedbackToDisplay);
            }
        }

        public void removeListener(IListener i_Listener)
        {
            r_ListOfListeners.Remove(i_Listener);
        }
    }
}
