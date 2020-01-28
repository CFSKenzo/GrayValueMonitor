using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrayValueMonitor
{
    class FolderMonitor
    {
        public delegate void Delegate_DetectCreatedFolder(string f_DateTime, string f_FolderPath);
        public event Delegate_DetectCreatedFolder Event_DetectCreateFolder = null;

        private static System.IO.FileSystemWatcher  m_FileSystemWatcher = null;
        private static readonly FolderMonitor m_This = new FolderMonitor();
        public static FolderMonitor GetFolderMonitor()
        {
            return m_This;
        }
        private FolderMonitor()
        {
            if (m_This == null)
            {
                m_FileSystemWatcher = new System.IO.FileSystemWatcher();
                m_FileSystemWatcher.Filter = "*.*";
                m_FileSystemWatcher.Created += new System.IO.FileSystemEventHandler(FileSystemWatcher_Created);
                m_FileSystemWatcher.IncludeSubdirectories = true;
                m_FileSystemWatcher.EnableRaisingEvents = false;
            }
        }
        public void StartMonitor(string f_Path)
        {
            if (System.IO.Directory.Exists(f_Path) == true)
            {
                m_FileSystemWatcher.EnableRaisingEvents = false;
                m_FileSystemWatcher.Path = f_Path;
                m_FileSystemWatcher.EnableRaisingEvents = true;
            }
        }

        private void FileSystemWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            try
            {
                if (System.IO.Directory.Exists(e.FullPath) == true)
                {
                    Event_DetectCreateFolder(DateTime.Now.ToString("yyyyMMdd-HHmmss-fff"), e.FullPath);
                }
            }
            catch(Exception Ex)
            {
            }
            return;// throw new NotImplementedException();
        }

        internal void StopMonitor()
        {
            m_FileSystemWatcher.EnableRaisingEvents = false;
        }
    }
}
