using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public enum statusType { online, offline, ideal };
    public class user
    {
        public int id;
        public string userName;
        public string password;
        public statusType status;
    }

    public class mySession
    {
       public List<user> users;

       public void Display(user user)
       {
           //display user message
       }
        
    }


    public class ChatServer
    {
        public mySession curSession;

        public void login(user user)
        {
            curSession.users.Add(user);
        }

    }
}
