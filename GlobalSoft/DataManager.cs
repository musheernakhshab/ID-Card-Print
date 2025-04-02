using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Data.OleDb;

/// <summary>
/// Summary description for DataManager
/// </summary>
public class DataManager
{
    public DataManager()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public enum DBReturnCode
    {
        SUCCESS = 0,
        CONNECTIONFAILURE = -1,
        SUCCESSNORESULT = -2,
        SUCCESSNOAFFECT = -3,
        DUPLICATEENTRY = -4,
        EXCEPTION = -5,
        INPUTPARAMETEREMPTY = -6
    }
    private static OleDbConnection OpenConnection()
    {
        OleDbConnection conn = null;
        try
        {
            String appPath = System.Windows.Forms.Application.StartupPath;

            //Console.WriteLine("ApplicationData := " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

            //String applicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            appPath += @"\DB\GS.mdb";

            String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = " + appPath;

            conn = new OleDbConnection(connectionString);
            conn.Open();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            conn = null;
        }
        return conn;
    }

    private static void CloseConnection(OleDbConnection conn)
    {
        try
        {
            conn.Close();
            conn.Dispose();
        }
        catch { }
    }

    private static DBReturnCode ExecuteQuery(string sQuery, out DataTable dtResult)
    {
        DBReturnCode retcode = DBReturnCode.EXCEPTION;
        dtResult = null;
        OleDbDataAdapter dataAdapter = null;
        OleDbConnection conn = OpenConnection();
        if (conn == null)
        {
            retcode = DBReturnCode.CONNECTIONFAILURE;
        }
        else
        {
            try
            {
                dataAdapter = new OleDbDataAdapter(sQuery, conn);
                DataSet dsTmp = new DataSet();
                dataAdapter.Fill(dsTmp);
                dtResult = dsTmp.Tables[0];
                if (dtResult.Rows.Count == 0)
                    return DBReturnCode.SUCCESSNORESULT;
                else
                    return DBReturnCode.SUCCESS;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                retcode = DBReturnCode.EXCEPTION;
            }
            finally
            {
                dataAdapter.Dispose();
                CloseConnection(conn);
            }
        }
        return retcode;
    }

    private static DBReturnCode ExecuteNonQuery(string sQuery)
    {
        DBReturnCode retcode = DBReturnCode.EXCEPTION;
        OleDbCommand cmd = null;
        OleDbConnection conn = OpenConnection();
        if (conn == null)
        {
            retcode = DBReturnCode.CONNECTIONFAILURE;
        }
        else
        {
            try
            {
                cmd = new OleDbCommand(sQuery, conn);
                if (cmd.ExecuteNonQuery() == 0)
                    return DBReturnCode.SUCCESSNOAFFECT;
                else
                    return DBReturnCode.SUCCESS;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                retcode = DBReturnCode.EXCEPTION;
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
        }
        return retcode;
    }
    #region College
    public static DBReturnCode AddCollege(String sCollegeName, String sSansthaName, String sAddress, String sZip, String sContact, String sEmail, String sWebsite, String sLogoPath, String sSignPath)
    {
        String SQL = "INSERT INTO tbl_College(sCName, sSName, sAddress, sZip, sContactNo, sEmailId, sWebsite, sLogoPath, sASign) VALUES ('" + sCollegeName + "','" + sSansthaName + "', '" + sAddress + "', '" + sZip + "', '" + sContact + "', '" + sEmail + "', '" + sWebsite + "', '" + sLogoPath + "', '" + sSignPath + "')";
        return ExecuteNonQuery(SQL);
    }
    public static DBReturnCode ViewAllColleges(out DataTable dtResult)
    {
        dtResult = null;
        String SQL = "SELECT * FROM tbl_College";
        return ExecuteQuery(SQL, out dtResult);
    }
    public static DBReturnCode GetCollegeName(out DataTable dtResult)
    {
        dtResult = null;
        String SQL = "SELECT nID, sCName FROM tbl_College";
        return ExecuteQuery(SQL, out dtResult);
    }
    public static DBReturnCode AddClassName(String sClassName)
    {
        String SQL = "INSERT INTO tbl_Class(sClass) VALUES ('" + sClassName + "')";
        return ExecuteNonQuery(SQL);
    }
    public static DBReturnCode GetClassName(out DataTable dtResult)
    {
        dtResult = null;
        String SQL = "SELECT * FROM tbl_Class";
        return ExecuteQuery(SQL, out dtResult);
    }
    public static DBReturnCode ChkClassName(String sClassName, out DataTable dtResult)
    {
        dtResult = null;
        String SQL = "SELECT * FROM tbl_Class WHERE sClass = '" + sClassName + "'";
        return ExecuteQuery(SQL, out dtResult);
    }

    public static DBReturnCode AddStudent(Int64 CID, String SName, Int64 ClassID, DateTime dDOB, String BGroup, String Session, String ContactNo, String DrivLicence, String Address, String SUID, String PPhoto)
    {
        String SQL = "INSERT INTO tbl_Student(nCID, sStudentName, nClassID, dDOB, sBloodGroup, sSession, sContactNo, sDrivingLicence, sAddress, sSID, sPassportPhoto) VALUES ('" + CID.ToString() + "','" + SName + "', '" + ClassID.ToString() + "', '" + dDOB + "', '" + BGroup + "', '" + Session + "', '" + ContactNo + "', '" + DrivLicence + "', '" + Address + "', '" + SUID + "', '" + PPhoto + "')";
        return ExecuteNonQuery(SQL);
    }
    public static DBReturnCode ViewStudentByCID(Int64 CID, out DataTable dtResult)
    {
        dtResult = null;
        String SQL = "SELECT tbl_Class.sClass, tbl_Student.nID, tbl_Student.sStudentName, tbl_Student.dDOB, tbl_Student.sBloodGroup, tbl_Student.sSession, tbl_Student.sContactNo, tbl_Student.sDrivingLicence, tbl_Student.sAddress, tbl_Student.sSID";
                SQL += " FROM tbl_Student INNER JOIN tbl_Class ON tbl_Student.nClassID = tbl_Class.nID";
                SQL += " WHERE tbl_Student.nCID = " + CID.ToString() + "";
        return ExecuteQuery(SQL, out dtResult);
    }
    public static DBReturnCode GetStudentToPrint(Int64 SID, out DataTable dtResult)
    {
        dtResult = null;
        String SQL = "SELECT TOP 8 tbl_College.sCName, tbl_College.sSName, tbl_College.sAddress AS CAddress, tbl_College.sZip, tbl_College.sContactNo AS CContact, tbl_College.sEmailId, tbl_College.sWebsite, tbl_College.sLogoPath, tbl_College.sASign, ";
        SQL += " tbl_Class.sClass, * FROM (tbl_Student LEFT JOIN tbl_College ON tbl_Student.nCID = tbl_College.nID) LEFT JOIN tbl_Class ON tbl_Student.nClassID = tbl_Class.nID";
        SQL += " WHERE (((tbl_Student.nID) Not In (SELECT TOP " + SID.ToString() + " nID FROM tbl_Student ORDER BY nID))) ORDER BY tbl_Student.nID";
       return ExecuteQuery(SQL, out dtResult);
    }
    #endregion College
}
