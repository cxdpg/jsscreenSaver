using System;
using System.Data;
using System.Data.SQLite;

public static class db
{
    ///////////////////////////////////////////////////////////////////////
    public static string execute_scalar(string sql)
    {
        get_sqlconnection();
        var cmd = new SQLiteCommand(sql, conn);
        var returnValue = cmd.ExecuteScalar();
        if (returnValue == null)
        {
            return string.Empty;
        }
        else
        {
            return returnValue.ToString();
        }
    }


    ///////////////////////////////////////////////////////////////////////
    public static int execute_nonquery(string sql)
    {
        get_sqlconnection();
        var cmd = new SQLiteCommand(sql, conn);
        return cmd.ExecuteNonQuery();
    }

    ///////////////////////////////////////////////////////////////////////
    public static DataSet get_dataset(string sql)
    {
        var ds = new DataSet();
        get_sqlconnection();
        using (var da = new SQLiteDataAdapter(sql, conn))
        {
            da.Fill(ds);
            return ds;
        }
    }

    ///////////////////////////////////////////////////////////////////////
    public static DataTable get_table(string sql)
    {
        return get_dataset(sql).Tables[0];
    }


    ///////////////////////////////////////////////////////////////////////
    public static DataView get_dataview(string sql)
    {
        var ds = get_dataset(sql);
        return new DataView(ds.Tables[0]);
    }


    ///////////////////////////////////////////////////////////////////////
    public static DataRow get_datarow(string sql)
    {
        var ds = get_dataset(sql);
        if (ds.Tables[0].Rows.Count != 1)
            return null;
        return ds.Tables[0].Rows[0];
    }

    ///////////////////////////////////////////////////////////////////////
    public static SQLiteConnection get_sqlconnection()
    {
        if (conn != null && conn.State == ConnectionState.Open)
        {
            return conn;
        }
        var conn_str = "Data Source='" + AppDomain.CurrentDomain.BaseDirectory + "screenSaver.db3'";
        //Util.write_to_log(conn_str);
        conn = new SQLiteConnection(conn_str);

        conn.Open();
        return conn;

    }
    public static SQLiteConnection conn;
}