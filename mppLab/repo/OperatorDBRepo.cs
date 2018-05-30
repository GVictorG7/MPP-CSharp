using System.Collections.Generic;
using mppLab.model;
using MySql.Data.MySqlClient;

namespace mppLab.repo
{
	class OperatorDBRepo
	{
		private DBUtils utils;

		public OperatorDBRepo()
		{
			utils = new DBUtils();
		}

		public List<Operator> FindAll()
		{
			string query = "SELECT * FROM operatori";
			List<Operator> operatori = new List<Operator>();
			utils.OpenConnection();
			MySqlCommand cmd = new MySqlCommand(query, utils.Connection);
			MySqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				int id = reader.GetInt32(0);
				string name = reader.GetString(1);
				string pass = reader.GetString(2);
				Operator operatorN = new Operator(id, name, pass);
				operatori.Add(operatorN);
			}
			utils.CloseConnection();
			return operatori;
		}
	}
}
