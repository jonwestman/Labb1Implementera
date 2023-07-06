string theEnd = "";


do
{




    Console.WriteLine("Hit Enter if you wish to continue or 'q' if you wish to quit");
    theEnd = Console.ReadLine();

    Console.Clear();

} while (theEnd.ToLower() != "q");