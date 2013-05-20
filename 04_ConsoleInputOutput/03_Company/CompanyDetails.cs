using System;

class CompanyDetails
{
	static void Main()
	{
		Console.WriteLine("Enter a company name: ");
		string companyName = Console.ReadLine();

		Console.WriteLine("Enter a company address: ");
		string companyAddress = Console.ReadLine();

		Console.WriteLine("Enter a company phone number: ");
		string companyPhone = Console.ReadLine();

		Console.WriteLine("Enter a company fax number: ");
		string companyFax = Console.ReadLine();

		Console.WriteLine("Enter a company web site: ");
		string companyWebSite = Console.ReadLine();

		Console.WriteLine("Enter company's manager first name: ");
		string companyManagerFirstName = Console.ReadLine();

		Console.WriteLine("Enter company's manager last name: ");
		string companyManagerLastName = Console.ReadLine();

		Console.WriteLine("Enter company's manager age: ");
		int companyManagerAge = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter company's manager phone number: ");
		string companyManagerPhone = Console.ReadLine();

		Console.Write("The company {0} has an address: {1}, phone number: {2}, " + 
						  "fax number: {3} and website: {4}.{5}"
						  , companyName, companyAddress, companyPhone, 
						  companyFax, companyWebSite, Environment.NewLine);

		Console.WriteLine("The company's manager name is {0} {1}. His/her age is {2} " +
						  "and his/her phone number is {3}."
						  , companyManagerFirstName, companyManagerLastName
						  , companyManagerAge, companyManagerPhone);
	}
}