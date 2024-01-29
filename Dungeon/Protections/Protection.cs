
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum ProtectionType
{
    MagicCape,
    MagicPendant,
    Shield
}

public struct Protection {

    public abstract void RestoreProtection(Hero hero);

    public Protection() {

    }


    /// <summary>
    /// @param MonsterInRoom 
    /// @return
    /// </summary>
    public bool CheckEfficiency(Monster MonsterInRoom) {
        // TODO implement here
        return false;
    }

}