using System;
using System.Data;
using System.Data.SqlClient;

namespace SQLHelper
{
	/// <summary>
	/// �Զ���Exception
	/// </summary>
	public class SystemException:Exception
	{
		/// <summary>
		/// ����ϵͳExcepton
		/// </summary>
		public SystemException(string source,string message,Exception inner):base(message,inner)
		{
			base.Source=source;
		}

		/// <summary>
		/// ������ϵͳExcepton
		/// </summary>			
		public SystemException(string source,string message):base(message)
		{
			base.Source=source;
		}
	}

	/// <summary>
	/// ������ҳ�е�HTML���룬������Σ���ַ�
	/// </summary>
	public class SystemHTML
	{
		private static string HTMLEncode(string fString)
		{
			if(fString!=string.Empty)
			{
				///�滻������
				fString.Replace("<","&lt;");
				fString.Replace(">","&rt;");
				///�滻����
				fString.Replace(((char)34).ToString(), "&quot;");
				fString.Replace(((char)39).ToString(), "&#39;");
				///�滻�ո�
				fString.Replace(((char)13).ToString(), "");
				///�滻���з�
				fString.Replace(((char)10).ToString(), "<BR> ");
			}
			return(fString);
		}
	}
   

	/// <summary>
	/// SystemTools ��ժҪ˵����
	/// </summary>
	public class SystemTools
	{		
		/// <summary>
		/// ��DataReaderתΪDataTable
		/// </summary>
		/// <param name="DataReader">DataReader</param>
		public static DataTable ConvertDataReaderToDataTable(SqlDataReader dataReader)
		{
			///����DataTable
			DataTable datatable = new DataTable();					
			
			try
			{	///��̬��ӱ��������
				for(int i = 0; i < dataReader.FieldCount; i++)
				{
					DataColumn myDataColumn = new DataColumn();
					myDataColumn.DataType = dataReader.GetFieldType(i);
					myDataColumn.ColumnName = dataReader.GetName(i);
					datatable.Columns.Add(myDataColumn);
				}	
			
				///��ӱ������
				while (dataReader.Read())
				{
					DataRow myDataRow = datatable.NewRow();
					for (int i = 0; i < dataReader.FieldCount; i++)
					{
						myDataRow[i] = dataReader[i].ToString();
					}
					datatable.Rows.Add(myDataRow);
					myDataRow = null;
				}              
				///�ر����ݶ�ȡ��
				dataReader.Close();
				return datatable;
			}
			catch(Exception ex)
			{				
				///�׳�����ת������
				SystemError.CreateErrorLog(ex.Message);
				throw new Exception(ex.Message,ex);				
			}			
		}
	}
}
