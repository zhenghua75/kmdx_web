using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;

namespace SQLHelper
{
	/// <summary>
	/// SQLHelper���װ��SQL Server���ݿ����ӡ�ɾ�����޸ĺ�ѡ��Ȳ���
	/// </summary>
	public class SQLHelper
	{
		/// ��������Դ
		private SqlConnection myConnection = null;
		private readonly string RETURNVALUE = "RETURNVALUE";

		/// <summary>
		/// �����ݿ�����.
		/// </summary>
		private void Open() 
		{
			// �����ݿ�����
			if (myConnection == null) 
			{
                myConnection = new SqlConnection(ConfigurationManager.AppSettings["SQLCONNECTIONSTRING"].ToString());				
			}				
			if(myConnection.State == ConnectionState.Closed)
			{   
				try
				{
					///�����ݿ�����
					myConnection.Open();
				}
				catch(Exception ex)
				{
					SystemError.CreateErrorLog(ex.Message);
				}
				finally
				{
					///�ر��Ѿ��򿪵����ݿ�����				
				}
			}
		}

		/// <summary>
		/// �ر����ݿ�����
		/// </summary>
		public void Close() 
		{
			///�ж������Ƿ��Ѿ�����
			if(myConnection != null)
			{
				///�ж����ӵ�״̬�Ƿ��
				if(myConnection.State == ConnectionState.Open)
				{
					myConnection.Close();
				}
			}
		}

		/// <summary>
		/// �ͷ���Դ
		/// </summary>
		public void Dispose() 
		{
			// ȷ�������Ƿ��Ѿ��ر�
			if (myConnection != null) 
			{
				myConnection.Dispose();
				myConnection = null;
			}				
		}
		
		/// <summary>
		/// ִ�д洢����
		/// </summary>
		/// <param name="procName">�洢���̵�����</param>
		/// <returns>���ش洢���̷���ֵ</returns>
		public int RunProc(string procName) 
		{
			SqlCommand cmd = CreateProcCommand(procName, null);
			try
			{
				///ִ�д洢����
				cmd.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				///��¼������־
				SystemError.CreateErrorLog(ex.Message);
			}
			finally
			{
				///�ر����ݿ������
				Close();
			}
			
			///���ش洢���̵Ĳ���ֵ
			return (int)cmd.Parameters[RETURNVALUE].Value;
		}

		/// <summary>
		/// ִ�д洢����
		/// </summary>
		/// <param name="procName">�洢��������</param>
		/// <param name="prams">�洢�����������</param>
		/// <returns>���ش洢���̷���ֵ</returns>
		public int RunProc(string procName, SqlParameter[] prams) 
		{
			SqlCommand cmd = CreateProcCommand(procName, prams);
			try
			{
				///ִ�д洢����
				cmd.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				///��¼������־
				SystemError.CreateErrorLog(ex.Message);
			}
			finally
			{
				///�ر����ݿ������
				Close();
			}
			
			///���ش洢���̵Ĳ���ֵ
			return (int)cmd.Parameters[RETURNVALUE].Value;
		}

		/// <summary>
		/// ִ�д洢����
		/// </summary>
		/// <param name="procName">�洢���̵�����</param>
		/// <param name="dataReader">���ش洢���̷���ֵ</param>
		public void RunProc(string procName, out SqlDataReader dataReader) 
		{
			///����Command
			SqlCommand cmd = CreateProcCommand(procName, null);
			
			try
			{
				///��ȡ����
				dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);	
			}
			catch(Exception ex)
			{
				dataReader = null;
				///��¼������־
				SystemError.CreateErrorLog(ex.Message);
			}
		}

		/// <summary>
		/// ִ�д洢����
		/// </summary>
		/// <param name="procName">�洢���̵�����</param>
		/// <param name="prams">�洢�����������</param>
		/// <param name="dataSet">����DataReader����</param>
		public void RunProc(string procName, SqlParameter[] prams, out SqlDataReader dataReader) 
		{
			///����Command
			SqlCommand cmd = CreateProcCommand(procName, prams);
			
			try
			{
				///��ȡ����
				dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
			}
			catch(Exception ex)
			{
				dataReader = null;
				///��¼������־
				SystemError.CreateErrorLog(ex.Message);
			}
		}	
	
		/// <summary>
		/// ִ�д洢����
		/// </summary>
		/// <param name="procName">�洢���̵�����</param>
		/// <param name="dataSet">����DataSet����</param>
		public void RunProc(string procName, ref DataSet dataSet) 
		{
			if(dataSet == null)
			{
				dataSet = new DataSet();
			}
			///����SqlDataAdapter
			SqlDataAdapter da = CreateProcDataAdapter(procName,null);
			
			try
			{
				///��ȡ����
				da.Fill(dataSet);
			}
			catch(Exception ex)
			{
				///��¼������־
				SystemError.CreateErrorLog(ex.Message);
			}
			finally
			{
				///�ر����ݿ������
				Close();	
			}
		}

		/// <summary>
		/// ִ�д洢����
		/// </summary>
		/// <param name="procName">�洢���̵�����</param>
		/// <param name="prams">�洢�����������</param>
		/// <param name="dataSet">����DataSet����</param>
		public void RunProc(string procName, SqlParameter[] prams,ref DataSet dataSet) 
		{
			if(dataSet == null)
			{
				dataSet = new DataSet();
			}
			///����SqlDataAdapter
			SqlDataAdapter da = CreateProcDataAdapter(procName,prams);
			
			try
			{
				///��ȡ����
				da.Fill(dataSet);
			}
			catch(Exception ex)
			{
				///��¼������־
				SystemError.CreateErrorLog(ex.Message);
			}
			finally
			{
				///�ر����ݿ������
				Close();	
			}
		}
		
		/// <summary>
		/// ִ��SQL���
		/// </summary>
		/// <param name="cmdText">SQL���</param>
		/// <returns>����ֵ</returns>
		public int RunSQL(string cmdText) 
		{
			SqlCommand cmd = CreateSQLCommand(cmdText, null);
			try
			{
				///ִ�д洢����
				cmd.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				///��¼������־
				SystemError.CreateErrorLog(ex.Message);
			}
			finally
			{
				///�ر����ݿ������
				Close();	
			}
			
			///���ش洢���̵Ĳ���ֵ
			return (int)cmd.Parameters[RETURNVALUE].Value;
		}

		
		/// <summary>
		/// ִ��SQL���
		/// </summary>
		/// <param name="cmdText">SQL���</param>
		/// <param name="prams">SQL����������</param>
		/// <returns>����ֵ</returns>
		public int RunSQL(string cmdText, SqlParameter[] prams) 
		{
			SqlCommand cmd = CreateSQLCommand(cmdText,prams);
			try
			{
				///ִ�д洢����
				cmd.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				///��¼������־
				SystemError.CreateErrorLog(ex.Message);
			}
			finally
			{
				///�ر����ݿ������
				Close();	
			}
			
			///���ش洢���̵Ĳ���ֵ
			return (int)cmd.Parameters[RETURNVALUE].Value;
		}	
		
		/// <summary>
		/// ִ��SQL���
		/// </summary>
		/// <param name="cmdText">SQL���</param>		
		/// <param name="dataReader">����DataReader����</param>
		public void RunSQL(string cmdText, out SqlDataReader dataReader) 
		{
			///����Command
			SqlCommand cmd = CreateSQLCommand(cmdText, null);
			
			try
			{
				///��ȡ����
				dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);	
			}
			catch(Exception ex)
			{
				dataReader = null;
				///��¼������־
				SystemError.CreateErrorLog(ex.Message);
			}
		}

		/// <summary>
		/// ִ��SQL���
		/// </summary>
		/// <param name="cmdText">SQL���</param>
		/// <param name="prams">SQL����������</param>
		/// <param name="dataReader">����DataReader����</param>
		public void RunSQL(string cmdText, SqlParameter[] prams, out SqlDataReader dataReader) 
		{
			///����Command
			SqlCommand cmd = CreateSQLCommand(cmdText, prams);
			
			try
			{
				///��ȡ����
				dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
			}
			catch(Exception ex)
			{
				dataReader = null;
				///��¼������־
				SystemError.CreateErrorLog(ex.Message);
			}
		}

		/// <summary>
		/// ִ��SQL���
		/// </summary>
		/// <param name="cmdText">SQL���</param>
		/// <param name="dataSet">����DataSet����</param>
		public void RunSQL(string cmdText, ref DataSet dataSet) 
		{
			if(dataSet == null)
			{
				dataSet = new DataSet();
			}
			///����SqlDataAdapter
			SqlDataAdapter da = CreateSQLDataAdapter(cmdText,null);
			
			try
			{
				///��ȡ����
				da.Fill(dataSet);
			}
			catch(Exception ex)
			{
				///��¼������־
				SystemError.CreateErrorLog(ex.Message);
			}
			finally
			{
				///�ر����ݿ������
				Close();	
			}
		}

		/// <summary>
		/// ִ��SQL���
		/// </summary>
		/// <param name="cmdText">SQL���</param>
		/// <param name="prams">SQL����������</param>
		/// <param name="dataSet">����DataSet����</param>
		public void RunSQL(string cmdText, SqlParameter[] prams,ref DataSet dataSet) 
		{
			if(dataSet == null)
			{
				dataSet = new DataSet();
			}
			///����SqlDataAdapter
			SqlDataAdapter da = CreateProcDataAdapter(cmdText,prams);
			
			try
			{
				///��ȡ����
				da.Fill(dataSet);
			}
			catch(Exception ex)
			{
				///��¼������־
				SystemError.CreateErrorLog(ex.Message);
			}
			finally
			{
				///�ر����ݿ������
				Close();	
			}
		}
		
		/// <summary>
		/// ����һ��SqlCommand�����Դ���ִ�д洢����
		/// </summary>
		/// <param name="procName">�洢���̵�����</param>
		/// <param name="prams">�洢�����������</param>
		/// <returns>����SqlCommand����</returns>
		private SqlCommand CreateProcCommand(string procName, SqlParameter[] prams) 
		{
			///�����ݿ�����
			Open();
			
			///����Command
			SqlCommand cmd = new SqlCommand(procName, myConnection);
			cmd.CommandType = CommandType.StoredProcedure;

			///��ӰѴ洢���̵Ĳ���
			if (prams != null) 
			{
				foreach (SqlParameter parameter in prams)
				{
					cmd.Parameters.Add(parameter);
				}
			}
			
			///��ӷ��ز���ReturnValue
			cmd.Parameters.Add(
				new SqlParameter(RETURNVALUE, SqlDbType.Int,4,ParameterDirection.ReturnValue,
				false,0,0,string.Empty, DataRowVersion.Default,null));

			///���ش�����SqlCommand����
			return cmd;
		}

		/// <summary>
		/// ����һ��SqlCommand�����Դ���ִ�д洢����
		/// </summary>
		/// <param name="cmdText">SQL���</param>
		/// <param name="prams">SQL����������</param>
		/// <returns>����SqlCommand����</returns>
		private SqlCommand CreateSQLCommand(string cmdText, SqlParameter[] prams) 
		{
			///�����ݿ�����
			Open();
			
			///����Command
			SqlCommand cmd = new SqlCommand(cmdText,myConnection);			

			///��ӰѴ洢���̵Ĳ���
			if (prams != null) 
			{
				foreach (SqlParameter parameter in prams)
				{
					cmd.Parameters.Add(parameter);
				}
			}
			
			///��ӷ��ز���ReturnValue
			cmd.Parameters.Add(
				new SqlParameter(RETURNVALUE, SqlDbType.Int,4,ParameterDirection.ReturnValue,
				false,0,0,string.Empty, DataRowVersion.Default,null));

			///���ش�����SqlCommand����
			return cmd;
		}

		/// <summary>
		/// ����һ��SqlDataAdapter�����ô���ִ�д洢����
		/// </summary>
		/// <param name="procName">�洢���̵�����</param>
		/// <param name="prams">�洢�����������</param>
		/// <returns>����SqlDataAdapter����</returns>
		private SqlDataAdapter CreateProcDataAdapter(string procName,SqlParameter[] prams)
		{
			///�����ݿ�����
			Open();
			
			///����SqlDataAdapter����
			SqlDataAdapter da = new SqlDataAdapter(procName,myConnection);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;			

			///��ӰѴ洢���̵Ĳ���
			if (prams != null) 
			{
				foreach (SqlParameter parameter in prams)
				{
					da.SelectCommand.Parameters.Add(parameter);
				}
			}
			
			///��ӷ��ز���ReturnValue
			da.SelectCommand.Parameters.Add(
				new SqlParameter(RETURNVALUE, SqlDbType.Int,4,ParameterDirection.ReturnValue,
				false,0,0,string.Empty, DataRowVersion.Default,null));

			///���ش�����SqlDataAdapter����
			return da;
		}

		/// <summary>
		/// ����һ��SqlDataAdapter�����ô���ִ��SQL���
		/// </summary>
		/// <param name="cmdText">SQL���</param>
		/// <param name="prams">SQL����������</param>
		/// <returns>����SqlDataAdapter����</returns>
		private SqlDataAdapter CreateSQLDataAdapter(string cmdText,SqlParameter[] prams)
		{
			///�����ݿ�����
			Open();
			
			///����SqlDataAdapter����
			SqlDataAdapter da = new SqlDataAdapter(cmdText,myConnection);					

			///��ӰѴ洢���̵Ĳ���
			if (prams != null) 
			{
				foreach (SqlParameter parameter in prams)
				{
					da.SelectCommand.Parameters.Add(parameter);
				}
			}
			
			///��ӷ��ز���ReturnValue
			da.SelectCommand.Parameters.Add(
				new SqlParameter(RETURNVALUE, SqlDbType.Int,4,ParameterDirection.ReturnValue,
				false,0,0,string.Empty, DataRowVersion.Default,null));

			///���ش�����SqlDataAdapter����
			return da;
		}
		
		/// <summary>
		/// ���ɴ洢���̲���
		/// </summary>
		/// <param name="ParamName">�洢��������</param>
		/// <param name="DbType">��������</param>
		/// <param name="Size">������С</param>
		/// <param name="Direction">��������</param>
		/// <param name="Value">����ֵ</param>
		/// <returns>�µ� parameter ����</returns>
		public SqlParameter CreateParam(string ParamName, SqlDbType DbType, Int32 Size, ParameterDirection Direction, object Value) 
		{
			SqlParameter param;

			///��������СΪ0ʱ����ʹ�øò�����Сֵ
			if(Size > 0)
			{
				param = new SqlParameter(ParamName, DbType, Size);
			}
			else
			{
				///��������СΪ0ʱ����ʹ�øò�����Сֵ
				param = new SqlParameter(ParamName, DbType);
			}

			///����������͵Ĳ���
			param.Direction = Direction;
			if (!(Direction == ParameterDirection.Output && Value == null))
			{
				param.Value = Value;
			}

			///���ش����Ĳ���
			return param;
		}

		/// <summary>
		/// �����������
		/// </summary>
		/// <param name="ParamName">�洢��������</param>
		/// <param name="DbType">��������</param></param>
		/// <param name="Size">������С</param>
		/// <param name="Value">����ֵ</param>
		/// <returns>�µ�parameter ����</returns>
		public SqlParameter CreateInParam(string ParamName, SqlDbType DbType, int Size, object Value) 
		{
			return CreateParam(ParamName, DbType, Size, ParameterDirection.Input, Value);
		}		

		/// <summary>
		/// ���뷵��ֵ����
		/// </summary>
		/// <param name="ParamName">�洢��������</param>
		/// <param name="DbType">��������</param>
		/// <param name="Size">������С</param>
		/// <returns>�µ� parameter ����</returns>
		public SqlParameter CreateOutParam(string ParamName, SqlDbType DbType, int Size) 
		{
			return CreateParam(ParamName, DbType, Size, ParameterDirection.Output, null);
		}		

		/// <summary>
		/// ���뷵��ֵ����
		/// </summary>
		/// <param name="ParamName">�洢��������</param>
		/// <param name="DbType">��������</param>
		/// <param name="Size">������С</param>
		/// <returns>�µ� parameter ����</returns>
		public SqlParameter CreateReturnParam(string ParamName, SqlDbType DbType, int Size) 
		{
			return CreateParam(ParamName, DbType, Size, ParameterDirection.ReturnValue, null);
		}			
	}
}
