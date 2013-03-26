using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenStack
{
    interface Authenticate
    {
        public virtual String Authenticate();
        public virtual Boolean CreateFolder(String foldername);
        public virtual Boolean DeleteFolder(String foldername);
        public virtual void ListFolders();
        public virtual Boolean UploadFile(String foldername);
        public virtual Boolean DownloadFile(String filename);
        public virtual Boolean DeleteFile(String foldername);
        public virtual void ListFiles();


    }
}
