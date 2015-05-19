using UnityEngine;
using System.Collections;

public class BaseDryadStone : BaseEquipmentClass {

	public BaseDryadStone()
	{
		BaseEquipmentName = "Dryadstone";
		BaseEquipmentDescription = "A Magical Stone Made From Dryad Hair That Protects Aganst Earth";
		
		EquipmentType = EquipmentTypes.Accessory;
		
		Health = 0;
		Attack = 0;
		Defense = 0;
		Speed = 0;
		
		FireResistence = 0f;
		EarthResistence = 0.09f;
		WaterResistence = 0f;
		AirResistence = 0f;
		ShadowResistence = 0f;
		LightResistence = 0f;
	}
}
