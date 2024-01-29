using System;

public enum WeaponType
{
    Arrows,
    Arsenal,
    Claw,
    Dagger,
    Fire,
    IceArrow,
    Spike,
    Sword,
    Weapon,
    WaterFlask
}

public struct Weapon
{
    public string Name { get; set; }
    public WeaponType Type { get; set; }

    public abstract void ImproveWeaponDamage(Hero hero);

    public Weapon(string name, WeaponType type)
    {
        Name = name;
        Type = type;
    }
}
