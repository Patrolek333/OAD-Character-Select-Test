using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Tests.Character;

[TestClass]
public class PaladinTest
{
    [TestMethod]
    public void TestPaladinCreation()
    {
        Paladin paladin = new Paladin("Arthur");

        Assert.IsNotNull(paladin);
        Assert.AreEqual("Arthur", paladin.Name);
        Assert.AreEqual(CharacterClass.Paladin, paladin.Class);
    }

    [TestMethod]
    public void TestPaladinStatistics()
    {
        Paladin paladin = new Paladin("Arthur");

        Assert.AreEqual(130, paladin.Health);
        Assert.AreEqual(15, paladin.Strength);
        Assert.AreEqual(10, paladin.Intelligence);
        Assert.AreEqual(6, paladin.Agility);
        Assert.AreEqual(18, paladin.Defense);
        Assert.AreEqual(40, paladin.Mana);
    }

    [TestMethod]
    public void TestPaladinAttack()
    {
        Paladin paladin = new Paladin("Arthur");

        int attack = paladin.Attack();

        Assert.AreEqual(45, attack);
    }

    [TestMethod]
    public void TestPaladinSpecialAbility()
    {
        Paladin paladin = new Paladin("Arthur");

        string ability = paladin.SpecialAbility();

        Assert.AreEqual("Święta Tarcza", ability);
    }
}
