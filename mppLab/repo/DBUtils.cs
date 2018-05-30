using MySql.Data.MySqlClient;

namespace mppLab.repo
{
	class DBUtils
	{
		public MySqlConnection Connection {
			get; set;
		}

		public DBUtils()
		{
			Initialize();
		}

		private void Initialize()
		{
			string conn = "SERVER=localhost;" + "DATABASE=curse;" + "UID=root;" + "PASSWORD=pass;";
			Connection = new MySqlConnection(conn);
		}

		public bool OpenConnection()
		{
			try
			{
				CloseConnection();
				Connection.Open();
				return true;
			}
			catch (MySqlException ex)
			{
				return false;
			}
		}

		public bool CloseConnection()
		{
			try
			{
				Connection.Close();
				return true;
			}
			catch (MySqlException ex)
			{
				return false;
			}
		}
	}
}
