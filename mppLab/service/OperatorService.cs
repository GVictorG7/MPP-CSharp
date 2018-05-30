using mppLab.model;
using mppLab.repo;

namespace mppLab.service
{
	class OperatorService
	{
		private OperatorDBRepo operatorDBRepo = new OperatorDBRepo();

		public bool UserExists(string nume)
		{
			foreach (Operator op in operatorDBRepo.FindAll())
			{
				if (op.Name.Equals(nume)) return true;
			}
			return false;
		}

		public string GetPass(string name)
		{
			foreach (Operator userName in operatorDBRepo.FindAll())
			{
				if (userName.Name.Equals(name)) return userName.Pass;
			}
			return null;
		}
	}
}
