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

        public string UpdateMysqlString
        {
            get
            {
                string rutString = "INSERT lastfive_issue(LotIssue0,Result0) VALUE"
                                   + "('" + lotIssue0 + "','" + result0 + "');\r\n";

                rutString += "UPDATE lastfive_issue SET "
                            + "Result0="   + "'" + result0 + "',"
                            + "LotIssue1=" + "'" + lotIssue1 + "'," + "Result1=" + "'" + result1 + "'," + "CountResult1=" + "'" + countResult1 + "'," + "Count1=" + count1 + ","
                            + "LotIssue2=" + "'" + lotIssue2 + "'," + "Result2=" + "'" + result2 + "'," + "CountResult2=" + "'" + countResult2 + "'," + "Count2=" + count2 + ","
                            + "LotIssue3=" + "'" + lotIssue3 + "'," + "Result3=" + "'" + result3 + "'," + "CountResult3=" + "'" + countResult3 + "'," + "Count3=" + count3 + ","
                            + "LotIssue4=" + "'" + lotIssue4 + "'," + "Result4=" + "'" + result4 + "'," + "CountResult4=" + "'" + countResult4 + "'," + "Count4=" + count4 + ","
                            + "LotIssue5=" + "'" + lotIssue5 + "'," + "Result5=" + "'" + result5 + "'," + "CountResult5=" + "'" + countResult5 + "'," + "Count5=" + count5 
                            + " WHERE LotIssue0=" + "'" + lotIssue0 + "'" + ";";
                return rutString;
            }
        }
    }
   
    public class RangeIssue
    {
        private string lotIssue0;
        private string result0;
        private string result1;

        private string range1;
        private string countRange1;
        private int count1;

        private string range2;
        private string countRange2;
        private int count2;

        private string range3;
        private string countRange3;
        private int count3;

        private string range4;
        private string countRange4;
        private int count4;

        private string range5;
        private string countRange5;
        private int count5;


        public RangeIssue(string LotIssue0, string Result0, string Result1,
                             string Range1, string CountRange1,  int Count1,
                             string Range2, string CountRange2, int Count2,
                             string Range3, string CountRange3, int Count3,
                             string Range4, string CountRange4, int Count4,
                             string Range5, string CountRange5,  int Count5)
        {
            lotIssue0 = LotIssue0;
            result0 = Result0;
            result1 = Result1;

            range1 = Range1;
            countRange1 = CountRange1;
            count1 = Count1;

            range2 = Range2;
            countRange2 = CountRange2;
            count2 = Count2;

            range3 = Range3;
            countRange3 = CountRange3;
            count3 = Count3;

            range4 = Range4;
            countRange1 = CountRange4;
            count4 = Count4;

            range5 = Range5;
            countRange5 = CountRange5;
            count5 = Count5;

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

        public string Range1
        {
            get
            {
                return range1;
            }
            set
            {
                range1 = value;
            }
        }        
        public string CountRange1
        {
            get
            {
                return countRange1;
            }
            set
            {
                countRange1 = value;
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

        public string Range2
        {
            get
            {
                return range2;
            }
            set
            {
                range2 = value;
            }
        }
        public string CountRange2
        {
            get
            {
                return countRange2;
            }
            set
            {
                countRange2 = value;
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
        public string Range3
        {
            get
            {
                return range3;
            }
            set
            {
                range3 = value;
            }
        }
        public string CountRange3
        {
            get
            {
                return countRange3;
            }
            set
            {
                countRange3 = value;
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
        public string Range4
        {
            get
            {
                return range4;
            }
            set
            {
                range4 = value;
            }
        }
        public string CountRange4
        {
            get
            {
                return countRange4;
            }
            set
            {
                countRange4 = value;
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
        public string Range5
        {
            get
            {
                return range5;
            }
            set
            {
                range5 = value;
            }
        }
        public string CountRange5
        {
            get
            {
                return countRange5;
            }
            set
            {
                countRange5 = value;
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
                string rutString = "INSERT range_issue(LotIssue0,Result0,Result1,Range1,CountRange1,Count1,Range2,CountRange2,Count2,Range3,CountRange3,Count3,Range4,CountRange4,Count4,Range5,CountRange5,Count5) VALUE"
                                   + "('" + lotIssue0 + "','" + result0 + "','" + result1 + "',"
                                   + "'" + range1 + "'," + "'" + countRange1 + "'," + count1 + ","
                                   + "'" + range2 + "'," + "'" + countRange2 + "'," + count2 + ","
                                   + "'" + range3 + "'," + "'" + countRange3 + "'," + count3 + ","
                                   + "'" + range4 + "'," + "'" + countRange4 + "'," + count4 + ","
                                   + "'" + range5 + "'," + "'" + countRange5 + "'," + count5 + ")";


                return rutString;
            }
        }

        public string UpdateMysqlString
        {
            get
            {
                string rutString = "INSERT range_issue(LotIssue0,Result0) VALUE"
                                   + "('" + lotIssue0 + "','" + result0 + "');\r\n";

                rutString += "UPDATE range_issue SET "
                            + "Result0=" + "'" + result0 + "',"
                            + "Result1=" + "'" + result1 + "',"
                            + "Range1=" + "'" + range1 + "'," + "CountRange1=" + "'" + countRange1 + "'," + "Count1=" + count1 + ","
                            + "Range2=" + "'" + range2 + "'," + "CountRange2=" + "'" + countRange2 + "'," + "Count2=" + count2 + ","
                            + "Range3=" + "'" + range3 + "'," + "CountRange3=" + "'" + countRange3 + "'," + "Count3=" + count3 + ","
                            + "Range4=" + "'" + range4 + "'," + "CountRange4=" + "'" + countRange4 + "'," + "Count4=" + count4 + ","
                            + "Range5=" + "'" + range5 + "'," + "CountRange5=" + "'" + countRange5 + "'," + "Count5=" + count5
                            + " WHERE LotIssue0=" + "'" + lotIssue0 + "'" + ";"; 
                return rutString;
            }
        }

    }

    public class LastFiveDataIssue
    {
        #region 变量定义
        private string _LotIssue;
        private string _RedResult;
        private string _BlueResult;
        private string _LastFiveResult;

        private string _LastLotIssue1;
        private string _LastRedResult1;
        private string _LastBlueResult1;
        private string _LastCountRedResult1;
        private int    _LastCountResult1;

        private string _LastLotIssue2;
        private string _LastRedResult2;
        private string _LastBlueResult2;
        private string _LastCountRedResult2;
        private int    _LastCountResult2;

        private string _LastLotIssue3;
        private string _LastRedResult3;
        private string _LastBlueResult3;
        private string _LastCountRedResult3;
        private int    _LastCountResult3;

        private string _LastLotIssue4;
        private string _LastRedResult4;
        private string _LastBlueResult4;
        private string _LastCountRedResult4;
        private int    _LastCountResult4;

        private string _LastLotIssue5;
        private string _LastRedResult5;
        private string _LastBlueResult5;
        private string _LastCountRedResult5;
        private int    _LastCountResult5;

        private string _Range1;
        private string _CountRedRange1;
        private int    _CountRange1;

        private string _Range2;
        private string _CountRedRange2;
        private int    _CountRange2;

        private string _Range3;
        private string _CountRedRange3;
        private int    _CountRange3;

        private string _Range4;
        private string _CountRedRange4;
        private int    _CountRange4;

        private string _Range5;
        private string _CountRedRange5;
        private int    _CountRange5;
        #endregion

        #region 函数

        public LastFiveDataIssue() { }

        public LastFiveDataIssue(string LotIssue, string RedResult,string BlueResult,
                                string LastFiveResult,
                                string LastLotIssue1, string LastRedResult1, string LastBlueResult1, string LastCountRedResult1, int LastCountResult1,
                                string LastLotIssue2, string LastRedResult2, string LastBlueResult2, string LastCountRedResult2, int LastCountResult2,
                                string LastLotIssue3, string LastRedResult3, string LastBlueResult3, string LastCountRedResult3, int LastCountResult3,
                                string LastLotIssue4, string LastRedResult4, string LastBlueResult4, string LastCountRedResult4, int LastCountResult4,
                                string LastLotIssue5, string LastRedResult5, string LastBlueResult5, string LastCountRedResult5, int LastCountResult5,
                                string Range1, string CountRedRange1, int CountRange1,
                                string Range2, string CountRedRange2, int CountRange2,
                                string Range3, string CountRedRange3, int CountRange3,
                                string Range4, string CountRedRange4, int CountRange4,
                                string Range5, string CountRedRange5, int CountRange5)

        {
            _LotIssue = LotIssue;
            _RedResult = RedResult;
            _BlueResult = BlueResult;
            _LastFiveResult = LastFiveResult;

            _LastLotIssue1 = LastLotIssue1;
            _LastRedResult1 = LastRedResult1;
            _LastBlueResult1 = LastBlueResult1;
            _LastCountRedResult1 = LastCountRedResult1;
            _LastCountResult1 = LastCountResult1; 

            _LastLotIssue2 = LastLotIssue2;
            _LastRedResult2 = LastRedResult2;
            _LastBlueResult2 = LastBlueResult2;
            _LastCountRedResult2 = LastCountRedResult2;
            _LastCountResult2 = LastCountResult2;

            _LastLotIssue3 = LastLotIssue3;
            _LastRedResult3 = LastRedResult3;
            _LastBlueResult3 = LastBlueResult3;
            _LastCountRedResult3 = LastCountRedResult3;
            _LastCountResult3 = LastCountResult3;

            _LastLotIssue4 = LastLotIssue4;
            _LastRedResult4 = LastRedResult4;
            _LastBlueResult4 = LastBlueResult4;
            _LastCountRedResult4 = LastCountRedResult4;
            _LastCountResult4 = LastCountResult4;

            _LastLotIssue5 = LastLotIssue5;
            _LastRedResult5 = LastRedResult5;
            _LastBlueResult5 = LastBlueResult5;
            _LastCountRedResult5 = LastCountRedResult5;
            _LastCountResult5 = LastCountResult5;

            _Range1 = Range1;
            _CountRedRange1 = CountRedRange1;
            _CountRange1 = CountRange1;
            _Range2 = Range2;
            _CountRedRange2 = CountRedRange2;
            _CountRange2 = CountRange2;
            _Range3 = Range3;
            _CountRedRange3 = CountRedRange3;
            _CountRange3 = CountRange3;
            _Range4 = Range4;
            _CountRedRange4 = CountRedRange4;
            _CountRange4 = CountRange4;
            _Range5 = Range5;
            _CountRedRange5 = CountRedRange5;
            _CountRange5 = CountRange5;


        }
       
        public string LotIssue
        {
            get
            {
                return _LotIssue;
            }
            set
            {
                _LotIssue = value;
            }
        }

        public string RedResult
        {
            get
            {
                return _RedResult;
            }
            set
            {
                _RedResult = value;
            }
        }

        public string BlueResult
        {
            get
            {
                return _BlueResult;
            }
            set
            {
                _BlueResult = value;
            }
        }

        public string LastFiveResult
        {
            get
            {
                return _LastFiveResult;
            }
            set
            {
                _LastFiveResult = value;
            }
        }

        public string LastLotIssue1
        {
            get
            {
                return _LastLotIssue1;
            }
            set
            {
                _LastLotIssue1 = value;
            }
        }

        public string LastRedResult1
        {
            get
            {
                return _LastRedResult1;
            }
            set
            {
                _LastRedResult1 = value;
            }
        }

        public string LastBlueResult1
        {
            get
            {
                return _LastBlueResult1;
            }
            set
            {
                _LastBlueResult1 = value;
            }
        }

        public string LastCountRedResult1
        {
            get
            {
                return _LastCountRedResult1;
            }
            set
            {
                _LastCountRedResult1 = value;
            }
        }

        public int LastCountResult1
        {
            get
            {
                return _LastCountResult1;
            }
            set
            {
                _LastCountResult1 = value;
            }
        }

        public string LastLotIssue2
        {
            get
            {
                return _LastLotIssue2;
            }
            set
            {
                _LastLotIssue2 = value;
            }
        }

        public string LastRedResult2
        {
            get
            {
                return _LastRedResult2;
            }
            set
            {
                _LastRedResult2 = value;
            }
        }

        public string LastBlueResult2
        {
            get
            {
                return _LastBlueResult2;
            }
            set
            {
                _LastBlueResult2 = value;
            }
        }

        public string LastCountRedResult2
        {
            get
            {
                return _LastCountRedResult2;
            }
            set
            {
                _LastCountRedResult2 = value;
            }
        }

        public int LastCountResult2
        {
            get
            {
                return _LastCountResult2;
            }
            set
            {
                _LastCountResult2 = value;
            }
        }

        public string LastLotIssue3
        {
            get
            {
                return _LastLotIssue3;
            }
            set
            {
                _LastLotIssue3 = value;
            }
        }

        public string LastRedResult3
        {
            get
            {
                return _LastRedResult3;
            }
            set
            {
                _LastRedResult3 = value;
            }
        }

        public string LastBlueResult3
        {
            get
            {
                return _LastBlueResult3;
            }
            set
            {
                _LastBlueResult3 = value;
            }
        }

        public string LastCountRedResult3
        {
            get
            {
                return _LastCountRedResult3;
            }
            set
            {
                _LastCountRedResult3 = value;
            }
        }

        public int LastCountResult3
        {
            get
            {
                return _LastCountResult3;
            }
            set
            {
                _LastCountResult3 = value;
            }
        }

        public string LastLotIssue4
        {
            get
            {
                return _LastLotIssue4;
            }
            set
            {
                _LastLotIssue4 = value;
            }
        }

        public string LastRedResult4
        {
            get
            {
                return _LastRedResult4;
            }
            set
            {
                _LastRedResult4 = value;
            }
        }

        public string LastBlueResult4
        {
            get
            {
                return _LastBlueResult4;
            }
            set
            {
                _LastBlueResult4 = value;
            }
        }

        public string LastCountRedResult4
        {
            get
            {
                return _LastCountRedResult4;
            }
            set
            {
                _LastCountRedResult4 = value;
            }
        }

        public int LastCountResult4
        {
            get
            {
                return _LastCountResult4;
            }
            set
            {
                _LastCountResult4 = value;
            }
        }

        public string LastLotIssue5
        {
            get
            {
                return _LastLotIssue5;
            }
            set
            {
                _LastLotIssue5 = value;
            }
        }

        public string LastRedResult5
        {
            get
            {
                return _LastRedResult5;
            }
            set
            {
                _LastRedResult5 = value;
            }
        }

        public string LastBlueResult5
        {
            get
            {
                return _LastBlueResult5;
            }
            set
            {
                _LastBlueResult5 = value;
            }
        }

        public string LastCountRedResult5
        {
            get
            {
                return _LastCountRedResult5;
            }
            set
            {
                _LastCountRedResult5 = value;
            }
        }

        public int LastCountResult5
        {
            get
            {
                return _LastCountResult5;
            }
            set
            {
                _LastCountResult5 = value;
            }
        }
        #endregion


        public string UpdateMysqlString
        {

            get
            {
                string resultString = "INSERT lastfivedata_issue(LotIssue) VALUE"
                                   + "('" + _LotIssue + "');\r\n";

                resultString += "UPDATE lastfivedata_issue SET "
                            + "RedResult=" + "'" + _RedResult + "'," + "BlueResult=" + "'" + _BlueResult + "'," + "LastFiveResult=" + "'" + _LastFiveResult + "',"
                            + "LastLotIssue1=" + "'" + _LastLotIssue1 + "'," + "LastRedResult1=" + "'" + _LastRedResult1 + "'," + "LastBlueResult1=" + "'" + _LastBlueResult1 + "'," + "LastCountRedResult1=" + "'" + _LastCountRedResult1 + "'," + "LastCountResult1=" + _LastCountResult1 + ","
                            + "LastLotIssue2=" + "'" + _LastLotIssue2 + "'," + "LastRedResult2=" + "'" + _LastRedResult2 + "'," + "LastBlueResult2=" + "'" + _LastBlueResult2 + "'," + "LastCountRedResult2=" + "'" + _LastCountRedResult2 + "'," + "LastCountResult2=" + _LastCountResult2 + ","
                            + "LastLotIssue3=" + "'" + _LastLotIssue3 + "'," + "LastRedResult3=" + "'" + _LastRedResult3 + "'," + "LastBlueResult3=" + "'" + _LastBlueResult3 + "'," + "LastCountRedResult3=" + "'" + _LastCountRedResult3 + "'," + "LastCountResult3=" + _LastCountResult3 + ","
                            + "LastLotIssue4=" + "'" + _LastLotIssue4 + "'," + "LastRedResult4=" + "'" + _LastRedResult4 + "'," + "LastBlueResult4=" + "'" + _LastBlueResult4 + "'," + "LastCountRedResult4=" + "'" + _LastCountRedResult4 + "'," + "LastCountResult4=" + _LastCountResult4 + ","
                            + "LastLotIssue5=" + "'" + _LastLotIssue5 + "'," + "LastRedResult5=" + "'" + _LastRedResult5 + "'," + "LastBlueResult5=" + "'" + _LastBlueResult5 + "'," + "LastCountRedResult5=" + "'" + _LastCountRedResult5 + "'," + "LastCountResult5=" + _LastCountResult5 + ","
                            + "Range1=" + "'" + _Range1 + "'," + "CountRedRange1=" + "'" + _CountRedRange1 + "'," + "CountRange1=" + _CountRange1 + ","
                            + "Range2=" + "'" + _Range2 + "'," + "CountRedRange2=" + "'" + _CountRedRange2 + "'," + "CountRange2=" + _CountRange2 + ","
                            + "Range3=" + "'" + _Range3 + "'," + "CountRedRange3=" + "'" + _CountRedRange3 + "'," + "CountRange3=" + _CountRange3 + ","
                            + "Range4=" + "'" + _Range4 + "'," + "CountRedRange4=" + "'" + _CountRedRange4 + "'," + "CountRange4=" + _CountRange4 + ","
                            + "Range5=" + "'" + _Range5 + "'," + "CountRedRange5=" + "'" + _CountRedRange5 + "'," + "CountRange5=" + _CountRange5 
                          + " WHERE LotIssue=" + "'" + _LotIssue + "'" + ";";
                return resultString;
            }
        }
        
    }


}