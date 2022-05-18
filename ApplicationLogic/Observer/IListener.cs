using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic.Observer
{
    internal interface IListener
    {
        string MessageBoxFeedback { get; set; }

        void Update(string i_FeedbackToDisplay);
        string GetFeedbackMessageToDisplay();
    }
}
