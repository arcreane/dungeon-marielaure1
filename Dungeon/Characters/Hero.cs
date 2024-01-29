
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Hero {

    public int Gold { get; set; }
    public List<Item> Inventory { get; set; }
    public Weapon EquippedWeapon { get; set; }
    public Protection Protection { get; set; }

    public Hero(string name, int lifePoints, int gold) : base(name, lifePoints)
    {
        Gold = gold;
        Inventory = new List<Item>();
    }

    public HashSet<Protection> Protections;

    public Arsenal HeroArsenal;
    private int _lifePoints;


    public int LifePoints
    {
        get { return _lifePoints; }
        set
        {
            _lifePoints = value;
            if (_lifePoints < 0)
                IsDead = true;
        }
    }

    public void UseItem(Item item)
    {

    }

    public abstract void ApplyDamagesToEnemy(Character p_CharacterToApplyDamge);
    public abstract int ReceiveDamage(Character p_CharacterApplyingDamage);

    public void SelectProtection() {
        // TODO implement here
    }

    /// <summary>
    /// @param RoomMonster
    /// </summary>
    public void AutoSelectCorrectProtection(Monster RoomMonster) {
        // TODO implement here
    }

    /// <summary>
    /// @param p_Monster 
    /// @return
    /// </summary>
    public void Attack(Monster p_Monster) {
        // TODO implement here
    }

    /// <summary>
    /// @param p_Monster
    /// </summary>
    public void CheckProtectionEfficiency(Monster p_Monster) {
        // TODO implement here
    }

    public void GettingHit() {
        // TODO implement here
    }

    public void OpenChest(Chest p_Chest) {
        // TODO implement here
    }

}