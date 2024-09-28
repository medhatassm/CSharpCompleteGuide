namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Error handling

            string number = "10.34MD";
            int cast;

            //cast = number; // Syntax Error

            try
            {
                cast = Convert.ToInt32(number);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #endregion

            #region Exception Filter

            try
            {
                //block of code
            }
            catch (Exception ex) when (ex.Message.Contains("404"))
            {
                //block of code
            }

            #endregion
        }
    }
}