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
        private readonly List<INotifier> r_ListOfNotifier = new List<INotifier> { };

        public string MessageBoxFeedback { get; set; }

        public string GetFeedbackMessageToDisplay()
        {
            return MessageBoxFeedback;
        }

        public void Update(string i_FeedbackToDisplay)
        {
            MessageBoxFeedback = i_FeedbackToDisplay;
        }
    }
}
