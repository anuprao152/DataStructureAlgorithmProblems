using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Programs
{
    public class RemoveComment
    {
        
        /* */
        /// <summary>
        /// 
        /// </summary>
        // / /  //* 
       
        //public void RemoveComment()
        //{
        //    string line;
        //    int i=0;
        //    bool commentStarted =false;
        //    bool slashComment = false;
        //    StreamReader sr = new StreamReader("");
        //    while ((line = sr.ReadLine()) != null)
        //    {
        //        while(i < line.Length)
        //        {
        //            if (line[i] == '/' && i + 1 < line.Length && line[i + 1] == '/')
        //            {
        //                slashComment = true;
        //            }
        //            if(line[i] == '/' && i+1 < line.Length &&  line[i+1] == '*')
        //            {
        //                commentStarted = true;
        //                i++;
        //            }
        //            else if (commentStarted  && line[i] == '*' && i+1 < line.Length && line[i+1]=='/')
        //            {
        //                commentStarted = false;
        //                i++;
        //            }
        //            else
        //            {
        //                if (!slashComment && !commentStarted)
        //                {
        //                    Console.Write(line[i]);

        //                }
        //                i++;
        //            }

        //        }

        //        if (slashComment)
        //            slashComment = false;

                 

        //    }

        //}
    }
}
