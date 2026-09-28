using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Tests.Character;

[TestClass]
public class ArcherTest
{
    [TestMethod]
    public void TestArcherCreation()
    {
        Archer archer = new Archer("Robin");

        Assert.IsNotNull(archer);
        Assert.AreEqual("Robin", archer.Name);
        Assert.AreEqual(CharacterClass.Archer, archer.Class);
    }

    [TestMethod]
    public void TestArcherStatistics()
    {
        Archer archer = new Archer("Robin");

        Assert.AreEqual(90, archer.Health);
        Assert.AreEqual(10, archer.Strength);
        Assert.AreEqual(7, archer.Intelligence);
        Assert.AreEqual(18, archer.Agility);
        Assert.AreEqual(6, archer.Defense);
        Assert.AreEqual(20, archer.Mana);
    }

    [TestMethod]
    public void TestArcherAttack()
    {
        Archer archer = new Archer("Robin");

        int attack = archer.Attack();

        Assert.AreEqual(54, attack);
    }

    [TestMethod]
    public void TestArcherSpecialAbility()
    {
        Archer archer = new Archer("Robin");

        string ability = archer.SpecialAbility();

        Assert.AreEqual("Deszcz Strzał", ability);
    }
}
