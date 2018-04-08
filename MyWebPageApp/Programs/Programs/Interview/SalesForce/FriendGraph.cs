using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.SalesForce
{
    public class FriendGraph
    {

        public class Friend
        {
            public string Name;
            public List<Friend> InDegree;
            public List<Friend> OutDegree;
            public Boolean IsVisited;
        }

        public Dictionary<Friend, Boolean> Friends = new Dictionary<Friend, Boolean>();

        public Friend root;

        public FriendGraph()
        {

            Friend A = new Friend() { Name = "A" };
            Friend B = new Friend() { Name = "B" };
            Friend C = new Friend() { Name = "C" };
            Friend D = new Friend() { Name = "D" };
            Friend E = new Friend() { Name = "E" };
            Friend F = new Friend() { Name = "F" };
            Friend G = new Friend() { Name = "G" };
            Friend H = new Friend() { Name = "H" };
            Friend I = new Friend() { Name = "I" };
            Friend J = new Friend() { Name = "J" };

            Friends.Add(A, false); Friends.Add(B, false); Friends.Add(C, false); Friends.Add(D, false); Friends.Add(E, false);
            Friends.Add(F, false); Friends.Add(G, false); Friends.Add(H, false); Friends.Add(I, false); Friends.Add(J, false);

            root = A;

            A.InDegree = new List<Friend>(); // No InDegree
            A.OutDegree = new List<Friend> { B, C, D };
            B.InDegree = new List<Friend> { A };
            B.OutDegree = new List<Friend> { E, F };
            C.InDegree = new List<Friend> { A };
            C.OutDegree = new List<Friend> { F, G };
            D.InDegree = new List<Friend> { A };
            D.OutDegree = new List<Friend> { H };
            E.InDegree = new List<Friend> { E, I };
            E.OutDegree = new List<Friend> { F };
            F.InDegree = new List<Friend> { B, C, E };
            F.OutDegree = new List<Friend> { J };
            G.InDegree = new List<Friend> { C };
            G.OutDegree = new List<Friend>(); // No outDegree
            H.InDegree = new List<Friend> { D, I };
            H.OutDegree = new List<Friend>(); // No outdegree
            I.InDegree = new List<Friend>(); // no indegree
            I.OutDegree = new List<Friend> { E, H };
            J.InDegree = new List<Friend> { F };
            J.OutDegree = new List<Friend>(); //no outdegree


        }

        public void MakeFriend(Friend friend1, Friend friend2)
        {
            friend1.OutDegree.Add(friend1);
        }

        public void GetDirectFriend(Friend friend)
        {
            foreach (var f in friend.OutDegree)
            {
                Console.WriteLine(f.Name);
            }
        }

        public void GetIndirectFriends(Friend friend)
        {
        }

        public void RemoveFriend(Friend Friend)
        {
            TopologicalSort(Friend);

            var NotToDelete = new List<Friend>();
            foreach (var kv in Friends)
            {
                if (kv.Value == false)
                {
                    var isolatedFriend = kv.Key;

                    for (int j = 0; j < isolatedFriend.OutDegree.Count; j++)
                    {
                        var dependantUpon = isolatedFriend.OutDegree[j];
                        if (Friends[dependantUpon])
                            NotToDelete.Add(dependantUpon);
                    }

                    NotToDelete.Add(kv.Key); // not delete 
                }
            }

            ////friend don't delet with had dependancy on notReachable node
            //for (int i = 0; i < notReachable.Count; i++)
            //{
            //    var frd = notReachable[i];
            //     for (int j=0; j < frd.OutDegree.Count; j++)
            //     {
            //         var dependant = frd.OutDegree[j];
            //         if (dependant.IsVisited)
            //             notReachable.Add(dependant);
            //     }

            //}

            //isolate friends
            //for)
        }

        //post order DFS or Topological Sort
        public void TopologicalSort(Friend friend)
        {
            if (!friend.IsVisited)
            {
                friend.IsVisited = true;
                Friends[friend] = true;

                for (int i = 0; i < friend.OutDegree.Count; i++)
                {
                    TopologicalSort(friend.OutDegree[i]);
                }
            }
        }


    }
}
