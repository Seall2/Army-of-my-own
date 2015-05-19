using UnityEngine;
using System.Collections;

public class BaseGnomeStone : BaseEquipmentClass {

	public BaseGnomeStone()
	{
		BaseEquipmentName = "Gnomestone";
		BaseEquipmentDescription = "A Magical Stone Made From Gnome Blood That Protects Aganst Earth";
		
		EquipmentType = EquipmentTypes.Accessory;
		
		Health = 0;
		Attack = 0;
		Defense = 0;
		Speed = 0;
		
		FireResistence = 0f;
		EarthResistence = 0.06f;
		WaterResistence = 0f;
		AirResistence = 0f;
		ShadowResistence = 0f;
		LightResistence = 0f;
	}
}
