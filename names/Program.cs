﻿//Ви отримали рядок, який містить ім’я та прізвище користувача. Ваша мета - перевірити, чи починається прізвище на ту ж літеру, що й ім’я. Якщо так, вивести повідомлення “Прізвище починається на ту ж літеру, що і ім’я”, інакше - “Прізвище не починається на ту ж літеру, що і ім’я”.

string firstName = "Василь";
string lastName = "Втепаненко";

if (firstName[0] == lastName[0])
{
  Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
}
else
{
  Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
}