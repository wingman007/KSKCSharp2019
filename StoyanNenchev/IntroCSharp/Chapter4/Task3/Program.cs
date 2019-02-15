namespace Task3
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Дадена фирма има име, адрес, телефонен номер, факс номер, уеб сайт и мениджър. Мениджърът има име, фамилия и телефонен номер. 
            //Напишете програма, която чете информацията за фирмата и нейния мениджър и я отпечатва след това на конзолата.

            Console.Write("Write the Name of the company:");
            string companyname = Console.ReadLine();
            Console.Write("Write the Address of the company:");
            string companyaddress = Console.ReadLine();
            Console.Write("Write the Phone number of the company:");
            string companypn = Console.ReadLine();
            Console.Write("Write the Fax number of the company:");
            string companyfn = Console.ReadLine();
            Console.Write("Write the Website of the company:");
            string companysite = Console.ReadLine();

            Console.Write("Write the first name of the company's manager:");
            string managerfirst = Console.ReadLine();
            Console.Write("Write the family name of the company's manager:");
            string managersecond = Console.ReadLine();
            Console.Write("Write the phone number of the company's manager:");
            string managerphone = Console.ReadLine();
            string managername = managerfirst + managersecond;

            Console.WriteLine($"Your company name is {companyname} with a address {companyaddress}.The company's Phone number is {companypn} and their fax number is {companyfn}.The company's" +
                $" website is {companysite}");
            Console.WriteLine($"The manager's name is {managername}.His phone number is {managerphone}.");


        }
    }
}
