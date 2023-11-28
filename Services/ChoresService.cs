using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoreScore.Services
{
    public class ChoresService
    {
        private readonly ChoresRepository _choresRepository;
        public ChoresService(ChoresRepository choresRepository)
        {
            _choresRepository = choresRepository;
        }

        internal Chore CreateChore(Chore choreData)
        {
            if (choreData.Name == null)
            {
                throw new Exception("Please provide a chore name");
            }
            Chore chore = _choresRepository.CreateChore(choreData);
            return chore;
        }

        internal Chore GetChoreById(int choreId)
        {
            Chore chore = _choresRepository.GetChoreById(choreId);

            if (chore == null)
            {
                throw new Exception($"Invalid id: {choreId}");
            }
            return chore;
        }

        internal List<Chore> GetChores()
        {
            List<Chore> chores = _choresRepository.GetChores();
            return chores;
        }
    }
}