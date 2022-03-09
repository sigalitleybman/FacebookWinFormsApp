using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationLogic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FindYourMatchForm : Form
    {
        private readonly User r_LoggedInUser;
        private FictionUsers m_PotentialMatch;
        private string m_Gender;
        private string m_Age;
        private string m_Area;
        internal ApplicationManager ApplicationManager { get; set; }


        public FindYourMatchForm(FormMain i_FormMain)
        {
            InitializeComponent();
            r_LoggedInUser = i_FormMain.LoggedInUser;
            ApplicationManager = i_FormMain.ApplicationManager;
        }

        private void buttonCheckAnswers_Click(object sender, EventArgs e)
        {
            /*string gender;
            string age;
            string area;
            bool isMatchExist;*/

            if (checkedListBoxGender.CheckedItems.Count != 0 && checkedListBoxAge.CheckedItems.Count != 0
                && checkedListBoxArea.CheckedItems.Count != 0)
            {
                /*m_Gender = checkedListBoxGender.SelectedItem.ToString();
                m_Age = checkedListBoxAge.SelectedItem.ToString();
                m_Area = checkedListBoxArea.SelectedItem.ToString();*/

                bool isMatchExist = ApplicationManager.checkIfThereIsMatch(m_Gender, m_Age, m_Area);
                if (isMatchExist)
                {
                    m_PotentialMatch = ApplicationManager.GetPotentionalMatch();
                    /*MessageBox.Show("Your Potentional Match Is:" + System.Environment.NewLine + String.Format("Name: {0} Age: {1} Gender: {2} City: {3}",
                        m_PotentialMatch.Name,
                        System.Environment.NewLine,
                        m_PotentialMatch.Age,
                        System.Environment.NewLine,
                        m_PotentialMatch.Gender,
                        System.Environment.NewLine,
                        m_PotentialMatch.City));*/
                    MessageBox.Show("Your Potentional Match Is:" + Environment.NewLine +
                        $"Name: {m_PotentialMatch.Name}" + Environment.NewLine +
                        $"Age: {m_PotentialMatch.Age}" + Environment.NewLine +
                        $"Gender: {m_PotentialMatch.Gender}" + Environment.NewLine +
                        $"City: {m_PotentialMatch.City}");
                }
                else
                {
                    MessageBox.Show("Sorry, we can't find a match for you");
                }

            }
            else
            {
                MessageBox.Show("You should check all the three preferences");
            }
        }

        private void checkedListBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_Gender = (sender as CheckedListBox).SelectedItem.ToString();
            makeTheOtherCheckBoxOptionsEnabled(sender);
        }

        private void checkedListBoxAge_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            m_Age = (sender as CheckedListBox).SelectedItem.ToString();
            makeTheOtherCheckBoxOptionsEnabled(sender);
        }

        private void checkedListBoxArea_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            m_Area = (sender as CheckedListBox).SelectedItem.ToString();
            makeTheOtherCheckBoxOptionsEnabled(sender);
        }

        private void makeTheOtherCheckBoxOptionsEnabled(object i_Sender)
        {
            CheckedListBox currentCheckedListBox = i_Sender as CheckedListBox;

            if (currentCheckedListBox != null)
            {
                int indexOfChosenCheckBox = currentCheckedListBox.SelectedIndex;
                int countCheckBox = currentCheckedListBox.Items.Count;

                for (int i = 0; i < countCheckBox; i++)
                {
                    if (indexOfChosenCheckBox != i)
                    {
                        currentCheckedListBox.SetItemChecked(i, false);
                    }
                }
            }
        }

    }
}

