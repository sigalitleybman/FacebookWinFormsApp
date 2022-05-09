using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic.Observer
{
    internal class Notifier
    {
        private readonly List<IListener> r_ListOfListeners = new List<IListener> { };
        private int m_CorrectAnswers;
        private int m_WrongAnswers;

        internal void addListener(IListener i_Listener)
        {
            r_ListOfListeners.Add(i_Listener);
        }

        internal void removeListener(IListener i_Listener)
        {
            r_ListOfListeners.Remove(i_Listener);
        }

        //internal void displayResults(int i_NumOfCorrectAnswers, int i_NumOfWrongAnswers)
        //{
        //    //string feedback;
        //    m_CorrectAnswers = i_NumOfCorrectAnswers;
        //    m_WrongAnswers = i_NumOfWrongAnswers;

        //    foreach(IListener listener in r_ListOfListeners)
        //    {
        //        listener.DisplayResults(m_CorrectAnswers, m_WrongAnswers);
        //    }

        //}

        internal void update(string i_FeedbackToDisplay)
        {
            foreach (IListener listener in r_ListOfListeners)
            {
                listener.Update(i_FeedbackToDisplay);
            }
        }

    }
}
