using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Application.Factory;

public static class CharacterFactory
{
    /*************************************************************************
    * funkcja: Create
    *
    * opis:
    * Tworzy postać na podstawie wybranej klasy postaci.
    *
    * parametry:
    * cls, CharacterClass, klasa tworzonej postaci
    * name, string?, nazwa tworzonej postaci
    *
    * zwraca:
    * Domain.Entity.Character, utworzona postać
    *************************************************************************/
    public static Domain.Entity.Character Create(CharacterClass cls, string? name)
    {
        return cls switch
        {
            CharacterClass.Warrior => new Warrior(name ?? "Warrior"),
            CharacterClass.Mage => new Mage(name ?? "Mage"),
            CharacterClass.Rogue => new Rogue(name ?? "Rogue"),
            CharacterClass.Archer => new Archer(name ?? "Archer"),
            CharacterClass.Paladin => new Paladin(name ?? "Paladin"),
            CharacterClass.Necromancer => new Necromancer(name ?? "Necromancer"),
            _ => throw new ArgumentOutOfRangeException(
                nameof(cls),
                "Nieznana klasa postaci.")
        };
    }
}
