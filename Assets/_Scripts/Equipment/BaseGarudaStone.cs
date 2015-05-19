using UnityEngine;
using System.Collections;

public class BaseGarudaStone : BaseEquipmentClass
{
	public BaseGarudaStone()
{
	BaseEquipmentName = "Garudastone";
	BaseEquipmentDescription = "A Magical Stone Made From Garuda Feathers That Protects Aganst Air";
	
	EquipmentType = EquipmentTypes.Accessory;
	
	Health = 0;
	Attack = 0;
	Defense = 0;
	Speed = 0;
	
	FireResistence = 0f;
	EarthResistence = 0f;
	WaterResistence = 0f;
	AirResistence = 0.15f;
	ShadowResistence = 0f;
	LightResistence = 0f;
}
}
