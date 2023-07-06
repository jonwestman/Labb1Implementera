using Labb1Implementera;
public class Program
{
    private static readonly CreditCardFactory creditCardFactory = CreditCardFactory.GetInstance();
    private static readonly Dictionary<int, IPaymentStrategy> paymentStrategies = new Dictionary<int, IPaymentStrategy>();

    public static void Main()
    {
        InitializePaymentStrategies();

        bool exit = false;
        while (!exit)
        {
            DisplayMenu();
            int choice = GetUserChoice();

            switch (choice)
            {
                case 1:
                    ProcessPayment();
                    break;
                case 2:
                    ProcessPayment();
                    break;
                    case 3:
                    ProcessPayment();
                    break; 
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Exiting the application.");
    }

    private static void DisplayMenu()
    {
        // Display the menu options
        Console.WriteLine("Payment Options:");
        Console.WriteLine("1. Pay with cash");
        Console.WriteLine("2. Pay with Visa credit card");
        Console.WriteLine("3. Pay with Mastercard credit card");
        Console.WriteLine("4. Exit");
        Console.WriteLine();
    }

    private static int GetUserChoice()
    {
        // Get the user's choice from the menu
        Console.Write("Enter your choice: ");
        string input = Console.ReadLine();
        int choice;

        while (!int.TryParse(input, out choice))
        {
            Console.WriteLine("Invalid choice. Please try again.");
            Console.Write("Enter your choice: ");
            input = Console.ReadLine();
        }

        return choice;
    }

    private static void InitializePaymentStrategies()
    {
        // Initialize the payment strategies
        // Here, we are using the Factory Method pattern to create credit card objects through the CreditCardFactory
        paymentStrategies.Add(1, new CashPaymentStrategy());
        paymentStrategies.Add(2, new CreditCardPaymentStrategy(creditCardFactory.CreateCreditCard("Visa")));
        paymentStrategies.Add(3, new CreditCardPaymentStrategy(creditCardFactory.CreateCreditCard("Mastercard")));
    }

    private static void ProcessPayment()
    {
        // Process the payment based on the selected payment method
        Console.Write("Enter the payment amount: ");
        string input = Console.ReadLine();
        decimal amount;

        while (!decimal.TryParse(input, out amount))
        {
            Console.WriteLine("Invalid amount. Please try again.");
            Console.Write("Enter the payment amount: ");
            input = Console.ReadLine();
        }

        Console.WriteLine("Select a payment method:");
        foreach (var entry in paymentStrategies)
        {
            Console.WriteLine($"{entry.Key}. {entry.Value.GetType().Name}");
        }

        int choice = GetUserChoice();
        if (paymentStrategies.TryGetValue(choice, out IPaymentStrategy paymentStrategy))
        {
            paymentStrategy.ProcessPayment(amount);
        }
        else
        {
            Console.WriteLine("Invalid payment method. Payment canceled.");
        }

        Console.WriteLine();
    }
}
