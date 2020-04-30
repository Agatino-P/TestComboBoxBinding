using System.Collections.Generic;
using System.Windows;

namespace TestComboBoxBinding
{


    public partial class MainWindow : Window
    {


        public List<Book> Books
        {
            get => (List<Book>)GetValue(BooksProperty);
            set => SetValue(BooksProperty, value);
        }
        public static readonly DependencyProperty BooksProperty =
            DependencyProperty.Register("Books", typeof(List<Book>), typeof(MainWindow), new PropertyMetadata(null));


        public Reader BoundReader
        {
            get => (Reader)GetValue(BoundReaderProperty);
            set => SetValue(BoundReaderProperty, value);
        }
        public static readonly DependencyProperty BoundReaderProperty =
        DependencyProperty.Register("BoundReader", typeof(Reader), typeof(MainWindow), new PropertyMetadata(null));

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            loadStartingData();
        }

        private void loadStartingData()
        {
             Books = new List<Book>();
            Books.Add(new Book(1, "Uno"));
            Books.Add(new Book(2, "Due"));
            Books.Add(new Book(3, "Tre"));
            int bookNum = 1;
            BoundReader = new Reader() { Name = "BoundReader", Book= Books[bookNum], BookId = bookNum };

        }

  
    }
}
