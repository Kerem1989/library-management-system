namespace Library.Management.System ;

    public class Book
    {
        private int _id;
        private string _title;
        public bool _isBorrowed;
        
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public bool IsBorrowed
        {
            get { return _isBorrowed; }
            set { _isBorrowed = value; }
        }
        
        public Book(int id, string title, bool isBorrowed = false)
        {
            _id = id;
            _title = title;
            _isBorrowed = isBorrowed;
        }
        

    }