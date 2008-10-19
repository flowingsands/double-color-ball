using System;
using System.Collections.Generic;
using System.Text;


namespace Lottery
{
    public class FlIssue
    {
        private string lotIssue;
        private DateTime starttime;
        private DateTime endtime;
        private string result1;
        private string result2;
        private string result3;
        private int bonus1;
        private int bonus2;
        private int bonus3;
        private int sale;
        private int count1;
        private int count2;
        private int count3;
        private string memo;

        public FlIssue(string LotIssue, DateTime StartTime, DateTime EndTime,
                        string Result1, string Result2, string Result3,
                        int Bonus1, int Bonus2, int Bonus3,
                        int Sale, int Count1, int Count2, int Count3, string Memo)
        {
            this.lotIssue = LotIssue;
            this.starttime = StartTime;
            this.endtime = EndTime;
            this.result1 = Result1;
            this.result2 = Result2;
            this.result3 = Result3;
            this.bonus1 = Bonus1;
            this.bonus2 = Bonus2;
            this.bonus3 = Bonus3;
            this.sale = Sale;
            this.count1 = Count1;
            this.count2 = Count2;
            this.count3 = Count3;
            this.memo = Memo;
        }

        public FlIssue(string LotIssue, DateTime EndTime,
                        string Result1, string Result2,
                        int Bonus1, int Bonus2, int Bonus3,
                        int Sale, int Count1, int Count2, int Count3)
        {
            this.lotIssue = LotIssue;
            this.result1 = Result1;
            this.result2 = Result2;

            this.endtime = EndTime;
            this.bonus1 = Bonus1;
            this.bonus2 = Bonus2;
            this.bonus3 = Bonus3;
            this.sale = Sale;
            this.count1 = Count1;
            this.count2 = Count2;
            this.count3 = Count3;
            //this.result3 = Result3;
            //this.starttime = StartTime;
            //this.memo = Memo;
        }


        public string LotIssue
        {
            get
            {
                return lotIssue;
            }
            set
            {
                lotIssue = value;
            }
        }
        public DateTime StartTime
        {
            get
            {
                return starttime;
            }
            set
            {
                starttime = value;
            }
        }
        public DateTime EndTime
        {
            get
            {
                return endtime;
            }
            set
            {
                endtime = value;
            }
        }
        public string Result1
        {
            get
            {
                return result1;
            }
            set
            {
                result1 = value;
            }
        }
        public string Result2
        {
            get
            {
                return result2;
            }
            set
            {
                result2 = value;
            }
        }
        public string Result3
        {
            get
            {
                return result3;
            }
            set
            {
                result3 = value;
            }
        }
        public int Bonus1
        {
            get
            {
                return bonus1;
            }
            set
            {
                bonus1 = value;
            }
        }
        public int Bonus2
        {
            get
            {
                return bonus2;
            }
            set
            {
                bonus2 = value;
            }
        }
        public int Bonus3
        {
            get
            {
                return bonus3;
            }
            set
            {
                bonus3 = value;
            }
        }
        public int Sale
        {
            get
            {
                return sale;
            }
            set
            {
                sale = value;
            }
        }
        public int Count1
        {
            get
            {
                return count1;
            }
            set
            {
                count1 = value;
            }
        }
        public int Count2
        {
            get
            {
                return count2;
            }
            set
            {
                count2 = value;
            }
        }
        public int Count3
        {
            get
            {
                return count3;
            }
            set
            {
                count3 = value;
            }
        }
        public string Memo
        {
            get
            {
                return memo;
            }
            set
            {
                memo = value;
            }
        }

        public string Award
        {
            get
            {
                return result1 + " " + result2;
            }
        }

        public int IssueID
        {
            get
            {
                return Convert.ToInt32(lotIssue);
            }
        }
    }

    public class LastFiveIssue
    {
        private string lotIssue0;
        private string result0;

        private string lotIssue1;
        private string result1;
        private string countResult1;
        private int count1;

        private string lotIssue2;
        private string result2;
        private string countResult2;
        private int count2;

        private string lotIssue3;
        private string result3;
        private string countResult3;
        private int count3;

        private string lotIssue4;
        private string result4;
        private string countResult4;
        private int count4;

        private string lotIssue5;
        private string result5;
        private string countResult5;
        private int count5;


        public LastFiveIssue(string LotIssue0, string Result0,
                             string LotIssue1, string Result1, string CountResult1,  int Count1,
                             string LotIssue2, string Result2, string CountResult2, int Count2,
                             string LotIssue3, string Result3, string CountResult3, int Count3,
                             string LotIssue4, string Result4, string CountResult4, int Count4,
                             string LotIssue5, string Result5, string CountResult5, int Count5)
        {
            lotIssue0 = LotIssue0;
            result0 = Result0;

            lotIssue1 = LotIssue1;
            result1 = Result1;
            countResult1 = CountResult1;
            count1 = Count1;

            lotIssue2 = LotIssue2;
            result2 = Result2;
            countResult2 = CountResult2;
            count2 = Count2;

            lotIssue3 = LotIssue3;
            result3 = Result3;
            countResult3 = CountResult3;
            count3 = Count3;

            lotIssue4 = LotIssue4;
            result4 = Result4;
            countResult4 = CountResult4;
            count4 = Count4;

            lotIssue5 = LotIssue5;
            result5 = Result5;
            countResult5 = CountResult5;
            count5 = Count5;

        }

        public LastFiveIssue(string LotIssue0, string Result0,
                             string LotIssue1, string Result1,
                             string LotIssue2, string Result2, 
                             string LotIssue3, string Result3, 
                             string LotIssue4, string Result4, 
                             string LotIssue5, string Result5)
        {
            lotIssue0 = LotIssue0;
            result0 = Result0;

            lotIssue1 = LotIssue1;
            result1 = Result1;

            lotIssue2 = LotIssue2;
            result2 = Result2;

            lotIssue3 = LotIssue3;
            result3 = Result3;

            lotIssue4 = LotIssue4;
            result4 = Result4;

            lotIssue5 = LotIssue5;
            result5 = Result5;

        }

        public string LotIssue0
        {
            get
            {
                return lotIssue0;
            }
            set
            {
                lotIssue0 = value;
            }
        }
        public string Result0
        {
            get
            {
                return result0;
            }
            set
            {
                result0 = value;
            }
        }

        public string LotIssue1
        {
            get
            {
                return lotIssue1;
            }
            set
            {
                lotIssue1 = value;
            }
        }
        public string Result1
        {
            get
            {
                return result1;
            }
            set
            {
                result1 = value;
            }
        }
        public string CountResult1
        {
            get
            {
                return countResult1;
            }
            set
            {
                countResult1 = value;
            }
        }
        public int Count1
        {
            get
            {
                return count1;
            }
            set
            {
                count1 = value;
            }
        }

        public string LotIssue2
        {
            get
            {
                return lotIssue2;
            }
            set
            {
                lotIssue2 = value;
            }
        }
        public string Result2
        {
            get
            {
                return result2;
            }
            set
            {
                result2 = value;
            }
        }
        public string CountResult2
        {
            get
            {
                return countResult2;
            }
            set
            {
                countResult2 = value;
            }
        }
        public int Count2
        {
            get
            {
                return count2;
            }
            set
            {
                count2 = value;
            }
        }

        public string LotIssue3
        {
            get
            {
                return lotIssue3;
            }
            set
            {
                lotIssue3 = value;
            }
        }
        public string Result3
        {
            get
            {
                return result3;
            }
            set
            {
                result3 = value;
            }
        }
        public string CountResult3
        {
            get
            {
                return countResult3;
            }
            set
            {
                countResult3 = value;
            }
        }
        public int Count3
        {
            get
            {
                return count3;
            }
            set
            {
                count3 = value;
            }
        }

        public string LotIssue4
        {
            get
            {
                return lotIssue4;
            }
            set
            {
                lotIssue4 = value;
            }
        }
        public string Result4
        {
            get
            {
                return result4;
            }
            set
            {
                result4 = value;
            }
        }
        public string CountResult4
        {
            get
            {
                return countResult4;
            }
            set
            {
                countResult4 = value;
            }
        }
        public int Count4
        {
            get
            {
                return count4;
            }
            set
            {
                count4 = value;
            }
        }

        public string LotIssue5
        {
            get
            {
                return lotIssue5;
            }
            set
            {
                lotIssue5 = value;
            }
        }
        public string Result5
        {
            get
            {
                return result5;
            }
            set
            {
                result5 = value;
            }
        }
        public string CountResult5
        {
            get
            {
                return countResult5;
            }
            set
            {
                countResult5 = value;
            }
        }
        public int Count5
        {
            get
            {
                return count5;
            }
            set
            {
                count5 = value;
            }
        }


        public string InsertMysqlString
        {
            get
            {
                string rutString = "INSERT lastfive_issue(LotIssue0,Result0,LotIssue1,Result1,CountResult1,Count1,LotIssue2,Result2,CountResult2,Count2,LotIssue3,Result3,CountResult3,Count3,LotIssue4,Result4,CountResult4,Count4,LotIssue5,Result5,CountResult5,Count5) VALUE" 
                                   + "('" + lotIssue0  + "'," + "'" + result0 + "',"
                                   + "'" + lotIssue1 + "'," + "'" + result1 + "'," + "'" + countResult1 + "'," + count1 + ","
                                   + "'" + lotIssue2 + "'," + "'" + result2 + "'," + "'" + countResult2 + "'," + count2 + ","
                                   + "'" + lotIssue3 + "'," + "'" + result3 + "'," + "'" + countResult3 + "'," + count3 + ","
                                   + "'" + lotIssue4 + "'," + "'" + result4 + "'," + "'" + countResult4 + "'," + count4 + ","
                                   + "'" + lotIssue5 + "'," + "'" + result5 + "'," + "'" + countResult5 + "'," + count5 + ");";
                return rutString;
            }
        }

    }

}