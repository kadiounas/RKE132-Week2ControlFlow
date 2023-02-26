// See https://aka.ms/new-console-template for more information
//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem, kui 13, siis konsoolis kuvatakse: 
//"You are too young to use Instagram"
//muul juhul 
//konsoolis kuvatakse "Welcome to instagram"

Console.WriteLine("Enter your age:");
String userAge = Console.ReadLine();
int userAgeNum = 0;
//boolean - true/false
bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);


if(isAgeNumber == true)
{
    if(userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
   else
    {
        Console.WriteLine("You are too young to use Instagram!");
    }
}

else
{
    Console.WriteLine("Could not read your age!"); 
}

