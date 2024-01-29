
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Character, ICharacter
{
	public abstract void ApplyDamagesToEnemy(Character p_CharacterToApplyDamge);
	public abstract int ReceiveDamage(Character p_CharacterApplyingDamage);

	public Character()
	{
	}

	public void Attack(Character enemy)
	{
		
	}

}