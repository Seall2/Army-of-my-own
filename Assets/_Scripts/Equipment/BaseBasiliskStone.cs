using UnityEngine;
using System.Collections;

public class BaseBasiliskStone : BaseEquipmentClass {

	public BaseBasiliskStone()
	{
		BaseEquipmentName = "Basiliskstone";
		BaseEquipmentDescription = "A Magical Stone Made From Basilisk Fangs That Protects Aganst Earth";
		
		EquipmentType = EquipmentTypes.Accessory;
		
		Health = 0;
		Attack = 0;
		Defense = 0;
		Speed = 0;
		
		FireResistence = 0f;
		EarthResistence = 0.12f;
		WaterResistence = 0f;
		AirResistence = 0f;
		ShadowResistence = 0f;
		LightResistence = 0f;
	}
}
