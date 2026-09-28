using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Entity;

/*************************************************************************
* klasa: Character
*
* opis:
* Bazowa abstrakcyjna klasa reprezentująca postać w systemie.
*
* pola / właściwości:
* Name, string, nazwa postaci
* Class, CharacterClass, klasa postaci
* Health, int, punkty życia postaci
* Strength, int, siła postaci
* Intelligence, int, inteligencja postaci
* Agility, int, zręczność postaci
* Defense, int, poziom obrony postaci
* Mana, int, ilość many postaci
*************************************************************************/
public abstract class Character
{
    public string Name { get; set; }
    public CharacterClass Class { get; }

    public int Health { get; protected set; }
    public int Strength { get; protected set; }
    public int Intelligence { get; protected set; }
    public int Agility { get; protected set; }

    public int Defense { get; protected set; }
    public int Mana { get; protected set; }

    protected Character(string name, CharacterClass @class)
    {
        Name = string.IsNullOrWhiteSpace(name) ? @class.ToString() : name.Trim();
        Class = @class;
    }

    /*************************************************************************
    * funkcja: Describe
    *
    * opis:
    * Wyświetla podstawowe informacje o postaci.
    *
    * parametry:
    * brak
    *
    * zwraca:
    * brak
    *************************************************************************/
    public virtual void Describe()
    {
        Console.WriteLine($"[{Class}] {Name}");
        Console.WriteLine($"  HP: {Health}");
        Console.WriteLine($"  STR: {Strength}  INT: {Intelligence}  AGI: {Agility}");
        Console.WriteLine($"  DEF: {Defense}  MANA: {Mana}");
    }
}
