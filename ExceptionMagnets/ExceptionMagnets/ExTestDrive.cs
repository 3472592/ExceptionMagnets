using System;

namespace ExceptionMagnets
{
    class ExTestDrive
    {
        /* The Zero() method either
        prints “thaws” or “throws”,
        depending on whether it was
        passed “yes” or something else
        as its test parameter. */
        public static void Zero(string test)
        {
            try
            {
                Console.Write("t");
                DoRisky(test);
                Console.Write("o");
            }
            catch (MyException)
            {
                Console.Write("a");
            }
            /* The finally block makes sure that
            the method always prints “w”.
            And the “s” is printed outside the
            exception handler, so it always
            prints, too. */
            finally
            {
                Console.Write("w");
            }
            Console.Write("s");
        }
        /* The DoRisky() method only
        throws an exception if it’s
        passed the string “yes”. */
        static void DoRisky(String t)
        {
            Console.Write("h");
            if (t == "yes")
            {
                throw new MyException();
            }
            // gets executed if DoRisky() does not throw an exception.
            Console.Write("r");
        }
    }
}
