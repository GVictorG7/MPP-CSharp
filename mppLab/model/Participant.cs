namespace mppLab.model
{
	class Participant
	{
		public int Id {
			get;
		}

		public string Nume {
			get;
		}

		public string Echipa {
			get;
		}

		public int Cap {
			get;
		}

		public int IdCursa {
			get;
		}

		public Participant(int id, string nume, string echipa, int cap, int idCursa)
		{
			Id = id;
			Nume = nume;
			Echipa = echipa;
			Cap = cap;
			IdCursa = idCursa;
		}
	}
}
