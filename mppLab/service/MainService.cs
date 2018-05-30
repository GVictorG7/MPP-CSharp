using System.Collections.Generic;
using mppLab.repo;
using mppLab.model;

namespace mppLab.service
{
	class MainService
	{
		private CurseDBRepo repoCurse = new CurseDBRepo();
		private OperatorDBRepo repoOperatori = new OperatorDBRepo();
		private ParticipantiDBRepo repoParticipanti = new ParticipantiDBRepo();

		public void SavePartcipant(int id, string nume, string echipa, int cap, int idCursa)
		{
			repoParticipanti.Save(new Participant(id, nume, echipa, cap, idCursa));
		}

		public List<Cursa> GetCurse()
		{
			return repoCurse.FindAll();
		}

		public List<Participant> GetParticipanti()
		{
			return repoParticipanti.FindAll();
		}

		public List<string> GetEchipe()
		{
			List<string> echipe = new List<string>();
			foreach (Participant p in repoParticipanti.FindAll())
			{
				if (!echipe.Contains(p.Echipa)) echipe.Add(p.Echipa);
			}
			return echipe;
		}

		public List<int> GetCap()
		{
			List<int> cap = new List<int>();
			foreach (Cursa c in repoCurse.FindAll())
			{
				if (!cap.Contains(c.Cap)) cap.Add(c.Cap);
			}
			return cap;
		}

		public List<Participant> GetByEchipa(string echipa)
		{
			return repoParticipanti.FindByEchipa(echipa);
		}
	}
}
