//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;
using System.Numerics;

class BankAccountData
{
    static void Main()
    {
        String CardHolderName = "Ivan Petkov Draganov";
        Decimal Balance = 1234235423.34m;
        String BankName = "OBB Bank";
        string IBAN = "GR01101250000000012300695";
        BigInteger Card1 = 1234567890123456789;
        BigInteger Card2 = Card1 + 1;
        BigInteger Card3 = Card2 + 3;
        Console.WriteLine("Your banking information: CardHolderName - {0}, Balance - {1}, BankName - {2}, IBAN - {3}, Card1 - {4}, Card2- {5}, Card3- {6}.", CardHolderName, Balance, BankName, IBAN, Card1, Card2, Card3);
        Console.ReadLine();
    }
}

