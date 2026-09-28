using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Tests.Domain.Enum;

[TestClass]
public class CharacterClassTest
{
    [TestMethod]
    public void TestWarriorValue()
    {
        Assert.AreEqual(1, (int)CharacterClass.Warrior);
    }

    [TestMethod]
    public void TestMageValue()
    {
        Assert.AreEqual(2, (int)CharacterClass.Mage);
    }

    [TestMethod]
    public void TestRogueValue()
    {
        Assert.AreEqual(3, (int)CharacterClass.Rogue);
    }

    [TestMethod]
    public void TestNewCharacterClassValues()
    {
        Assert.AreEqual(4, (int)CharacterClass.Archer);
        Assert.AreEqual(5, (int)CharacterClass.Paladin);
        Assert.AreEqual(6, (int)CharacterClass.Necromancer);
    }
}
