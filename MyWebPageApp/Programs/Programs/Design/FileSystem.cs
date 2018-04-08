using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public enum accessType { readOnly, writeOnly }
    public class MyFile
    {
        public string fileName;
        public string extension;
        public DateTime creation;
        public accessType acesssibility;

        public void rename()
        {
        }

    }

    public class MyDirectory
    {
        public List<MyFile> files;
        public List<MyDirectory> directories;

        //public void CreateDirectory(MyDirectory dir) { }
        //public void Copy(MyFile file) { }
    }

    public class MyFileSystem
    {
        public MyDirectory rootDir;
        public MyDirectory current;

        public MyFileSystem()
        {
            rootDir = new MyDirectory();
            current = rootDir;
        }

        public void CreateDir(MyDirectory dir)
        {
            current.directories.Add(dir);
        }

        public void copyfile(MyFile file)
        {
            current.files.Add(file);
        }

        public MyDirectory findDir()
        {
            MyDirectory dir = null;
            return dir;
        }

        public MyFile findFile()
        {
            MyFile file = null;
            return file;
        }
    }
}
