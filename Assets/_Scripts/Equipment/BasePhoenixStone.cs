using UnityEngine;
using System.Collections;

public class BasePhoenixStone : BaseEquipmentClass {

	public BasePhoenixStone()
	{
		BaseEquipmentName = "Phoenixstone";
		BaseEquipmentDescription = "A Magical Stone Made From Phoenix Feathers That Protects Aganst Fire";
		
		EquipmentType = EquipmentTypes.Accessory;
		
		Health = 0;
		Attack = 0;
		Defense = 0;
		Speed = 0;
		
		FireResistence = 0.15f;
		EarthResistence = 0f;
		WaterResistence = 0f;
		AirResistence = 0f;
		ShadowResistence = 0f;
		LightResistence = 0f;
	}
}
