using UnityEngine;
using System.Collections;

public class BaseIfritStone : BaseEquipmentClass {

	public BaseIfritStone()
	{
		BaseEquipmentName = "Ifritstone";
		BaseEquipmentDescription = "A Magical Stone Made From Ifrit Hair That Protects Aganst Fire";
		
		EquipmentType = EquipmentTypes.Accessory;
		
		Health = 0;
		Attack = 0;
		Defense = 0;
		Speed = 0;
		
		FireResistence = 0.09f;
		EarthResistence = 0f;
		WaterResistence = 0f;
		AirResistence = 0f;
		ShadowResistence = 0f;
		LightResistence = 0f;
	}
}
