using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;

//using System.Threading;
//using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class DisplayFeedbackMessageVisitor
    {
        private Random m_Random = new Random();
        private Timer m_Timer= new Timer(2000);
        private Random m_RandomIndex = new Random();
        private List<string> m_ListOfMessageFeedback;
        public Label LabelMessageToDisplay { get; set; }
        public int RandomIdx { get; set; }


        public DisplayFeedbackMessageVisitor(List<string> i_ListOfFeedbackMessages)
        {
            LabelMessageToDisplay = new Label();
            m_ListOfMessageFeedback = i_ListOfFeedbackMessages;
            m_Timer.Elapsed += setLabelMessage;
            m_Timer.Enabled = true;
            m_Timer.AutoReset = true;
            m_Timer.Start();
        }

        private void setLabelMessage(object sender, ElapsedEventArgs e)
        {
            RandomIdx = m_RandomIndex.Next(m_ListOfMessageFeedback.Count);
            LabelMessageToDisplay.Invoke(new Action(() => LabelMessageToDisplay.Text = m_ListOfMessageFeedback[RandomIdx]));
        }

        internal void Back(Form i_CurrentForm)
        {
            m_Timer.Stop();
            i_CurrentForm.Close();
        }
    }
}
