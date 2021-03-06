﻿using UnityEngine;
using System.Collections;

public class BaseOrcClass : BaseUnitClass
{
	//private string upgradeUnit = new BaseOrc2Class().UnitID;

	public BaseOrcClass()
	{
		UnitID = "O1";
		BaseUnitName = "Orc";
		BaseUnitDescription = "An orc with great fury";
		BaseUnitImg = null;

		Cost = 5;

		Health = 120;
		Attack = 10;
		Defence = 19;
		Speed = 33;

		FireResistence = 0.0f;
		WaterResistence = 0.0f;
		EarthResistence = 0.3f;
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
