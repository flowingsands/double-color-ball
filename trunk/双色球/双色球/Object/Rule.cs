
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Lottery
{
    class IntCompare : System.Collections.IComparer
    {

        public int Compare(object x, object y)
        {
            return (int)x - (int)y;
        }

    } 

    public class AwardNumber
    {
        private ArrayList[] ball;

        public AwardNumber()
        {   
            ball = new ArrayList[3] { new ArrayList(), /* 源串号码 */
                                      new ArrayList(), /* 中奖号码 */
                                      new ArrayList()  /* 源串有几个中奖号码 */
                                    };
        }

        public void Anlysis(string number1, string number2)
        {
            SetValue(number1, number2);
            Anlysis();
        }
        private void SetValue(string number1, string number2)
        {
            string[] numberArray1 = number1.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string[] numberArray2 = number2.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string number in numberArray1)
            {
                ball[0].Add(Convert.ToInt32(number));
            }
            foreach (string number in numberArray2)
            {
                ball[1].Add(Convert.ToInt32(number));
            }
        }

        private void Anlysis()
        {
            foreach (int number in ball[1])
            {
                if (ball[0].Contains(number))
                {
                    ball[2].Add(number);
                }
            }
        }

        public string GetResult()
        {
            string result = string.Empty;
            int j = 0;
            foreach (int number in ball[2])
            {
                if (j++ == 0)
                    result += string.Format("{0:D2}", number);
                else
                    result += string.Format(" {0:D2}", number);

            }
            return result;
        }

        public int GetCount()
        {
            return ball[2].Count;
        }
    }

    public class RangeNumber
    {
        private ArrayList[] redData;

        public enum ActionTypeEnum
        {
            First, 
            Second,  
            Third,    
            Fourth,
            Fifth,
        }

        public RangeNumber()
        {
            redData = new ArrayList[]{ new ArrayList(), /* 待统计数字字符串 */
                                       new ArrayList(), /* 区间1: 01-03 */
                                       new ArrayList(), /* 区间2: 04-07 */
                                       new ArrayList(), /* 区间3: 08-12 */
                                       new ArrayList(), /* 区间4: 13-20 */
                                       new ArrayList()  /* 区间5: 21-33 */
                                    };
        }

        public void Anlysis(string number)
        {
            Set(number);
            Anlysis();
        }

        private void Set(string number1)
        {
            string[] numberArray1 = number1.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
  
            foreach (string number in numberArray1)
            {
                Int32 num = Convert.ToInt32(number);
                if (redData[0].IndexOf(num) < 0)              
                {
                    redData[0].Add(num);
                }
            }
            redData[0].Sort(new IntCompare());
        }

        private void Anlysis()
        {
            foreach (int number in redData[0])
            {
                switch (number)
                {
                    case 1:
                    case 2:
                    case 3:
                        redData[1].Add(number);
                        break;

                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        redData[2].Add(number);
                        break;

                    case 8:
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                        redData[3].Add(number);
                        break;
     
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                    case 20:
                        redData[4].Add(number);
                        break;


                    case 21:
                    case 22:
                    case 23:
                    case 24:
                    case 25:
                    case 26:
                    case 27:
                    case 28:
                    case 29:
                    case 30:
                    case 31:
                    case 32:
                    case 33:
                        redData[5].Add(number);
                        break;
                }
            }
        }

        public string[] GetResult()
        {
            string[] rutString = new string[6];

            for( int i = 0; i < 6; i++ )
            {
                rutString[i] = GetRedData(i);
            }
            return rutString;
        }

        private string GetRedData(int i)
        {
            string result = string.Empty;
            int j = 0;
            foreach (int number in redData[i])
            {
                if (j++ == 0)
                    result += string.Format("{0:D2}", number);
                else
                    result += string.Format(" {0:D2}", number);

            }
            return result;
        }

        public int[] GetCount()
        {
            int[] rutInt = new int[5];
            for (int i = 1; i < 6; i++)
            {
                rutInt[i - 1] = redData[i].Count;
            }

            return rutInt;
        }

        

    }

    public class LastFiveNumber
    {
        private LastFiveDataIssue lastFiveData;
        private string strLasvFiveResult = string.Empty;   /*　有重复的五期数字字串  */

        public LastFiveNumber(LastFiveDataIssue objLastFive)
        {
            lastFiveData = objLastFive;
        }

        public LastFiveDataIssue Anlysis()
        {
            // first

            // second
            
            // third

            return lastFiveData;
        }

        private void AnlysisLastFiveResult()
        {   
            strLasvFiveResult = lastFiveData.LastLotIssue1 + lastFiveData.LastLotIssue2 + lastFiveData.LastLotIssue3 + lastFiveData.LastLotIssue4 + lastFiveData.LastLotIssue5;

            string[] numberArray1 = strLasvFiveResult.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string number in numberArray1)
            {
                Int32 num = Convert.ToInt32(number);
                /*
                if (redData[0].IndexOf(num) < 0)
                {
                    redData[0].Add(num);
                }
                */
            }
            //redData[0].Sort(new IntCompare());
 
        }


    }
}
