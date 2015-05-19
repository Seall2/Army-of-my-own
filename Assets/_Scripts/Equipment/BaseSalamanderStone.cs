using UnityEngine;
using System.Collections;

public class BaseSalamanderStone : BaseEquipmentClass {

	public BaseSalamanderStone()
	{
		BaseEquipmentName = "Salamanderstone";
		BaseEquipmentDescription = "A Magical Stone Made From Salamander Blood That Protects Aganst Fire";
		
		EquipmentType = EquipmentTypes.Accessory;
		
		Health = 0;
		Attack = 0;
		Defense = 0;
		Speed = 0;
		
		FireResistence = 0.06f;
		EarthResistence = 0f;
		WaterResistence = 0f;
		AirResistence = 0f;
		ShadowResistence = 0f;
		LightResistence = 0f;
	}
}
