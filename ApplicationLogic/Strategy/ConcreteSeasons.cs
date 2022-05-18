using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic.Stretegy
{
    internal class ConcreteSeasons
    {
        internal class MonthOfSummerSeason : ISeasoneFilter
        {
            public bool CheckIfMonthMatch(string birthMonth)
            {
                bool isSummerMonth = false;
                eBirthMonth eBirthMonth = (eBirthMonth)Enum.Parse(typeof(eBirthMonth), birthMonth);

                switch (eBirthMonth) {
                    case eBirthMonth.April:
                        isSummerMonth = true;
                        break;
                    case eBirthMonth.May:
                        isSummerMonth = true;
                        break;
                    case eBirthMonth.June:
                        isSummerMonth = true;
                        break;
                    case eBirthMonth.July:
                        isSummerMonth = true;
                        break;
                    case eBirthMonth.August:
                        isSummerMonth = true;
                        break;
                    case eBirthMonth.September:
                        isSummerMonth = true;
                        break;
                }

                return isSummerMonth;
            }
        }

        internal class MonthOfWinterSeason : ISeasoneFilter
        {
            public bool CheckIfMonthMatch(string birthMonth)
            {
                bool isWinterMonth = false;
                eBirthMonth eBirthMonth = (eBirthMonth)Enum.Parse(typeof(eBirthMonth), birthMonth);

                switch (eBirthMonth)
                {
                    case eBirthMonth.January:
                        isWinterMonth = true;
                        break;
                    case eBirthMonth.February:
                        isWinterMonth = true;
                        break;
                    case eBirthMonth.March:
                        isWinterMonth = true;
                        break;
                    case eBirthMonth.October:
                        isWinterMonth = true;
                        break;
                    case eBirthMonth.November:
                        isWinterMonth = true;
                        break;
                    case eBirthMonth.December:
                        isWinterMonth = true;
                        break;
                }

                return isWinterMonth;
            }
        }
    }
}
