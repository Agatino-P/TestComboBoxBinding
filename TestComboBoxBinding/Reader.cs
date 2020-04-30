using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestComboBoxBinding
{
    public class Reader : ObservableObject
    {
        private string _name; 
        public string Name { get => _name; set { Set(() => Name, ref _name, value); }}

        private int _bookId;
        public int BookId { get => _bookId; set { Set(() => BookId, ref _bookId, value); }}

        public Reader(string name="Name", int bookId= 0)
        {
            Name = name;
            BookId = bookId;
        }

    }
}
