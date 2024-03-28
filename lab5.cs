using System;

class Program
{
    static void Main(string[] args)
    {
        // Call each method individually
        DivisionNoHandling();
        DivisionWithExceptionHandling();
        DivisionWithExceptionHandlingMoreInfo();
        try
        {
            DivisionWithExceptionHandlingThrow();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception message: " + ex.Message);
        }
        GeneratingException(); // This will crash the application
        HandlingRandomException();
    }

    static int Division(int top, int bottom) => top / bottom;

    static void DivisionNoHandling()
    {
        try
        {
            // Call the Division method with arguments 1 and 0
            // This will terminate your application
            Division(1, 0);
        }
        catch
        {
            // Intentionally left blank as per specifications
        }
    }

    static void DivisionWithExceptionHandling()
    {
        try
        {
            // Call the Division method with arguments 1 and 0
            // Catch the exception and do nothing
            Division(1, 0);
        }
        catch
        {
            // Intentionally left blank as per specifications
        }
    }

    static void DivisionWithExceptionHandlingMoreInfo()
    {
        try
        {
            // Call the Division method with arguments 1 and 0
            // Catch the exception and print the associated message
            Division(1, 0);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception message: " + ex.Message);
        }
    }

    static void DivisionWithExceptionHandlingThrow()
    {
        try
        {
            // Call the Division method with arguments 1 and 0
            // Catch the exception and print the associated message
            Division(1, 0);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception message: " + ex.Message);
            throw new Exception("New Exception thrown in DivisionWithExceptionHandlingThrow", ex);
        }
    }

    static void GeneratingException()
    {
        // Create and throw a new exception
        throw new Exception("Exception generated intentionally");
    }

    static void HandlingRandomException()
    {
        try
        {
            // Call the GeneratingRandomException method
            // Catch all possible exceptions individually and display a sensible output
            GeneratingRandomException();
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index Out of Range Exception occurred.");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Null Reference Exception occurred.");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Invalid Operation Exception occurred.");
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Arithmetic Exception occurred.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Format Exception occurred.");
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Invalid Cast Exception occurred.");
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("Out of Memory Exception occurred.");
        }
    }

    static void GeneratingRandomException()
    {
        int exceptionType = new Random().Next() % 7;
        switch (exceptionType)
        {
            case 0:
                throw new IndexOutOfRangeException();
            case 1:
                throw new NullReferenceException();
            case 2:
                throw new InvalidOperationException();
            case 3:
                throw new ArithmeticException();
            case 4:
                throw new FormatException();
            case 5:
                throw new InvalidCastException();
            case 6:
                throw new OutOfMemoryException();
        }
    }
}
