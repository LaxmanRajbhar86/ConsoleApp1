// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter 1:Right Angle Triangle pattern & 2:Half Diamond pattern");
string strtPatternType = Console.ReadLine();
int intPatternType = 0;
int intRowNum = 7;
if (int.TryParse(strtPatternType, out intPatternType))
{
    if (intPatternType == 1)
    {
        for (int x = 0; x < intRowNum; x++)
        {
            for (int y = 0; y <= x; y++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    else if (intPatternType == 2)
    {
        for (int x = 0; x < intRowNum/2; x++)
        {
            for (int y = 0; y <= x; y++)
            {
                Console.Write("*");
            }            
            Console.WriteLine();
        }
        for (int x = (intRowNum/2); x >=0 ; x--)
        {
            for (int y = 0; y <= x; y++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Please select Valid input");
    }    
}
else
{
    Console.WriteLine("Please select Valid input");
}






