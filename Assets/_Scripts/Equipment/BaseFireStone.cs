using UnityEngine;
using System.Collections;

public class BaseFireStone : BaseEquipmentClass {

	public BaseFireStone()
	{
		BaseEquipmentName = "Firestone";
		BaseEquipmentDescription = "A Magical Stone that protect Against Fire";
		
		EquipmentType = EquipmentTypes.Accessory;
		
		Health = 0;
		Attack = 0;
		Defense = 0;
		Speed = 0;
		
		FireResistence = 0.03f;
		EarthResistence = 0f;
		WaterResistence = 0f;
		AirResistence = 0f;
		ShadowResistence = 0f;
		LightResistence = 0f;
	}
}
