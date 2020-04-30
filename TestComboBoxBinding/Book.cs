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
        public string Title { get => _title; set { Set(() => Title, ref _title, value); }}

        private string _displayTitle;
        public string DisplayTitle { get => $"{Id} - {Title}"; set { Set(() => DisplayTitle, ref _displayTitle, value); }}

        public Book(int id = 0, string title="Title")
        {
            Id = id;
            Title = title;
        }

    }

}
