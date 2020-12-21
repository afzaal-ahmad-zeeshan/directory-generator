using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryGenerator.Models
{
    public class Folder
    {
        public int Sequence { get; set; }
        public string Title { get; set; }
        public bool PasteContent { get; set; }

        public List<Folder> SubFolders { get; set; }
    }
}
