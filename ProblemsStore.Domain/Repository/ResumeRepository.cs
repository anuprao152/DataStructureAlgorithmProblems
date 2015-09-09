using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemsStore.Domain.Entities;
using ProblemsStore.Domain.Repository;

namespace ProblemsStore.Domain.Repository
{
    public class ResumeRepository: GeneralRepository<Resume>
    {
        public Resume resume { get; set; }

        public ResumeRepository(MyDBContext context) :base (context)
        {
            Person per = new Person();
            //per.Name = "Anup Rao";
            //per.Address = "311 GUY PARK AVE, AMSTERDAM, NY 12010";
            //per.Email = "anuprao85@gmail.com";
            //per.Phone = "585-319-6852";

            List<Technology> Technologies = new List<Technology>{
                                                    new Technology { Name = "C# 4.0"}, new Technology { Name = ".Net 4.5"}, new Technology { Name = "Enitiy Framwork 4.0"},
                                                    new Technology { Name = "IIS 7.0"}, new Technology { Name = "MVC 4"}, new Technology { Name = "SQL SERVER 2012"},
                                                    new Technology { Name = "VS 2012"}, new Technology { Name = "TFS"},  new Technology { Name =  "MVC 3"}, 
                                                    new Technology { Name ="VS 2010" }, new Technology { Name =  "C# 3.0" }, new Technology { Name ="ADO.Net"}
            };

            Technologies.ForEach(t => context.Technologies.Add(t));
            context.SaveChanges();

            List<Jobs> Jobs = new List<Jobs>{
                new Jobs { Company ="AIR Worldwide", StartDate=DateTime.Parse("2014-01-28") , EndDate = DateTime.Now, Position = "Software Engineer II", 
                           Location="Boston, MA", 
                           Technologies = new List<Technology>(),
                           Responsibilities = new List<string>
                           {
                              "Working on MVC Web Application front end development using HTML, CSS, JavaScript, Ajax and JQuery.",
                              "Working on WPF Project. Use MVVM pattern for Binding. Use Infragistics controls.",
                              "Developed and Consumed WCF Services. Used Entity Framework to generate DAL.",
                              "All the development uses C# 4.0, .Net 4.5, MVC 4, Entity Framework",
                              "Responsible for writing unit tests and integration tests.",
                              "Learning and implementing application using   Angular.Js.",
                           }
                },

                new Jobs { Company = "Amsterdam Printing & Litho" , StartDate=DateTime.Parse("2011-06-01") , EndDate = DateTime.Parse("2014-01-24"), Position = "Web Developer", 
                           Location="Amsterdam, NY", 
                           Technologies = new List<Technology>(),
                           Responsibilities = new List<string>
                           {
                              "Working on the highly available E-Commerce Web Applications of Company and its brands to promote and sell company products.",
                              "Redesigned the Shopping Cart and Added Wish list Cart to increase customer usability and increase the Sells",
                              "Implemented HTTP Handlers for the performance boost and returned data in Jason Format.",
                              "Internalize Admin tools only to company's intranet and Redesigned it. Used integrated authentication to access it on intranet.",
                              "Created WCF service that performs folder scan and image scan. Created various Custom Controls.",
                              "Developed Front-End development skills that include CSS, HTML, Jquery, JavaScript and Ajax.", 
                              "Responsible for Quality testing and publishing code on production and live Server.",
                              "All The Development uses C# 4.0, .Net 4.5 Framework, MVC 4, EF 4.3, VS 2012.",
                              "Web Hosting IIS 6.0 and Team Foundation Server for Version control."
                           }
                },

                  new Jobs { Company = "Direct 2 Market Sales Solution (D2MSS)" , StartDate=DateTime.Parse("2010-04-01") , EndDate = DateTime.Parse("2010-06-29"), Position = "Software Developer Co-op", 
                           Location="Rochester, NY", 
                           Technologies = new List<Technology>(),
                           Responsibilities = new List<string>
                           {
                              "Developed MVC 3 application in C# LINQ to SQL (ORM) to populate business entity.",
                              "Gained experience in .Net Framework 4.0, Razor view engine, Entity Framework and TDD. "
                           }
                  },

                   new Jobs { Company = "System Development Group (SDG)" , StartDate=DateTime.Parse("2009-06-01") , EndDate = DateTime.Parse("2009-11-30"), Position = "Software Developer Co-op", 
                           Location="Utica, NY", 
                           Technologies = new List<Technology>(), 
                           Responsibilities = new List<string>
                           {
                              "Created image proxy service that runs of thread timer to poll the property image request and send property images to end user.(multi thread programming in C#)",
                              "Created WCF Services responsible for communicating and providing real time data from integrated server to client application.",
                              "Developed a module for SDG’s Apex Sketch Indexer application to work with file system with extensive use of LINQ to SQL. The product is developed using C# and XAML as a language using WPF technology",
                           }
                  },

                   new Jobs { Company = "RISHABH SOFTWARE" , StartDate=DateTime.Parse("2007-07-01") , EndDate = DateTime.Parse("2008-07-30"), Position = "Web Developer", 
                           Location="Vadodara, India", 
                           Technologies = new List<Technology>(), 
                           Responsibilities = new List<string>
                           {
                              "Windows client (Win Forms) implemented in C# in the .Net Framework 3.5 used for back-office processing.",
                              "Used ADO.Net with SQL Server 2005 back-end and T/SQL stored procedures.",
                           }
                  }

            };

            //Jobs.ForEach(j => context.Jobs.Add(j));
            //context.SaveChanges();

            Jobs[0].Technologies.Add(Technologies[0]);
            Jobs[0].Technologies.Add(Technologies[1]);
            Jobs[0].Technologies.Add(Technologies[2]);
            Jobs[0].Technologies.Add(Technologies[3]);
            Jobs[0].Technologies.Add(Technologies[4]);
            Jobs[0].Technologies.Add(Technologies[5]);
            Jobs[0].Technologies.Add(Technologies[6]);
            Jobs[0].Technologies.Add(Technologies[7]);
            Jobs[1].Technologies.Add(Technologies[0]);
            Jobs[1].Technologies.Add(Technologies[1]);
            Jobs[1].Technologies.Add(Technologies[8]);
            Jobs[1].Technologies.Add(Technologies[9]);


            List<Project> Projects = new List<Project>{
                new Project{ ProjMetaInfo = "Master Capstone Project" , ProjName="Frequent Pattern Mining employing dynamic programing and dominant point approach(C# .Net Console Application)",
                   ProjDesc = "The goal of the project was to find frequent patterns in a large dataset using candidate generation technique that employs LCS and MLCS " +
                              "(multiple longest common sub-sequence) with a fundamental Apriori algorithm of association mining."},
                   //new Project{ ProjMetaInfo = "" , ProjName="DLL injection (Win32 Programming)" ,
                   //ProjDesc = "The goal of the project was to implement malware and hide its functionality to avoid detection." +
                   //           "DLL injection is a kind of spyware that injects itself to legitimate window process and operates from that process so that normal user will not suspect its presence."},
                   //new Project{ ProjMetaInfo = "JAVA Project" , ProjName="Extend open Source H2 Database (Database System Implementation Project)" ,
                   //ProjDesc = "Successfully added new support, Basic Cost Sensitive cache replacement algorithm (BCL) and Dynamic Cost Sensitive Cache replacement algorithm (DCL) which replaced LRU algorithm."},
                   //new Project{ ProjMetaInfo = "Matlab Project" , ProjName="Face Detection (Computer Vision- Image Processing Project)" ,
                   //ProjDesc = "Developed and implemented a color based technique for detecting frontal human faces in images."},
            };

            //Projects.ForEach(p => context.Projects.Add(p));
            //context.SaveChanges();

            List<Certification> Certifications = new List<Certification>{
                new Certification { Name= "Microsoft .Net Framework 3.5, ASP.Net Application Development" },
                new Certification { Name= "Microsoft .Net Framework, Application Development Foundation."}
            };

            //Certifications.ForEach( c => context.Certifications.Add(c));
            //context.SaveChanges();

            List<University> Univs = new List<University>{
                new University { Degree="Master of Science in Computer Science", UnivName ="Rochester Institute of Technology", Address="Rochester, NY", GPA ="3.04", GradDate="May 2011"},
                new University { Degree ="Bachelor of Engineering in Computer Engineering", UnivName ="Sardar Patel University", Address="Vallabh Vidhyanagar, Gujarat", GPA ="3.12", GradDate="May 2007",}
            };

            List<Skill> Skills = new List<Skill>{ new Skill { Name =".Net 4.5" }, new Skill { Name ="C# 4.0" }, new Skill { Name ="MVC 4" }, new Skill { Name ="Enitity Framework" },
                                        new Skill { Name ="REST" }, new Skill { Name ="JavaScript" }, new Skill { Name ="JQuery" }, new Skill { Name ="SQL Server" }, new Skill { Name ="WCF" },
                                        new Skill { Name ="WPF" }, new Skill { Name="HTML" }, new Skill { Name="CSS"}, new Skill{Name="Angular.Js"}
            };


            resume= new Resume();
            resume.Objective = "Expert Software Engineer offering 6 years in the field of software development and Information Technology with a focus on product design and development." +
                              "In-depth understanding of web technologies with a focus on delivering innovative business solutions";
            resume.Person = per;
            resume.Universities = Univs;
            resume.ProfessionalSummary = new List<string>();
            resume.Projects = Projects;
            resume.Certifications = Certifications;
            resume.jobs = Jobs;
            //resume.Skills = new List<Skill>();
            resume.Skills = Skills;
            resume.Courses = new List<string>();
        }

        public void CreateResume()
        {
            //insert(resume);
            //save();
        }

    }
}
