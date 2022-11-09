namespace HomeWork_11
{
    class Program
    {
        static void Main(string[] args)
        {
            bookLibrary Zahar = new bookLibrary();
            
            Zahar.writer = Writers.Франко;
            Zahar.name = "Захар Беркут";
            Zahar.pagesNumber = 260;

            bookLibrary Eneida = new bookLibrary();
            Eneida.writer = Writers.Котляревський;
            Eneida.name = "Енеїда";
            Eneida.pagesNumber = 391;

            Zahar.DescriptionBook();

            Eneida.DescriptionBook();

        }
    }

    
    public class bookLibrary
    {
        public string name;
        public int pagesNumber = 0;
        public Writers writer;
  
        public int getBookPages()
        {
            return pagesNumber;
        }

        public string getBookName()
        {
            return name;
        }

         public Writers getWriter()
        {
            return writer;
        }
        
        public void setStatus(Writers newWriter)
        {
            writer = newWriter;
        }

        public void DescriptionBook()
        {
            string pagesString = getBookPages().ToString();
            string suffix = "сторiнок";
            if (pagesString.EndsWith("1"))
            {
                suffix = "сторiнку";
            }
            else if (pagesString.EndsWith("3") || pagesString.EndsWith("2") || pagesString.EndsWith("4"))
            {
                suffix = "сторiнки";
            }

            Console.WriteLine("Книжку '"+ getBookName()+"' напысав "+getWriter()+" на "+ pagesString + suffix);
        }

    }
    public enum Writers
    {
        Франко,
        Шевченко,
        Котляревський
    }

}