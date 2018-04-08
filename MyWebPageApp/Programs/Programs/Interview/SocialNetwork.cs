using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{
    public class Course
    {
        public String Name { get; set; }
       
    }

    //Amazon Interview
    public class SocialNetwork
    {

      public List<String> getRankedCourses(String user) {
       
      List<String> directFriends = getDirectFriendsForUser(user); //direct friends
      List<String> graph = new List<String>();
       
      //Traverse till 2 levels
      foreach(String friend in directFriends) 
      {
         graph.Add(friend);
         List<String> indirectFriends = getDirectFriendsForUser(friend); //2nd level friends
          
         foreach(String friendOfFriend in indirectFriends) {
            if(friendOfFriend == user) // cycle exist so check for user itself and avoid
            {
               graph.Add(friendOfFriend);
            }
         }
      }
       
      Dictionary<String,String> userCourses = getAttendedCoursesForUser(user);
      Dictionary<Course, int> dict = new Dictionary<Course, int>();
      
      foreach(String friend in graph) {
          
         Dictionary<String,String> courses = getAttendedCoursesForUser(friend);
          
         foreach(String course in courses.Keys) {
            if(!userCourses.ContainsKey(course)) {
               Course crc = new Course(){ Name = course};
                
               if(dict.ContainsKey(crc)) {
                   dict[crc]++;
                 
               }
               else {
                  dict.Add(crc,1);
               }
               Console.Out.Write("Adding course " + crc + " with value " + dict[crc]);
                
            }    
         }
          
      }
    
       return dict.Select(kvp => kvp.Key.Name).ToList();
       
   }

      private Dictionary<string,string> getAttendedCoursesForUser(string user)
      {
          throw new NotImplementedException();
      }

      private List<string> getDirectFriendsForUser(string user)
      {
          throw new NotImplementedException();
      }

    }
}
