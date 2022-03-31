/**       
 *--------------------------------------------------------------------
 * 	   File name: {Enter your file name here}
 * 	Project name: {Enter you project name here}
 *--------------------------------------------------------------------
 * Author’s name and email:	 {Enter your name here}				
 *          Course-Section: {Enter your course section here}
 *           Creation Date:	 {Enter the Date here}		
 * -------------------------------------------------------------------
 */

System.Console.WriteLine ("enter a statement");

String statement = System.Console.ReadLine();

System.Console.WriteLine (" enter a number ");

var number = Convert.ToInt32(System.Console.ReadLine());


ShowCharacter(statement,number);




// METHOD DECLARATIONS
static void ShowCharacter(String str, int num)
{
    System.Console.WriteLine($"the leter at {num} is {str[num-1]}");
}

static double CalculateRetail(double wholesaleCost, double markupPercentage)
{
    return 0;
}
// method 2   

System.Console.WriteLine("enter wholesale price");

var price = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("enter mark up percent");

var precent = Convert.ToDouble(System.Console.ReadLine());

CalculateRetail(price,precent);


//method 3 

for(int i = 80; i <=100; i++)
{
    Console.WriteLine(Celsius(i));
}



static double Celsius(double fTemp)
{
    return (5.0/9.0) * (fTemp - 32);
}






