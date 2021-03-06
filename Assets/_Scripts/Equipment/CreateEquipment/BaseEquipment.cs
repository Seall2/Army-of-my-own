﻿using UnityEngine;
using System.Collections;

public class BaseEquipment
{
	private BaseEquipmentClass.EquipmentTypes equipmentTypes;
	private BaseEquipmentClass equipmentClass;

	private bool isEquipped;
	
	private string baseEquipmentName;
	private string baseEquipmentDescription;
	
	private int health;
	private int attack;
	private int defense;
	private int speed;
	
	private float fireResistence;
	private float earthResistence;
	private float waterResistence;
	private float airResistence;
	private float shadowResistence;
	private float lightResistence;

	public BaseEquipmentClass.EquipmentTypes EquipmentType{ get; set;}
	public BaseEquipmentClass EquipmentClass{ get; set; }
	
	public bool IsEquipped{ get; set;}
	
	public string BaseEquipmentName{ get; set;}
	public string BaseEquipmentDescription{ get; set;}
	
	public int Health{ get; set;}
	public int Attack{ get; set;}
	public int Defense{ get; set;}
	public int Speed{ get; set;}
	
	public float FireResistence{ get; set;}
	public float EarthResistence{ get; set;}
	public float WaterResistence{ get; set;}
	public float AirResistence{ get; set;}
	public float ShadowResistence{ get; set;}
	public float LightResistence{ get; set;}
}
