
using SolucionEjercicio;

Console.WriteLine("Type your name");

string name = Console.ReadLine();

Console.WriteLine("Type your birthday (YYYY-MM-DD)");

string birthday = Console.ReadLine();

DateTime birthdayDate = DateTime.Parse(birthday);

Person newPerson = new Person();

newPerson.Name = name;

newPerson.Birthday = birthdayDate;

int calculatedAge = newPerson.CalculateAge();

Console.WriteLine("Your age is: " + calculatedAge);

DayOfWeek dayOfWeek = newPerson.GetDayOfWeek();

Console.WriteLine("You born on: " + dayOfWeek);