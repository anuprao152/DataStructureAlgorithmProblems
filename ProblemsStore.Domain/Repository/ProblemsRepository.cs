using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemsStore.Domain.Entities;
using ProblemsStore.Domain.Repository;
using System.Data.Entity;

namespace ProblemsStore.Domain.Repository
{
    public class ProblemsRepository
    {
        private static GeneralRepository<Problems> problemRepo;
        private static MyDBContext myDBContext = new MyDBContext();

        private ProblemsRepository(){}

        public static GeneralRepository<Problems> ProblemRepository
        {
            get
            {
                if (problemRepo == null)
                {
                    problemRepo = new GeneralRepository<Problems>(myDBContext);
                }
                return problemRepo;
            }
        }

        public IQueryable<Problems> GetALL()
        {
            return ProblemRepository.GetALL();
        }
    }
}
