using System.Collections.Generic;
using mppLab.model;
using MySql.Data.MySqlClient;

namespace mppLab.repo
{
	class CurseDBRepo : IRepo<Cursa>
	{
		private DBUtils utils;

		public CurseDBRepo()
		{
			utils = new DBUtils();
		}

		public void Save(Cursa cursa) { }

		public void Delete(int id) { }

		public Cursa FindOne(int id)
		{
			utils.OpenConnection();
			string query = "SELECT * FROM curse WHERE id = " + id;
			MySqlCommand cmd = new MySqlCommand(query, utils.Connection);
			MySqlDataReader reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				int idc = reader.GetInt32(0);
				int capc = reader.GetInt32(1);
				Cursa cursa = new Cursa(idc, capc);
				if (cursa != null)
				{
					utils.CloseConnection();
					return cursa;
				}
			}
			utils.CloseConnection();
			return null;
		}

		public List<Cursa> FindAll()
		{
			utils.OpenConnection();
			string query = "SELECT * FROM curse";
			List<Cursa> curse = new List<Cursa>();
			MySqlCommand cmd = new MySqlCommand(query, utils.Connection);
			MySqlDataReader reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				int idc = reader.GetInt32(0);
				int capc = reader.GetInt32(1);

				Cursa cursa = new Cursa(idc, capc);
				curse.Add(cursa);
			}

			return curse;
		}
	}
}
