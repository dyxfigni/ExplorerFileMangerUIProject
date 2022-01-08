using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorerFileMangerUIProject.ViewModelContainer.ViewModelEnteties
{
    public sealed class DirViewModel : FileInfViewModel
    {

        public DirViewModel(string dirName) : base(dirName)
        {
            FullName = dirName;
        }
        public DirViewModel(DirectoryInfo dirName) : base(dirName.Name)
        {
            FullName = dirName.FullName;
        }
    }
}
