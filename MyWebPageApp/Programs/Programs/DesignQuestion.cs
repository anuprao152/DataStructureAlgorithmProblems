using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class DesignQuestion
    {

        // DATA

        // Movie        | director              | Actors

        // Matrix       |  Andy Wachowski       | Keanu Reeves
        // Matrix       |  Andy Wachowski       | Laurence Fishburne
        // Matrix       |  Andy Wachowski       | Carrie-Anne 
        // Interstellar |  Christopher Nolan    | Matthew McConaughey
        // Interstellar |  Christopher Nolan    | Anne Hathaway
        // Inception    |  Christopher Nolan    | Leonardo DiCaprio   
        // Inception    |  Christopher Nolan    | Joseph Gordon-Levitt
        // Inception    |  Christopher Nolan    | Ellen Page

        //Dictionary<String, Dictionary<String, List<String>>>

        public void Read(String[] data)
        {
            Dictionary<string, Dictionary<string, List<string>>> MoviedataDict = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < data.Length; i++)
            {
                string[] info = data[i].Split('|');

                string movie = info[0].Trim();
                string director = info[1].Trim();
                string actor = info[2].Trim();

                if (!MoviedataDict.ContainsKey(movie))
                {
                    Dictionary<string, List<string>> directorDic = new Dictionary<string, List<string>>();
                    List<string> Actors = new List<string>();

                    Actors.Add(actor);
                    directorDic.Add(director,Actors);
                    MoviedataDict.Add(movie, directorDic);
                }
                else
                {
                    Dictionary<string, List<string>> directorDic = MoviedataDict[movie];

                    if(!directorDic.ContainsKey(director))
                    {
                        List<string> Actors = new List<string>();
                        Actors.Add(actor);
                        directorDic.Add(director, Actors);
                    }
                    else
                    {
                        directorDic[director].Add(actor);
                        //Actors.Add(actor);
                        //directorDic.Add(director, actor);
                    }

                }
            }
        }

    }
}
