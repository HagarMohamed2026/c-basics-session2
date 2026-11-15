
//Q1:
object book = new Book();
Console.WriteLine(book);

//Q2:
object book1 = new Book();
Console.WriteLine(book.ToString());
Console.WriteLine(book1.Equals(book));
Console.WriteLine(book1.GetHashCode());
Console.WriteLine(book1.GetType());

//Q3: compile-time error
 int Pages = 464;


//Q4:
int num1 = 10;
int num2 = 0;
try
{
    Console.WriteLine("num1/num2=" + num1 / num2);
}
catch
{
    Console.WriteLine("cannot divide by zero");
}
finally
{
    Console.WriteLine("Done");
}


//Q5:
int pages = 300;
double doublePages =pages;
Console.WriteLine("doublePages=" + doublePages);


//Q6:
double price = 49.99;
int intPrice = (int)price;
Console.WriteLine("intPrice=" + intPrice);


//Q7:
string pagesText = "464";
int pagesTextInt = Convert.ToInt32(pagesText);
Console.WriteLine("pagesTextInt=" + pagesTextInt);

//Q8:
string yearText = "2023";
int yearTextInt = int.Parse(yearText);
Console.WriteLine("YearTextInt=" + yearTextInt);

string badText = "abc";
int badTextInt;

bool isSuccess = int.TryParse(badText, out badTextInt);
Console.WriteLine("Invalid number");

//Q9:
int pages2 = 464;
string pagesString = pages2.ToString();
Console.WriteLine(pagesString.GetType());

//Q10:
int copies = 100;
object obj1 = copies;
Console.WriteLine(obj1);
int copies2 = (int)obj1;
Console.WriteLine(copies2);



class Book
{
    string Title;
    int Pages;
}


    

