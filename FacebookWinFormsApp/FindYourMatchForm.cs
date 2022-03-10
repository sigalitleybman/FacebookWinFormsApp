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
        private User m_PotentionalMatchUser;
        private string m_Gender;
        private string m_Age;
        private string m_Area;
        private string m_City;
        internal ApplicationManager ApplicationManager { get; set; }


        public FindYourMatchForm(FormMain i_FormMain)
        {
            InitializeComponent();
            r_LoggedInUser = i_FormMain.LoggedInUser;
            ApplicationManager = i_FormMain.ApplicationManager;
        }

        private void buttonCheckAnswers_Click(object sender, EventArgs e)
        {
            if(checkedListBoxGender.CheckedItems.Count != 0 && checkedListBoxAge.CheckedItems.Count != 0 &&
               !textBoxCity.Text.Equals(""))
            {
                m_City = textBoxCity.Text.ToLower();
                bool isMatchExist = ApplicationManager.checkIfThereIsMatch(m_Gender, m_Age, m_City);
                
                if (isMatchExist)
                {
                    m_PotentialMatch = ApplicationManager.GetPotentionalMatch();
                    MessageBox.Show("Your Potentional Match Is:" + Environment.NewLine +
                                    $"Name: {m_PotentialMatch.Name}" + Environment.NewLine +
                                    $"Age: {m_PotentialMatch.Age}" + Environment.NewLine +
                                    $"Gender: {m_PotentialMatch.Gender}" + Environment.NewLine +
                                    $"City: {m_PotentialMatch.City}");

                    /**
                     * In case we can get the user's friends via facebook
                     */
                    //m_PotentionalMatchUser = ApplicationManager.GetPotentionalMatchUser();
                    //int userAge = ApplicationManager.getUserAge();
                    //MessageBox.Show("Your Potentional Match Is:" + Environment.NewLine +
                    //                $"Name: {m_PotentionalMatchUser.Name}" + Environment.NewLine +
                    //                $"Age: {userAge}" + Environment.NewLine +
                    //                $"Gender: {m_PotentionalMatchUser.Gender}" + Environment.NewLine +
                    //                $"City: {m_PotentionalMatchUser.Location}");
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            BackToMainForm(); 
        }

        private void BackToMainForm()
        {
            this.Close();
        }
    }
}

