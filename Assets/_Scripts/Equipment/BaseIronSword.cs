using UnityEngine;
using System.Collections;

public class BaseIronSword : BaseEquipmentClass {

	public BaseIronSword()
	{
		BaseEquipmentName = "Iron Sword";
		BaseEquipmentDescription = "A Sword Made Of Wrought Iron";
		
		EquipmentType = EquipmentTypes.Weapon;
		
		Health = 0;
		Attack = 8;
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
