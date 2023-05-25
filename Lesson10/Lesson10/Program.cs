// See https://aka.ms/new-console-template for more information
using Lesson10;

Console.WriteLine("Hello, World!");

var person = new Person("Artem", "Sokolov", "Odesa", 27, "+380953953853");
var anoterPerson = new Person("Jon", "Doe", "Chicago", 42, "+380953953705");
var copyPerson = new Person(anoterPerson);



var phoneBook = new PhoneBooks();

phoneBook.AddNewRecord(person);
phoneBook.AddNewRecord(anoterPerson);
phoneBook.AddNewRecord(copyPerson);

phoneBook.ShowAll();



/*
var copyPerson = new Person(anoterPerson);

anoterPerson.Age = 43;
Console.WriteLine(copyPerson.Age);
anoterPerson.FullName();

var info = anoterPerson.GetInfo();
Console.WriteLine(info);
*/
Console.ReadLine();
