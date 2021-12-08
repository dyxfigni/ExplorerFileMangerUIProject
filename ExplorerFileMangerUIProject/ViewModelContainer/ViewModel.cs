using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ExplorerFileMangerUIProject.Annotations;

namespace ExplorerFileMangerUIProject.ViewModelContainer
{
    class BaseViewModel : INotifyPropertyChanged
    {
        #region PropertyChanged
        //Реализация Проперти чанджет
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }

    class ViewModel : BaseViewModel
    {
        public ViewModel()
        { 
            //Directory.GetDirectoryRoot(RootDiskName);
            //RootDiskName = Directory.GetDirectoryRoot(RootDiskName);

            DirAndFls = new ObservableCollection<string>();
            foreach (var logicalDrive in Directory.GetLogicalDrives())
            {
                DirAndFls.Add(logicalDrive);
            }
        }

        #region Properties
        /// проперти чанджет требуется для диска,
        /// чтобы отслеживать
        /// изменения или
        /// открытие для отображение во вьюшке
        
        
        public string DirFlPath { get; set; }

        public ObservableCollection<string> DirAndFls { get; set; }

        private string _rootDiskName;

        public string RootDiskName
        {
            get => _rootDiskName;
            set { _rootDiskName = value; OnPropertyChanged(nameof(RootDiskName)); }
        }
        #endregion
    }

    class DirViewModel :FileInfViewModel
    {

    }
    
    class FlViewModel: FileInfViewModel
    {
        
    }


    class FileInfViewModel : BaseViewModel
    {
        
    }
}