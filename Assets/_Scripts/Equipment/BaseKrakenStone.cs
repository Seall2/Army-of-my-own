using UnityEngine;
using System.Collections;

public class BaseKrakenStone : BaseEquipmentClass {

	public BaseKrakenStone()
	{
		BaseEquipmentName = "Krakenstone";
		BaseEquipmentDescription = "A Magical Stone Made From A Kraken Eye That Protects Aganst Water";
		
		EquipmentType = EquipmentTypes.Accessory;
		
		Health = 0;
		Attack = 0;
		Defense = 0;
		Speed = 0;
		
		FireResistence = 0f;
		EarthResistence = 0f;
		WaterResistence = 0.12f;
		AirResistence = 0f;
		ShadowResistence = 0f;
		LightResistence = 0f;
	}
}
