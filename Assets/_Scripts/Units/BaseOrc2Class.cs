using UnityEngine;
using System.Collections;

public class BaseOrc2Class : BaseUnitClass
{
	public BaseOrc2Class()
	{
		UnitID = "O2";
		BaseUnitName = "Orc Grunt";
		BaseUnitDescription = "A trained Orc Grunt";
		BaseUnitImg = null;
		
		Cost = 7;
		
		Health = 160;
		Attack = 14;
		Defence = 21;
		Speed = 33;
		
		FireResistence = 0.0f;
		WaterResistence = 0.0f;
		EarthResistence = 0.4f;
		AirResistence = 0.0f;
		ShadowResistence = 0.0f;
		LightResistence = 0.0f;
		
		BasicAttack = "SLASH";
		Support = "ROAR(attack boost)";
		
		Ability = "CHARGE";
		
		Upgrade = null;
		Mutate = "ORC 2 MUTANT 1";
		Rebuild = "ORC 2 CYBORG 1";
	}
}
