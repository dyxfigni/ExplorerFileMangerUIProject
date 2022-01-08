using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExplorerFileMangerUIProject.ViewModelContainer.ViewModelEnteties
{
    public class BaseViewModel : INotifyPropertyChanged
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
}
