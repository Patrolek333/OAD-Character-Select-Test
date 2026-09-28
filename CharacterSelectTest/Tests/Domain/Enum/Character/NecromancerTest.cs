using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Tests.Character;

[TestClass]
public class NecromancerTest
{
    [TestMethod]
    public void TestNecromancerCreation()
    {
        Necromancer necromancer = new Necromancer("Mordek");

        Assert.IsNotNull(necromancer);
        Assert.AreEqual("Mordek", necromancer.Name);
        Assert.AreEqual(CharacterClass.Necromancer, necromancer.Class);
    }

    [TestMethod]
    public void TestNecromancerStatistics()
    {
        Necromancer necromancer = new Necromancer("Mordek");

        Assert.AreEqual(75, necromancer.Health);
        Assert.AreEqual(5, necromancer.Strength);
        Assert.AreEqual(19, necromancer.Intelligence);
        Assert.AreEqual(9, necromancer.Agility);
        Assert.AreEqual(5, necromancer.Defense);
        Assert.AreEqual(100, necromancer.Mana);
    }

    [TestMethod]
    public void TestNecromancerAttack()
    {
        Necromancer necromancer = new Necromancer("Mordek");

        int attack = necromancer.Attack();

        Assert.AreEqual(57, attack);
    }

    [TestMethod]
    public void TestNecromancerSpecialAbility()
    {
        Necromancer necromancer = new Necromancer("Mordek");

        string ability = necromancer.SpecialAbility();

        Assert.AreEqual("Przywołanie Umarłych", ability);
    }
}
