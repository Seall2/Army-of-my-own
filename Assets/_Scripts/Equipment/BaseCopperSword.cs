using UnityEngine;
using System.Collections;

public class BaseCopperSword : BaseEquipmentClass {

	public BaseCopperSword()
	{
		BaseEquipmentName = "Copper Sword";
		BaseEquipmentDescription = "A Sword Made Of Soft Copper";

		EquipmentType = EquipmentTypes.Weapon;

		Health = 0;
		Attack = 5;
		Defense = 0;
		Speed = 0;

		FireResistence = 0f;
		EarthResistence = 0f;
		WaterResistence = 0f;
		AirResistence = 0f;
		ShadowResistence = 0f;
		LightResistence = 0f;
	}


}
