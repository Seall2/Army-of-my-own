using UnityEngine;
using System.Collections;

public class BaseTroll : BaseUnitClass {

	public BaseTroll()
	{
		UnitID = "t1";
		BaseUnitName = "Troll";
		BaseUnitDescription = "An Troll with great physical strength";
		BaseUnitImg = null;
		
		Cost = 10;
		
		Health = 400;
		Attack = 14;
		Defence = 27;
		Speed = 16;
		
		FireResistence = -0.2f;
		WaterResistence = 0.0f;
		EarthResistence = 0.5f;
		AirResistence = 0.0f;
		ShadowResistence = 0.0f;
		LightResistence = 0.0f;
		
		BasicAttack = "SMACK";
		Support = "ROAR(attack boost)";
		
		Ability = "CHARGE";
		
		//Upgrade = upgradeUnit;
		Upgrade = "O2";
		Mutate = "ORC MUTANT";
		Rebuild = "O1C1";
	}
}
