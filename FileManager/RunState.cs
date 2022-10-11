using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
     class RunState
    {
        public int count = 0;
        public string folderPath = "";
        public RunState()
        {
            count = 0;
            folderPath = "";
        }
        public void set_Count(int count)
        {
            this.count = count;
        }
        public int get_Count()
        {
            return count;
        }
        public void set_FolderPath(string folderPath)
        {
            this.folderPath = folderPath;
        }
        public string get_FolderPath()
        {
            return folderPath;
        }
    }
}
