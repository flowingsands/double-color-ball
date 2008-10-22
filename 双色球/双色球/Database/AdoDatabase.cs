
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
            //string query = "SELECT `LotIssue` as '彩票期号',`EndTime` as '开奖日期',`Result` as '红球',`Result2` as '蓝球',`Sale` as '销售金额',`Count1` as '一等奖',`Bonus1` as '奖金',`Count2` as '二等奖',`Bonus2` as '奖金' FROM fl_issue order by lotissue desc;";
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
            //string query = "SELECT `LotIssue` as '彩票期号',`EndTime` as '开奖日期',`Result` as '红球',`Result2` as '蓝球',`Sale` as '销售金额',`Count1` as '一等奖',`Bonus1` as '奖金',`Count2` as '二等奖',`Bonus2` as '奖金' FROM fl_issue order by lotissue desc;";
            string query = "SELECT LotIssue0,Result0,Result1,Range1,CountRange1,Count1,Range2,CountRange2,Count2,Range3,CountRange3,Count3,Range4,CountRange4,Count4,Range5,CountRange5,Count5 FROM range_issue order by lotissue0 desc;";
            return this.GetDataTable(CommandType.Text, query, null);
        }

    }
    

    #endregion
}