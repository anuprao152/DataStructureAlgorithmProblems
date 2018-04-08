using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemsStore.Domain.Entities;
using ProblemsStore.Domain.Repository;

namespace ProblemsStore.Domain.Repository
{
    //This UnitofWork creates the Repository for everyType and 
    public class UnitofWork
    {
        private MyDBContext myDBContext = new MyDBContext();
        private ResumeRepository resumeRepository;
        //private GeneralRepository<Problems> problemRepository;

        //Create the Repository only one time otherwise return reference of it.
        public ResumeRepository ResumeRepository
        {
            get
            {
                if (resumeRepository == null)
                {
                    resumeRepository = new ResumeRepository(myDBContext);
                }
                return resumeRepository;
            }
        }

        //Create the Repository only one time otherwise return reference of it.
        //public GeneralRepository<Problems> ProblemRepository
        //{
        //    get
        //    {
        //        if (problemRepository == null)
        //        {
        //            problemRepository = new GeneralRepository<Problems>(myDBContext);
        //        }
        //        return problemRepository;
        //    }
        //}
    }
}
