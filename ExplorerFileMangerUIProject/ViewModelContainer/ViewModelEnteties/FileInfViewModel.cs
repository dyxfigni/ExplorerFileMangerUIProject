using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorerFileMangerUIProject.ViewModelContainer.ViewModelEnteties
{
    public abstract class FileInfViewModel : BaseViewModel
    {
        public string Name { get; }

        public string FullName { get; set; }

        protected FileInfViewModel(string name)
        {
            Name = name;
        }
    }
}
