namespace Task3;

 class Book:AbstractBook, IReadable,IBorrowable
{


   

    public Book(string title, string author) : base(title, author)
    {
    }

      public void Read(int day)
      {
            if(day>=1)
            System.Console.WriteLine($"Kiniga chetaetsya");
      }
      public void Borrow(int book)
      {
       if(book==0)
       {
        System.Console.WriteLine($"Knigu vzyali");
       }
       else{
        System.Console.WriteLine($"Poka eshyo ne vzyali" );
       }
      }


       public void ReturnBook(int book)
      {
       if(book>=1)
       {
        System.Console.WriteLine($"Kniga bila vozvrashena");
       }
       else{
        System.Console.WriteLine($"Poka esho nevozvrashali knigu" );
       }
      }


}
