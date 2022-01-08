using ExplorerFileMangerUIProject.ViewModelContainer.ViewModelEnteties;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ExplorerFileMangerUIProject.ViewModelContainer
{


    class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            foreach (var logicalDrive in Directory.GetLogicalDrives())
            {
                DirAndFls.Add(new DirViewModel(logicalDrive));
            }

            OpenCommand = new CommandDoubleClick(Open);
        }

        #region Properties
        public string DirFlPath { get; set; }

        public FileInfViewModel SelectedFileInfViewModel { get; set; }

        public ObservableCollection<FileInfViewModel> DirAndFls = new ObservableCollection<FileInfViewModel>();

        private string _rootDiskName;

        public string RootDiskName
        {
            get => _rootDiskName;
            set { _rootDiskName = value; OnPropertyChanged(nameof(RootDiskName)); }
        }
        #endregion

        #region Events

        

        #endregion

        #region Commands

        public ICommand OpenCommand { get; set; }

        private void Open(object parameter)
        {
            if (parameter is DirViewModel dirViewModel)
            {
                DirFlPath = dirViewModel.FullName;

                DirAndFls.Clear();

                var DirectoryInfo = new DirectoryInfo(DirFlPath);

                foreach (var dir in DirectoryInfo.GetDirectories())
                {
                    DirAndFls.Add(new DirViewModel(dir));
                }
                foreach (var file in DirectoryInfo.GetFiles())
                {
                    DirAndFls.Add(new FlViewModel(file));
                }
            }
        }

        #endregion
    }
}