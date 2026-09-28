using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

/*************************************************************************
* klasa: Paladin
*
* opis:
* Klasa reprezentująca postać paladyna.
*
* pola / właściwości:
* Name, string, nazwa postaci
* Health, int, punkty życia postaci
* Strength, int, siła postaci
* Intelligence, int, inteligencja postaci
* Agility, int, zręczność postaci
* Defense, int, poziom obrony postaci
* Mana, int, ilość many postaci
*************************************************************************/
public sealed class Paladin : Entity.Character
{
    public Paladin(string name) : base(name, CharacterClass.Paladin)
    {
        Health = 130;
        Strength = 15;
        Intelligence = 10;
        Agility = 6;
        Defense = 18;
        Mana = 40;
    }

    /*************************************************************************
    * funkcja: Attack
    *
    * opis:
    * Oblicza wartość ataku paladyna na podstawie jego głównej statystyki.
    *
    * parametry:
    * brak
    *
    * zwraca:
    * int, wartość ataku paladyna
    *************************************************************************/
    public int Attack()
    {
        return Strength * 3;
    }

    /*************************************************************************
    * funkcja: SpecialAbility
    *
    * opis:
    * Zwraca nazwę specjalnej umiejętności paladyna.
    *
    * parametry:
    * brak
    *
    * zwraca:
    * string, opis specjalnej umiejętności
    *************************************************************************/
    public string SpecialAbility()
    {
        return "Święta Tarcza";
    }
}
