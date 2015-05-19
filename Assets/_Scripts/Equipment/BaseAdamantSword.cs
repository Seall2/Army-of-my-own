using UnityEngine;
using System.Collections;

public class BaseAdamantSword : BaseEquipmentClass {

	public BaseAdamantSword()
	{
		BaseEquipmentName = "Adamant Sword";
		BaseEquipmentDescription = "A Sword Made Of Diamond Hard Adamant Metal";
		
		EquipmentType = EquipmentTypes.Weapon;
		
		Health = 0;
		Attack = 17;
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
