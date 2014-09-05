//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.
//program	user
//Company name:	Software University
//Company address:	26 V. Kanchev, Sofia
//Phone number:	+359 899 55 55 92
//Fax number:	
//Web site:	http://softuni.bg
//Manager first name:	Svetlin
//Manager last name:	Nakov
//Manager age:	25
//Manager phone:	+359 2 981 981
//Software University
//Address: 26 V. Kanchev, Sofia
//Tel. +359 899 55 55 92
//Fax: (no fax)
//Web site: http://softuni.bg
//Manager: Svetlin Nakov (age: 25, tel. +359 2 981 981)	


using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Please, enter the name of the company: ");
        string companyname = Console.ReadLine();
        Console.Write("Please, enter the address of the company: ");
        string companyaddress = Console.ReadLine();
        Console.Write("Please, enter the phone number of the company: ");
        string companyphonenumber = Console.ReadLine();
        Console.Write("Please, enter the fax number of the company: ");
        string companyfaxnumber = Console.ReadLine();
        Console.Write("Please, enter the website of the company: ");
        string companywebsite = Console.ReadLine();
        Console.Write("Please, enter the first name of the manager of the company: ");
        string Managersfirstname = Console.ReadLine();
        Console.Write("Please, enter the last name of the manager of the company: ");
        string Managerslastname = Console.ReadLine();
        Console.Write("Please, enter the age of the manager of the company: ");
        string Managersage = Console.ReadLine();
        Console.Write("Please, enter the phone number of the manager of the company: ");
        string Managersphone = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Here is the company information all in one: ");
        Console.WriteLine(companyname);
        Console.WriteLine("Address: {0}", companyaddress);
        Console.WriteLine("Tel. {0}", companyphonenumber);
        Console.WriteLine("Fax: {0}", companyfaxnumber);
        Console.WriteLine("Web site: {0}", companywebsite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", Managersfirstname, Managerslastname, Managersage, Managersphone);
        Console.ReadLine();
    }
}

