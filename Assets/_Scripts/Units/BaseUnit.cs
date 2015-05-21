using UnityEngine;
using System.Collections;

public class BaseUnit
{
	private string unitName;
	private BaseUnitClass unitClass;

	private int health;
	private int attack;
	private int defence;
	private int speed;

	private float fireResistence;
	private float waterResistence;
	private float earthResistence;
	private float airResistence;
	private float shadowResistence;
	private float lightResistence;

	public string UnitName
	{
		get{ return unitName;}
		set{ unitName = value;}
	}

	public BaseUnitClass UnitClass
	{
		get{ return unitClass;}
		set{ unitClass = value;}
	}

	public int Health
	{
		get{ return health;}
		set{ health = value;}
	}
	
	public int Attack
	{
		get{ return attack;}
		set{ attack = value;}
	}
	
	public int Defence
	{
		get{ return defence;}
		set{ defence = value;}
	}
	
	public int Speed
	{
		get{return speed;}
		set{ speed = value;}
	}
	
	public float FireResistence
	{
		get{ return fireResistence;}
		set{ fireResistence = value;}
	}
	
	public float WaterResistence
	{
		get{ return waterResistence;}
		set{ waterResistence = value;}
	}
	
	public float EarthResistence
	{
		get{ return earthResistence;}
		set{ earthResistence = value;}
	}
	
	public float AirResistence
	{
		get{ return airResistence;}
		set{ airResistence = value;}
	}
	
	public float ShadowResistence
	{
		get{ return shadowResistence;}
		set{ shadowResistence = value;}
	}
	
	public float LightResistence
	{
		get{ return lightResistence;}
		set{ lightResistence = value;}
	}
}
