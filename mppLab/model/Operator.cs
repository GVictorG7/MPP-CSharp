namespace mppLab.model
{
	class Operator
	{
		public int Id {
			get;
		}

		public string Name {
			get;
		}

		public string Pass {
			get;
		}

		public Operator(int id, string name, string pass)
		{
			Id = id;
			Name = name;
			Pass = pass;
		}
	}
}
