using UnityEngine;
using System.Collections;

public class BaseOrichalcumSword : BaseEquipmentClass {

	public BaseOrichalcumSword()
	{
		BaseEquipmentName = "Orichalcum Sword";
		BaseEquipmentDescription = "A Sword Made Of Magical Orichalcum Metal";
		
		EquipmentType = EquipmentTypes.Weapon;
		
		Health = 0;
		Attack = 20;
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
