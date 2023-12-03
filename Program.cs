// See https://aka.ms/new-console-template for more information

List<string> pets = new List<string>();

Accept("Kangaroo");
Accept("Bunny");
Console.WriteLine(HealingPets() + " Healed");
Console.WriteLine(HealingPets() + " Healed");

string HealingPets() {
    string healedPets = pets[0];    
    pets.RemoveAt(0);
    return healedPets;
}

void Accept(string petsName) { 
    pets.Add(petsName);
    Console.WriteLine(petsName + " Added");
}
