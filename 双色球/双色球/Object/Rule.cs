
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace Lottery
{


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


}
