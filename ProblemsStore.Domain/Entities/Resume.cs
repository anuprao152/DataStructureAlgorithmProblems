using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProblemsStore.Domain.Entities
{
    public class Resume : Entity
    {
        public Person Person { get; set; }
        
        public string Objective {get; set;}

 
        public ICollection<University> Universities {get; set;}
        public ICollection<string> ProfessionalSummary {get; set;}
        public ICollection<Jobs> jobs {get; set;}
        public ICollection<Certification> Certifications { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Skill> Skills { get; set; }

        public ICollection<string> Courses { get; set; }

        public Resume()
        {
        }
    }

    [NotMapped]
    public class University : Entity
    {
        public string UnivName {get; set;}
        public string GPA {get; set;}
        public string GradDate {get; set;}
        public string Address { get; set; }
        public string Degree { get; set; }
    }

    public class Jobs : Entity
    {
        public string Company { get; set; }
        [DisplayFormat(DataFormatString = "{0:Y}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:Y}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
        public string Position { get; set; }
        public string Location { get; set; }

        [NotMapped]
        public ICollection<Technology> Technologies { get; set; }

        [NotMapped]
        public ICollection<string> Responsibilities { get; set; }
    }


    public class Project : Entity
    {
        public string ProjName { get; set; }
        public string ProjMetaInfo { get; set; }
        public string ProjDesc { get; set; } 
    }

    public class Certification : Entity
    {
        public string Name {get; set;}
        public string Passyear {get; set;}
    }

    //My Skills
    [NotMapped]
    public class Skill : Entity
    {
        public string Name { get; set; }
        
        public ICollection<Technology> Techs { get; set; }
    }

    public class Technology : Entity
    {
        public string Name { get; set; }
        //public int FKTechnologyId { get; set; }
       //public Jobs job { get; set; }
    }

    //Ignore this Entity in Creation of Model
    [NotMapped]
    public class Person : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}


//About Me

//Contact

//USE SOCIAL NETWORKING WEBSITES

//View My Recent Work