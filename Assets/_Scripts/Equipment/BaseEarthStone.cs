using UnityEngine;
using System.Collections;

public class BaseEarthStone : BaseEquipmentClass {

	public BaseEarthStone()
	{
		BaseEquipmentName = "Earthstone";
		BaseEquipmentDescription = "A Magical Stone That Protects Aganst Earth";
		
		EquipmentType = EquipmentTypes.Accessory;
		
		Health = 0;
		Attack = 0;
		Defense = 0;
		Speed = 0;
		
		FireResistence = 0f;
		EarthResistence = 0.03f;
		WaterResistence = 0f;
		AirResistence = 0f;
		ShadowResistence = 0f;
		LightResistence = 0f;
	}
}
