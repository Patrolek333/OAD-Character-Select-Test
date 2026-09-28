using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

/*************************************************************************
* klasa: Necromancer
*
* opis:
* Klasa reprezentująca postać nekromanty.
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
public sealed class Necromancer : Entity.Character
{
    public Necromancer(string name) : base(name, CharacterClass.Necromancer)
    {
        Health = 75;
        Strength = 5;
        Intelligence = 19;
        Agility = 9;
        Defense = 5;
        Mana = 100;
    }

    /*************************************************************************
    * funkcja: Attack
    *
    * opis:
    * Oblicza wartość ataku nekromanty na podstawie jego głównej statystyki.
    *
    * parametry:
    * brak
    *
    * zwraca:
    * int, wartość ataku nekromanty
    *************************************************************************/
    public int Attack()
    {
        return Intelligence * 3;
    }

    /*************************************************************************
    * funkcja: SpecialAbility
    *
    * opis:
    * Zwraca nazwę specjalnej umiejętności nekromanty.
    *
    * parametry:
    * brak
    *
    * zwraca:
    * string, opis specjalnej umiejętności
    *************************************************************************/
    public string SpecialAbility()
    {
        return "Przywołanie Umarłych";
    }
}
