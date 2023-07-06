using Labb1Implementera.Factory;

string theEnd = "";
string cardtype = "";

do
{
    Console.Write("Type in which Creditcard you wish to see details for Basic/Silver/Guld: ");
    cardtype = Console.ReadLine();

    ICreditCard cardDetails = CreditCardFactory.GetCreditCard(cardtype);

    Console.Clear();

    if (cardDetails != null)
    {
        Console.WriteLine($"CardType : {cardDetails.GetCardType()}");
        Console.WriteLine($"CreditLimit : {cardDetails.GetCreditLimit()}");
        Console.WriteLine($"AnnualCharge : {cardDetails.GetAnnualCharge()}");
    }
    else
    {
        Console.WriteLine("Invalid Card Type");
    }

    Console.WriteLine("Press 'q' if you wish to quit, Enter to continue: ");
    theEnd = Console.ReadLine();

    Console.Clear();

} while (theEnd.ToLower() != "q");