

//Array of 3 names?
//Ask user what number?
//return name at that number?
//check for invalid numbers?


string[] firstNames = new string[] { "Justin", "Amanda", "Sebastian" };
bool validNumber = false;
string? numberText = null;


do
{
    Console.Write("Please enter number 0, 1, or 2. ");
    numberText = Console.ReadLine();
    validNumber = int.TryParse(numberText, out int number);

    if (number == 0)
    {
        Console.WriteLine(firstNames[0]);
    }
    else if (number == 1)
    {
        Console.WriteLine(firstNames[1]);
    }
    else if (number == 2)
    {
        Console.WriteLine(firstNames[2]);
    }
    else if (validNumber == true)
    {
        Console.WriteLine("You did not enter a valid number.");
    }

} while (validNumber == true);
