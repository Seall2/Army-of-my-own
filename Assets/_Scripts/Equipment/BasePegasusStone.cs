using UnityEngine;
using System.Collections;

public class BasePegasusStone : BaseEquipmentClass {

	public BasePegasusStone()
	{
		BaseEquipmentName = "Pegasusstone";
		BaseEquipmentDescription = "A Magical Stone Made From Pegasus Feathers That Protects Aganst Air";
		
		EquipmentType = EquipmentTypes.Accessory;
		
		Health = 0;
		Attack = 0;
		Defense = 0;
		Speed = 0;
		
		FireResistence = 0f;
		EarthResistence = 0f;
		WaterResistence = 0f;
		AirResistence = 0.09f;
		ShadowResistence = 0f;
		LightResistence = 0f;
	}
}
