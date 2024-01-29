
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum MonsterType
{
    Magician,
    Thief,
    Barbarian,
    Dragon
}

public class Monster : Character, ICharacter
{

    public Monster() {
    }

    public int m_iLifePoints;

    public Weapon m_Weapon;

    public Weapon m_EfficientWeapon;

    public MonsterType Type { get; set; }
    public int MinAttackDamage { get; set; }
    public int MaxAttackDamage { get; set; }


    public Monster(string name, int lifePoints, MonsterType type) : base(name, lifePoints)
    {
        Type = type;
    }


    protected void FinishSetup(int minAttack, int maxAttack, int minLifePoints, int maxLifePoints)
    {

    }



    /// <summary>
    /// @param p_Hero 
    /// @return
    /// </summary>
    public void Attack(Hero p_Hero) {
        // TODO implement here
    }

}