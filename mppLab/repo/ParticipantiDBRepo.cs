using System.Collections.Generic;
using mppLab.model;
using MySql.Data.MySqlClient;

namespace mppLab.repo
{
	class ParticipantiDBRepo : IRepo<Participant>
	{
		private DBUtils utils;

		public ParticipantiDBRepo()
		{
			utils = new DBUtils();
		}

		public void Save(Participant participant)
		{
			utils.OpenConnection();
			int resultId = 0;
			string queryIdCurse = "SELECT id FROM curse WHERE cap = " + participant.Cap;
			MySqlCommand cmd = new MySqlCommand(queryIdCurse, utils.Connection);
			MySqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				resultId = reader.GetInt32(0);
			}
			utils.CloseConnection();

			utils.OpenConnection();
			string query = "INSERT INTO participanti VALUES(" + participant.Id + ",'" + participant.Nume + "','" + participant.Echipa + "'," + participant.Cap + "," + resultId + ")";
			MySqlCommand cmd1 = new MySqlCommand(query, utils.Connection);
            cmd1.ExecuteNonQuery();
            utils.CloseConnection();
		}

		public void Delete(int id) { }

		public Participant FindOne(int id)
		{
			return null;
		}

		public List<Participant> FindAll()
		{
			utils.OpenConnection();
			string query = "SELECT * FROM participanti";
			List<Participant> participanti = new List<Participant>();
			MySqlCommand cmd = new MySqlCommand(query, utils.Connection);
			MySqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				int idp = reader.GetInt32(0);
				string numep = reader.GetString(1);
				string echipap = reader.GetString(2);
				int capp = reader.GetInt32(3);
				int idCursap = reader.GetInt32(4);
				Participant participant = new Participant(idp, numep, echipap, capp, idCursap);
				participanti.Add(participant);
			}
			utils.CloseConnection();
			return participanti;
		}

		public List<Participant> FindByEchipa(string echipa)
		{
			List<Participant> participanti = new List<Participant>();
			utils.OpenConnection();
			string query = "SELECT * FROM participanti WHERE echipa = '" + echipa + "'";
			MySqlCommand cmd = new MySqlCommand(query, utils.Connection);
			MySqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				int id = reader.GetInt32(0);
				string nume = reader.GetString(1);
				int cap = reader.GetInt32(3);
				int idCursa = reader.GetInt32(4);
				Participant participant = new Participant(id, nume, echipa, cap, idCursa);
				participanti.Add(participant);
			}
			utils.CloseConnection();
			return participanti;
		}
	}
}
