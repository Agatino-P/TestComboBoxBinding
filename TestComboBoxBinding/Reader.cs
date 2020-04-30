using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TestComboBoxBinding
{
    public class Reader : ObservableObject
    {
        private string _name; 
        public string Name { get => _name; set {
                if (_name != value)
                {
                    Debug.WriteLine($"Reader name changing from {_name} to { value}");
                    _name = value;
                    RaisePropertyChanged(nameof(Name));
                }
            }
        }


        private Book _book= new Book(); 
        public Book Book { get => _book; set { Set(() => Book, ref _book, value); }}

        private int _bookId;
        public int BookId { get => _bookId; set { Set(() => BookId, ref _bookId, value); }}

        public Reader(string name="Name", Book book = null, int bookId= 0)
        {
            Name = name;
            Book = book;
            BookId = bookId;
        }

    }
}
