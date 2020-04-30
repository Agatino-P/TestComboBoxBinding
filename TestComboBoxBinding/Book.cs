using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;

namespace TestComboBoxBinding
{
    public class Book : ObservableObject
    {
        private int _id; 
        public int Id { get => _id; set { Set(() => Id, ref _id, value); }}

        private string _title;
        public string Title { get => _title; set {
                if (_title != value)
                {
                    _title= value;
                    RaisePropertyChanged(nameof(Title));
                    RaisePropertyChanged(nameof(DisplayTitle));
                }
            }
        }


        public string DisplayTitle => $"{Id} - {Title}";

        public Book(int id = 0, string title="Title")
        {
            Id = id;
            Title = title;
        }

    }

}
