using System;
using System.IO;

namespace SQLHelper
{
	/// <summary>
	/// �������������ڼ�¼������־
	/// </summary>
	public class SystemError 
	{
		//��¼������־λ��
		private static string m_fileName = "c:\\Systemlog.txt";

		public static String  FileName
		{
			get
			{
				return(m_fileName);
			}
			set
			{
				if(value != null || value != "")
				{
					m_fileName = value;
				}
			}
		}

		/// <summary>
		/// ��¼��־���ı��ļ�
		/// </summary>
		/// <param name="message">��¼������</param>
		public static void CreateErrorLog(string message) 
		{
//			if(File.Exists(m_fileName))
//			{
//				///�����־�ļ��Ѿ����ڣ���ֱ��д����־�ļ�
//				StreamWriter sr = File.AppendText(FileName);
//				sr.WriteLine ("\n");
//				sr.WriteLine (DateTime.Now.ToString()+message);
//				sr.Close();
//			}
//			else
//			{
//				///������־�ļ�
//				StreamWriter sr = File.CreateText(FileName);
//				sr.Close();
//			}	
		}
	}
}
