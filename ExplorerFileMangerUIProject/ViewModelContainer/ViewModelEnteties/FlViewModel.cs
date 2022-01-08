using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorerFileMangerUIProject.ViewModelContainer.ViewModelEnteties
{
    public sealed class FlViewModel : FileInfViewModel
    {
        

        public FlViewModel(string fileName) : base(fileName)
        {
           
        }

        public FlViewModel(FileInfo fileName) : base(fileName.Name)
        {
            FullName = fileName.FullName;
        }
    }
}
