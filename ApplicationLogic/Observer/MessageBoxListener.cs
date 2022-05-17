using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ApplicationLogic.Observer
{
    public class MessageBoxListener : IListener
    {
        //private string m_Feedback;
        private readonly List<INotifier> r_ListOfNotifier = new List<INotifier> { };

        public string MessageBoxFeedback { get; set; }

        public string getFeedbackMessageToDisplay()
        {
            return MessageBoxFeedback;
        }

        public void Update(string i_FeedbackToDisplay)
        {
            MessageBoxFeedback = i_FeedbackToDisplay;
        }

        /*internal string getFeedbackMessageToDisplay()
        {
            return MessageBoxFeedback;
        }*/

        //public void DisplayResults(int i_CorrectAnswers, int i_WrongAnswers)
        //{
        //    if(i_CorrectAnswers == 3)
        //    {
        //        m_Feedback = "Good Job! You Know About Your Friend Very Well";
        //    }
        //    else
        //    {
        //        m_Feedback = "You Should Know Your Friend Better";
        //    }

        //    MessageBoxFeedback = m_Feedback + "You Answered " + i_CorrectAnswers + " Correct Answers! And " +  
        //        i_WrongAnswers + " Wrong Answers!";

        //    //return m_MessageBoxFeedback;
        //}

    }
}
