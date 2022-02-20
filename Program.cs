// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Variables & Type
var newVariable = "4.8";
double newDouble = Convert.ToDouble(newVariable);
float newFloat = (float)newDouble;
int newInteger = Convert.ToInt32(newFloat);
char newChar = Convert.ToChar(newInteger);
Console.Write(newVariable.GetType() + " : " + newVariable);
Console.Write(" Convert To ");
Console.Write(newChar.GetType() + " : " + newChar);
Console.WriteLine();
bool newBoolean = true;

//Input
Console.Write("Enter Your Name : ");
string usrNam = Console.ReadLine();
usrNam = usrNam.Insert(usrNam.Length, "@email.com");
Console.Write("Create new Password : ");
var usrPswd = Console.ReadLine();
if(usrNam.Length > (2+10) && usrPswd.Length > 4) Console.WriteLine("Welcome : " + usrNam.Substring(0, usrNam.IndexOf('@')));
else Console.WriteLine("Something Error");

//Random
var rndm = new Random();
int minRng = 0, maxRng = 100;
int rndmInt = Math.Abs(rndm.Next(minRng, maxRng));//rndm.NextDouble()
int gusInt = 0;
while(gusInt != rndmInt) {
    Console.Write("Guess a Natural Number, from 0 to 100 : ");
    gusInt = Convert.ToInt32(Console.ReadLine()); 
    if(gusInt != rndmInt) {
        if (gusInt.GetType() != typeof(int)) Console.Write("Guess Format is Incorrect");
        else if( gusInt > rndmInt) Console.Write("Guess is much Higher");
        else if( gusInt < rndmInt) Console.Write("Guess is to Lower");
        Console.Write(", Try Again \n");
    }
}
Console.WriteLine("Congrulations" + ", Your Guess is Correct");


Console.ReadKey();
newBoolean = false;
Console.Write("\f\a");
Console.Beep();