﻿using UnityEngine;
using System.Collections;

public class BaseMermaidStone : BaseEquipmentClass {

	public BaseMermaidStone()
	{
		BaseEquipmentName = "Mermaidstone";
		BaseEquipmentDescription = "A Magical Stone Made From Mermaid Tears That Protects Aganst Water";
		
		EquipmentType = EquipmentTypes.Accessory;
		
		Health = 0;
		Attack = 0;
		Defense = 0;
		Speed = 0;
		
		FireResistence = 0f;
		EarthResistence = 0f;
		WaterResistence = 0.06f;
		AirResistence = 0f;
		ShadowResistence = 0f;
		LightResistence = 0f;
	}
}
