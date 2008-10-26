
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Lottery
{
    #region Mysql数据库操作类
    public class ADODatabase
    {
        public static int ExecuteNonQuery(string connectionString, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }

        public static int ExecuteNonQuery(MySqlTransaction trans, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }

        public static int ExecuteNonQuery(MySqlConnection connection, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();

            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }

        public static MySqlDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText, params MySqlParameter[] commandParamters)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParamters);
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        public static MySqlDataReader ExecuteReader(MySqlConnection conn, CommandType cmdType, string cmdText, params MySqlParameter[] commandParamters)
        {
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParamters);
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        public static object ExecuteScalar(MySqlConnection connection, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();

            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            object val = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            return val;
        }

        public static object ExecuteScalar(string connectionString, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
        }

        private static void PrepareCommand(MySqlCommand cmd, MySqlConnection conn, MySqlTransaction trans, CommandType cmdType, string cmdText, MySqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;


            if (cmdParms != null)
            {
                foreach (MySqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }
    }
    #endregion

    #region Mysql数据库抽象类
    public class BaseMySqlServer : IDisposable
    {
        private const string privoder = "Database=doublecolorball;Data Source=localhost;Port=13361;User Id=root;Password=123456; Pooling=false;Connection Lifetime=5";
        private MySqlConnection conn = null;
        private bool IsDisposed = false;

        public BaseMySqlServer()
        {
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = privoder;
                conn.Open();
            }
            catch (Exception se)
            {
                MessageBox.Show("发送错误：" + se.Message, "提示信息", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }

        }

        ~BaseMySqlServer()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool Diposing)
        {
            if (!IsDisposed)
            {
                if (Diposing)
                {
                    if (conn != null)
                    {
                        try
                        {
                            conn.Close();
                        }
                        catch (Exception se)
                        {
                            MessageBox.Show("析构错误：" + se.Message, "提示信息", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                        }
                        finally
                        {
                            conn.Dispose();
                        }
                    }
                }
            }
            IsDisposed = true;
        }

        protected int ExecuteNonQuery(MySqlTransaction trans, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }

        protected int ExecuteNonQuery(CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();
            int val = 0;

            PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
            try
            {
                val = cmd.ExecuteNonQuery();
                return val;
            }
            catch
            {
                cmd.Dispose();
            }
            return 0;
        }

        protected MySqlDataReader ExecuteReader(CommandType cmdType, string cmdText, params MySqlParameter[] commandParamters)
        {
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParamters);
                MySqlDataReader rdr = cmd.ExecuteReader();
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                cmd.Dispose();
            }
            return null;
        }

        protected DataTable GetDataTable(CommandType cmdType, string cmdText, params MySqlParameter[] commandParamters)
        {
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParamters);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);
                return table;

            }
            catch
            {
                cmd.Dispose();
            }
            finally
            {
                cmd.Dispose();
            }
            return null;
        }

        private void PrepareCommand(MySqlCommand cmd, MySqlConnection conn, MySqlTransaction trans, CommandType cmdType, string cmdText, MySqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;


            if (cmdParms != null)
            {
                foreach (MySqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }

        public void DataUpdate(string strResult)
        {
            string[] stringArray = strResult.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string query in stringArray)
            {
                ExecuteNonQuery(CommandType.Text, query + ";", null);
            }

        }   
    }
    #endregion

    #region Mysql表操作

    public class TableFlIssue : BaseMySqlServer
    {

        public DataTable GetTableDataByDesc()
        {
            string query = "SELECT `LotIssue`,`EndTime`,`Result`,`Result2`,`Sale`,`Count1`,`Bonus1`,`Count2`,`Bonus2`,`Count3`,`Bonus3` FROM fl_issue order by lotissue desc;";
            return this.GetDataTable(CommandType.Text, query, null);
        }

        public DataTable GetTableDataForMaintenceForm()
        {
            string query = "SELECT `LotIssue`,`EndTime`,`Result`,`Result2`,`Sale`,`Count1`,`Bonus1`,`Count2`,`Bonus2` FROM fl_issue order by lotissue desc;";

            return this.GetDataTable(CommandType.Text, query, null);
        }

        public IList<FlIssue> GetTableDataToList()
        {
            IList<FlIssue> list = new List<FlIssue>();
            string query = "SELECT `LotIssue`,`EndTime`,`Result`,`Result2`,`Bonus1`,`Bonus2`,`Bonus3`,`Sale`,`Count1`,`Count2`,`Count3` FROM fl_issue order by lotissue desc;";
            MySqlDataReader rdr = null;

            rdr = ExecuteReader(CommandType.Text, query, null);
            while (rdr.Read())
            {
                Console.WriteLine(rdr.GetString(0));
                list.Add(new FlIssue(rdr.GetString(0), rdr.GetDateTime(1), rdr.GetString(2), rdr.GetString(3), rdr.GetInt32(4), rdr.GetInt32(5), rdr.GetInt32(6), rdr.GetInt32(7), rdr.GetInt32(8), rdr.GetInt32(9), rdr.GetInt32(10)));
            }
            rdr.Close();
            return list;

        }

        /*
        
        public Hashtable GetTableData4()
        {
            Hashtable ht = new Hashtable();
            string query = "select `LotIssue`,`EndTime`,`Result`,`Result2`,`Bonus1`,`Bonus2`,`Bonus3`,`Sale`,`Count1`,`Count2`,`Count3` from doublecolorball.fl_issue order by lotissue asc;";
            MySqlDataReader rdr = null;

            rdr = ExecuteReader(CommandType.Text, query, null);
            while (rdr.Read())
            {
                Console.WriteLine(rdr.GetString(0));
                ht.Add(rdr.GetString(0), new Fl_Issue(rdr.GetString(0), rdr.GetDateTime(1), rdr.GetString(2), rdr.GetString(3), rdr.GetInt32(4), rdr.GetInt32(5), rdr.GetInt32(6), rdr.GetInt32(7), rdr.GetInt32(8), rdr.GetInt32(9), rdr.GetInt32(10)));
            }
            rdr.Close();
            return ht;

        }
        */

    }

    public class TableLastFiveIssue : BaseMySqlServer
    {
        
    }

    public class TableRangeIssue : BaseMySqlServer
    {
        public DataTable GetTableDataForMaintenceForm()
        {
            string query = "SELECT LotIssue0,Result0,Result1,Range1,CountRange1,Count1,Range2,CountRange2,Count2,Range3,CountRange3,Count3,Range4,CountRange4,Count4,Range5,CountRange5,Count5 FROM range_issue order by lotissue0 desc;";
            return this.GetDataTable(CommandType.Text, query, null);
        }

    }

    public class TableLastFiveDataIssue : BaseMySqlServer
    {
        public DataTable GetTableData()
        {
            string query = "SELECT LotIssue,RedResult,BlueResult,LastFiveResult,LastLotIssue1,LastRedResult1,LastBlueResult1,LastCountRedResult1,LastCountResult1,LastLotIssue2,LastRedResult2,LastBlueResult2,LastCountRedResult2,LastCountResult2,LastLotIssue3,LastRedResult3,LastBlueResult3,LastCountRedResult3,LastCountResult3,LastLotIssue4,LastRedResult4,LastBlueResult4,LastCountRedResult4,LastCountResult4,LastLotIssue5,LastRedResult5,LastBlueResult5,LastCountRedResult5,LastCountResult5,Range1,CountRedRange1,CountRange1,Range2,CountRedRange2,CountRange2,Range3,CountRedRange3,CountRange3,Range4,CountRedRange4,CountRange4,Range5,CountRedRange5,CountRange5 FROM lastfivedata_issue order by LotIssue desc;";
            return this.GetDataTable(CommandType.Text, query, null);
        }

        public IList<LastFiveDataIssue> GetTableDataToList()
        {
            IList<LastFiveDataIssue> list = new List<LastFiveDataIssue>();
            string query = "SELECT LotIssue,RedResult,BlueResult,LastFiveResult,LastLotIssue1,LastRedResult1,LastBlueResult1,LastCountRedResult1,LastCountResult1,LastLotIssue2,LastRedResult2,LastBlueResult2,LastCountRedResult2,LastCountResult2,LastLotIssue3,LastRedResult3,LastBlueResult3,LastCountRedResult3,LastCountResult3,LastLotIssue4,LastRedResult4,LastBlueResult4,LastCountRedResult4,LastCountResult4,LastLotIssue5,LastRedResult5,LastBlueResult5,LastCountRedResult5,LastCountResult5,Range1,CountRedRange1,CountRange1,Range2,CountRedRange2,CountRange2,Range3,CountRedRange3,CountRange3,Range4,CountRedRange4,CountRange4,Range5,CountRedRange5,CountRange5 FROM lastfivedata_issue order by LotIssue asc;";
            MySqlDataReader rdr = null;

            rdr = ExecuteReader(CommandType.Text, query, null);
            while (rdr.Read())
            {
                Console.WriteLine(rdr.GetString(0));
                list.Add(new LastFiveDataIssue(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3),
                                                 rdr.GetString(4), rdr.GetString(5), rdr.GetString(6), rdr.GetString(7), rdr.GetInt32(8),
                                                 rdr.GetString(9), rdr.GetString(10), rdr.GetString(11), rdr.GetString(12), rdr.GetInt32(13),
                                                 rdr.GetString(14), rdr.GetString(15), rdr.GetString(16), rdr.GetString(17), rdr.GetInt32(18),
                                                 rdr.GetString(19), rdr.GetString(20), rdr.GetString(21), rdr.GetString(22), rdr.GetInt32(23),
                                                 rdr.GetString(24), rdr.GetString(25), rdr.GetString(26), rdr.GetString(27), rdr.GetInt32(28),
                                                 rdr.GetString(29), rdr.GetString(30), rdr.GetInt32(31),
                                                 rdr.GetString(32), rdr.GetString(33), rdr.GetInt32(34),
                                                 rdr.GetString(35), rdr.GetString(36), rdr.GetInt32(37),
                                                 rdr.GetString(38), rdr.GetString(39), rdr.GetInt32(40),
                                                 rdr.GetString(41), rdr.GetString(42), rdr.GetInt32(43)
                                                 )
                         );
            }
            rdr.Close();
            return list;

        }
    }

    #endregion
}