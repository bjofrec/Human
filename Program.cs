// See https://aka.ms/new-console-template for more information

class Human
{
    public string Nombre { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    public int Health { get; set; }

    public Human(string nombre)
    {
        Nombre = nombre;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }

    public Human(string nombre, int fuerza, int inteligencia, int destreza, int salud)
    {
        Nombre = nombre;
        Strength = fuerza;
        Intelligence = inteligencia;
        Dexterity = destreza;
        Health = salud;
    }

    public int Atacar(Human objetivo)
    {
        int daño = Strength * 3;
        objetivo.Health -= daño;
        return objetivo.Health;
    }
}


