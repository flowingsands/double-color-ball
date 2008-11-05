
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

        public void Anlysis(string number, string awardResult)
        {

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
        private LastFiveDataIssue objLastFiveData;
        private string strLasvFiveResult = string.Empty;   /*　有重复的五期数字字串  */

        public LastFiveNumber(LastFiveDataIssue objLastFive)
        {
            objLastFiveData = objLastFive;
        }

        public LastFiveDataIssue Anlysis()
        {
            // 分析前面五期的中奖号码
            AnlysisCountIssue();

            // second
            AnlysisRange();

            // third

            return objLastFiveData;
        }
               
        #region CountLastFive
        private void AnlysisCountIssue()
        {
            AnlysisCountLastFirstIssue();
            AnlysisCountLastSecondIssue();
            AnlysisCountLastThirdIssue();
            AnlysisCountLastFourthIssue();
            AnlysisCountLastFifthIssue();
        }

        private void AnlysisCountLastFirstIssue()
        {
            AwardNumber number = new AwardNumber();
            number.Anlysis(objLastFiveData.LastRedResult1, objLastFiveData.RedResult);
            objLastFiveData.LastCountRedResult1 = number.GetResult();
            objLastFiveData.LastCountResult1    = number.GetCount();
        }

        private void AnlysisCountLastSecondIssue()
        {
            AwardNumber number = new AwardNumber();
            number.Anlysis(objLastFiveData.LastRedResult1 + objLastFiveData.LastRedResult2, objLastFiveData.RedResult);
            objLastFiveData.LastCountRedResult2 = number.GetResult();
            objLastFiveData.LastCountResult2 = number.GetCount();
        }

        private void AnlysisCountLastThirdIssue()
        {
            AwardNumber number = new AwardNumber();
            number.Anlysis(objLastFiveData.LastRedResult1 + objLastFiveData.LastRedResult2 + objLastFiveData.LastRedResult3, objLastFiveData.RedResult);
            objLastFiveData.LastCountRedResult3 = number.GetResult();
            objLastFiveData.LastCountResult3 = number.GetCount();
        }
        private void AnlysisCountLastFourthIssue()
        {
            AwardNumber number = new AwardNumber();
            number.Anlysis(objLastFiveData.LastRedResult1 + objLastFiveData.LastRedResult2 + objLastFiveData.LastRedResult3 + objLastFiveData.LastRedResult4, objLastFiveData.RedResult);
            objLastFiveData.LastCountRedResult4 = number.GetResult();
            objLastFiveData.LastCountResult4 = number.GetCount();
        }
        private void AnlysisCountLastFifthIssue()
        {
            AwardNumber number = new AwardNumber();
            number.Anlysis(objLastFiveData.LastRedResult1 + objLastFiveData.LastRedResult2 + objLastFiveData.LastRedResult3 + objLastFiveData.LastRedResult4 + objLastFiveData.LastRedResult5, objLastFiveData.RedResult);
            objLastFiveData.LastCountRedResult5 = number.GetResult();
            objLastFiveData.LastCountResult5 = number.GetCount();
        }
        #endregion

        #region 区间
        private void AnlysisRange()
        {
            RangeNumber rangNumber = new RangeNumber();
            rangNumber.Anlysis(objLastFiveData.LastRedResult1 + objLastFiveData.LastRedResult2 + objLastFiveData.LastRedResult3 + objLastFiveData.LastRedResult4 + objLastFiveData.LastRedResult5);
            string[] redData = rangNumber.GetResult();
            objLastFiveData.LastFiveResult = redData[0];
            objLastFiveData.Range1 = redData[1];
            objLastFiveData.Range2 = redData[2];
            objLastFiveData.Range3 = redData[3];
            objLastFiveData.Range4 = redData[4];
            objLastFiveData.Range5 = redData[5];

        }
        #endregion

    }
}
