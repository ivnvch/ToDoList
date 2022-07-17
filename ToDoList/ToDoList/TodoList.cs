using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class List: INotifyPropertyChanged
    {
        public DateTime CreateDate { get; set; } = DateTime.Now;
        private bool _isDone;
        private string _notes;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void IsPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool IsDone
        {
            get { return _isDone; }
            set 
            {
                if (IsDone == value)
                    return;
                _isDone = value;
                IsPropertyChanged(nameof(IsDone));
            }
        }

        public string Notes
        {
            get { return _notes; }
            set {
                if (_notes == value)
                    return;
                _notes = value;
                IsPropertyChanged("Notes");
            }
        }


    }
}
