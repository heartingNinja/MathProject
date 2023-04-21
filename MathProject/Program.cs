using MathProject;

Menu menu = new Menu();
string date = DateTime.Now.ToString();

List<string> games = new();

string name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Type Name");
    string name = Console.ReadLine();
    return name;
}
