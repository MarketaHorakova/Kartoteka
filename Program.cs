using KartotekaOsob;

List<Person> persons = new List<Person>();

bool isOver = false;

while (!isOver)
{
    Console.WriteLine("1 - Add person");
    Console.WriteLine("2 - Delete person");
    Console.WriteLine("3 - Show persons");
    Console.WriteLine("0 - Konec");

    int choosenNumber = Convert.ToInt32(Console.ReadLine());

    switch (choosenNumber)
    {
        case 0:
            isOver =true; 
            break;
        case 1:
            Person johnDoe = new Person();
            Console.Write("Input the name: ");
            johnDoe.Name = Console.ReadLine();
            Console.Write("Input the surname: ");
            johnDoe.Surname = Console.ReadLine();
            Console.Write("Input the bitrh date: ");
            johnDoe.BirthDate = Console.ReadLine();
            persons.Add(johnDoe);
            break; 
        case 2:
            Console.WriteLine("Zadej index mazane polozky: ");
            int index = Convert.ToInt32(Console.ReadLine());
            persons.RemoveAt(index);
            break;
        case 3:
            int i = 0;
            foreach (Person onePerson in persons)
            {
                Console.WriteLine($"{i}\t{onePerson.Name}\t\t{onePerson.Surname}\t\t{onePerson.BirthDate}");
                i++;
            }
            break;
    }



}



Console.ReadLine();

