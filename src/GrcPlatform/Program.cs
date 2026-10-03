// Program.cs - uygulamanin giris noktasi (entry point).
// Top-level statements kullanilir: class Program ve static void Main yazilmaz,
// derleyici bu satirlari otomatik olarak Main metodunun icine sarar.

// WriteLine: metni yazar ve sonuna satir sonu (newline) ekler.
//Console.WriteLine("Hello, World!");

// Write: satir sonu eklemez, imlec ayni satirda kalir.
// Asagidaki uc cagri tek satirda "Hello world!" uretir.
//Console.Write("Hello");
//Console.Write(" ");
//Console.Write("world!");

// ReadLine: kullanicidan satir sonuna kadar veri okur.
/*string favoriteColor = Console.ReadLine();
Console.WriteLine("Oh, I love " + favoriteColor + " too!");*/

/*string first = "Hello";
string last = "world";
string message = first + ", " + last + "!";
Console.WriteLine(message);

string name = "Alex";
Console.WriteLine($"Hello, {name}!");

Console.WriteLine("What is your name Bro?");
String name2 = Console.ReadLine().ToUpper();
Console.WriteLine($"Nice too meet your {name2} bro!");

// Ask for the user's name
Console.WriteLine("What is your name?");
string userName = Console.ReadLine();
 // Ask for the user's age
Console.WriteLine("How old are you?");
int age = int.Parse(Console.ReadLine());
 // Display a personalized message that includes both pieces of information
 Console.WriteLine($"Hello, {userName} You are {age} years old.");*/

  // Declare variables using an explicit type
//var name = "David Beckham";
 // Declare a variable using var

 // Display the values of your variables

 // Reassign a variable to a new value



 // Collect the bill amount and tip percentage
/*Console.WriteLine("Enter the bill amount: ");
double billAmount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the tip percentage: ");
double tipPercentage = Convert.ToDouble(Console.ReadLine());
 // Display the entered values
Console.WriteLine($"Bill Amount: {billAmount}");
Console.WriteLine($"Tip Percentage: {tipPercentage}");
 // Calculate the tip and total
var tip = billAmount * tipPercentage / 100;
var total = billAmount + tip;
 // Display the results
 Console.WriteLine($"Tip Amount: {total}");*/




 //Convert Fahreineht to Celsius

 Console.WriteLine("Enter temperature in Fahrenheit: ");
 double fahrenheight = Convert.ToDouble(Console.ReadLine());
 decimal celcius = Math.Round(Convert.ToDecimal((fahrenheight - 32) * 5 / 9), 2);

 Console.WriteLine($"Temperature in Celsius: {celcius:2} °C");