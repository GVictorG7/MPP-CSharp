using System.Collections.Generic;

namespace mppLab.repo
{
	interface IRepo<E>
	{
		void Save(E entity);

		void Delete(int id);

		E FindOne(int id);

		List<E> FindAll();
	}
}
