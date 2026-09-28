using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

/*************************************************************************
* klasa: Archer
*
* opis:
* Klasa reprezentująca postać łucznika.
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
public sealed class Archer : Entity.Character
{
    public Archer(string name) : base(name, CharacterClass.Archer)
    {
        Health = 90;
        Strength = 10;
        Intelligence = 7;
        Agility = 18;
        Defense = 6;
        Mana = 20;
    }

    /*************************************************************************
    * funkcja: Attack
    *
    * opis:
    * Oblicza wartość ataku łucznika na podstawie jego głównej statystyki.
    *
    * parametry:
    * brak
    *
    * zwraca:
    * int, wartość ataku łucznika
    *************************************************************************/
    public int Attack()
    {
        return Agility * 3;
    }

    /*************************************************************************
    * funkcja: SpecialAbility
    *
    * opis:
    * Zwraca nazwę specjalnej umiejętności łucznika.
    *
    * parametry:
    * brak
    *
    * zwraca:
    * string, opis specjalnej umiejętności
    *************************************************************************/
    public string SpecialAbility()
    {
        return "Deszcz Strzał";
    }
}
