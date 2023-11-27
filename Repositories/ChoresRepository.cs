using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoreScore.Repositories
{
    public class ChoresRepository
    {
        private List<Chore> _chores;
        public ChoresRepository()
        {
            _chores = [
                new Chore(1, "dishes", false, 15),
                new Chore(2, "homework", false, 60),
                new Chore(3, "laundry", true, 30)
            ];
        }

        internal Chore GetChoreById(int choreId)
        {
            Chore foundChore = _chores.Find(chore => chore.Id == choreId);
            return foundChore;
        }

        internal List<Chore> GetChores()
        {
            return _chores;
        }
    }
}