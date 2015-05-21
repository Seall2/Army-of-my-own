using UnityEngine;
using System.Collections;

public class BaseOrc1Cyborg1 : BaseUnitClass
{
	public BaseOrc1Cyborg1()
	{
		UnitID = "O1C1";
		BaseUnitName = "Orc Cyborg";
		BaseUnitDescription = "A cybernetic enhance Orc";
		BaseUnitImg = null;
		
		Cost = 7;
		
		Health = 140;
		Attack = 19;
		Defence = 24;
		Speed = 28;
		
		FireResistence = 0.1f;
		WaterResistence = -0.2f;
		EarthResistence = 0.3f;
		AirResistence = 0.0f;
		ShadowResistence = 0.0f;
		LightResistence = 0.0f;
		
		BasicAttack = "Robo SMACK";
		Support = "Shield(increase Defence)";
		
		Ability = "Laser";

		Upgrade = null;
		Mutate = "ORC 1 CYBORG 1 MUTANT 1";
		Rebuild = "ORC 1 CYBORG 2";
	}
}
