using UnityEngine;
using System.Collections;

public class BaseSteelSword : BaseEquipmentClass {

	public BaseSteelSword()
	{
		BaseEquipmentName = "Steel Sword";
		BaseEquipmentDescription = "A Sword Made Of Quality Steel";
		
		EquipmentType = EquipmentTypes.Weapon;
		
		Health = 0;
		Attack = 11;
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
