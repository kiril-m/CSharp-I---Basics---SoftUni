//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.


using System;
using System.Numerics;

class EmployeeData
{
    static void Main()
    {
        String FirstName = "Kiril";
        String LastName = "M";
        short Age = 29;
        Char Gender = 'm';
        long PersonalIDnumber = 8306112507;
        BigInteger EmployeeNumber = 27569999;
        Console.WriteLine("{0} {1}, {2}, {3}, Personal ID Number:{4}, Employee Number: {5}", FirstName, LastName, Age, Gender, PersonalIDnumber, EmployeeNumber);
        Console.ReadLine();
    }
}

