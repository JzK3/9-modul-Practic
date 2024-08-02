namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new AgeException("Azaz");

            }
            catch (AgeException ex) { Console.WriteLine(ex.GetType()); }
            try
            {
                throw new FieldAccessException();
            }
            catch (FieldAccessException ex) { Console.WriteLine(ex.GetType()); }
            try
            {
                throw new FileNotFoundException();
            }
            catch (FileNotFoundException ex) { Console.WriteLine(ex.GetType()); }
            try
            {
                throw new ArgumentOutOfRangeException();
            }
            catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.GetType()); }
            try
            {
                throw new Exception();
            }
            catch (Exception ex) { Console.WriteLine(ex.GetType()); }
        }
    class AgeException : Exception
        {
            public AgeException(string message) : base(message) { }
        }
    }
}





            
      

