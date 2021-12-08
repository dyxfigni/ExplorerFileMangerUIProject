using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ExplorerFileMangerUIProject.Annotations;

namespace ExplorerFileMangerUIProject.ViewModelContainer
{
    /// <summary>
    /// 
    /// </summary>
    class ViewModel : INotifyPropertyChanged
    {
        //public ViewModel()
        //{
        //    Directory.GetDirectoryRoot(RootDiskName);
        //    RootDiskName = Directory.GetDirectoryRoot(RootDiskName);

        //}
        public ViewModel()
        {
            RootDiskName = Directory.GetDirectoryRoot(@"E:\\Книги");
        }


        private string _rootDiskName;

        public string RootDiskName
        {
            get => _rootDiskName;
            set { _rootDiskName = value; OnPropertyChanged(nameof(RootDiskName)); }
        }

        #region PropertyChanged
        //Реализация Проперти чанджет
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        /// <summary>
        /// проперти чанджет требуется для диска,
        /// чтобы отслеживать
        /// изменения или
        /// открытие для отображение во вьюшке
        /// </summary>

        
    }
}
