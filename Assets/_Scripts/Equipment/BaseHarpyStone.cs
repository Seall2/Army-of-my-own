using UnityEngine;
using System.Collections;

public class BaseHarpyStone : BaseEquipmentClass {

	public BaseHarpyStone()
	{
		BaseEquipmentName = "Harpystone";
		BaseEquipmentDescription = "A Magical Stone Made From Harpy Hair That Protects Aganst Air";
		
		EquipmentType = EquipmentTypes.Accessory;
		
		Health = 0;
		Attack = 0;
		Defense = 0;
		Speed = 0;
		
		FireResistence = 0f;
		EarthResistence = 0f;
		WaterResistence = 0f;
		AirResistence = 0.06f;
		ShadowResistence = 0f;
		LightResistence = 0f;
	}
}
