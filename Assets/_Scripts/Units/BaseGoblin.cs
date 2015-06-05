using UnityEngine;
using System.Collections;

public class BaseGoblin : BaseUnitClass {

	public BaseGoblin()
	{
		UnitID = "g1";
		BaseUnitName = "Goblin";
		BaseUnitDescription = "An goblin with little self-preservation skills";
		BaseUnitImg = null;
		
		Cost = 1;
		
		Health = 40;
		Attack = 2;
		Defence = 9;
		Speed = 50;
		
		FireResistence = 0.05f;
		WaterResistence = 0.0f;
		EarthResistence = 0.2f;
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
