using UnityEngine;
using System.Collections;

public class BaseMythrilSword : BaseEquipmentClass {

	public BaseMythrilSword()
	{
		BaseEquipmentName = "Mythril Sword";
		BaseEquipmentDescription = "A Sword Made Of The Rare Metal Mythrill";
		
		EquipmentType = EquipmentTypes.Weapon;
		
		Health = 0;
		Attack = 14;
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
