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
        public string targetPath = "";
        public string state = "";
        public int fileCount = 0;
        public RunState()
        {
            count = 0;
            folderPath = "";
            targetPath = "";
            state = "";
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
        public void set_TargetPath(string targetPath)
        {
            this.targetPath = targetPath;
        }
        public string getTargetPath()
        {
            return targetPath;
        }
        public void set_State(string state)
        {
            this.state = state;
        }
        public string getState()
        {
            return state;
        }
        public void set_FileCount(int fileCount)
        {
            this.fileCount = fileCount;
        }
        public int get_FileCount()
        {
            return fileCount;
        }
    }
}
