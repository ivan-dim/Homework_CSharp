using HomeworkClass06;

Customer[] customers = new Customer[123];
int customerNum = 1;
customers[0] = new Customer("Bob Bobsky", "1234-5678-1234-3493", "3423", 342);

void RunATM()
{
    while (true)
    {
        Console.WriteLine("Welcome to ATM");
        Console.WriteLine("Enter your card number");
        string cardNumber = Console.ReadLine();


        string addedCard = cardNumber.Replace("-", "");
        if (!long.TryParse(addedCard, out long numberedCard))
        {
            Console.WriteLine("Invalid");
            continue;
        }

        Customer currentCustomer = FindCustomer(cardNumber);
        if (currentCustomer == null)
        {
            Console.WriteLine("Not found, would you like to register new card? (Y/N)");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                RegisterNewCard();
            }
            continue;
        }
        Console.WriteLine("Enter Pin");
        if (!currentCustomer.Validation(Console.ReadLine()))
        {
            Console.WriteLine("Invalid PIN");
            continue;
        }
        Console.WriteLine($"Welcome {currentCustomer.FullName}");
        TransactionMenu(currentCustomer);
        Console.WriteLine("Thankx");
    }
}


Customer FindCustomer(string cardNumber)
{
    for (int i = 0; i < customerNum; i++)
    {
        if (customers[i].CardNum == cardNumber.Replace("-", ""))
        {
            return customers[i];
        }
    }
    return null;
}

void RegisterNewCard()
{
    Console.WriteLine("Enter your full name");
    string fullName = Console.ReadLine();
    Console.WriteLine("Enter your card number(1111-2222-3333-4444)");
    string cardNumber = Console.ReadLine();
    string normalizedCard = cardNumber.Replace("-", "");
    if (!long.TryParse(normalizedCard, out _))
    {
        Console.WriteLine("Invalid card number format");
        return;
    }

    Console.WriteLine("Enter your PIN");
    string pin = Console.ReadLine();
    Console.WriteLine("Enter initial deposit amount");
    int initialBalance = int.TryParse(Console.ReadLine(), out int balance) ? balance : 0;
    customers[customerNum++] = new Customer(fullName, cardNumber, pin, initialBalance);
    Console.WriteLine($"Registered successfully, {fullName}");
}

void TransactionMenu(Customer customer)
{
    bool continueTransactions = true;
    while (continueTransactions)
    {
        Console.WriteLine("What do you need?");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Cash Withdrawal");
        Console.WriteLine("3. Cash Deposit");
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine($"Your current balance is: ${customer.GetBal()}");
                break;
            case "2":
                Console.WriteLine("Enter amount to withdraw");
                if (int.TryParse(Console.ReadLine(), out int withdrawAmount) && customer.Withdraw(withdrawAmount))
                {
                    Console.WriteLine($"You withdrew ${withdrawAmount}. Your balance is now ${customer.GetBal()}");
                }
                else
                {
                    Console.WriteLine("Not enough funds or invalid input");
                }
                break;
            case "3":
                Console.WriteLine("Enter amount to deposit");
                if (int.TryParse(Console.ReadLine(), out int depositAmount))
                {
                    customer.Depo(depositAmount);
                    Console.WriteLine($"You deposited ${depositAmount}. Your new balance is ${customer.GetBal()}");
                }
                break;
        }
        Console.WriteLine("Go again? (Y/N)");
        continueTransactions = Console.ReadLine().ToUpper() == "Y";
    }
}
RunATM();