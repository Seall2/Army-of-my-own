using UnityEngine;
using System.Collections;

public class BaseUnitClass
{
	private string unitID;
	private string baseUnitName;
	private string baseUnitDescription;
	private Texture2D baseUnitImg;

	private int cost;

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

	//Placeholder unit attacks
	private string basicAttack;
	private string support;

	//Placeholder unit ability
	private string ability;

	//Placeholder evolutions
	//private BaseUnitClass upgrade;
	private string upgrade;
	private string mutate;
	private string rebuild;

	public string UnitID
	{
		get{ return baseUnitName;}
		set{ baseUnitName = value;}
	}

	public string BaseUnitName
	{
		get{ return baseUnitName;}
		set{ baseUnitName = value;}
	}

	public string BaseUnitDescription
	{
		get{ return baseUnitDescription;}
		set{ baseUnitDescription = value;}
	}

	public Texture2D BaseUnitImg
	{
		get{ return baseUnitImg;}
		set{ baseUnitImg = value;}
	}

	public int Cost
	{
		get{ return cost;}
		set{ cost = value;}
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

	//Placeholder Attacks

	public string BasicAttack
	{
		get{ return basicAttack;}
		set{ basicAttack = value;}
	}

	public string Support
	{
		get{ return support;}
		set{ support = value;} 
	}

	//Placeholder Ability

	public string Ability
	{
		get{ return ability;}
		set{ ability = value;}
	}

	//Placeholder evolutions

	/*public BaseUnitClass Upgrade
	{
		get{return upgrade;}
		set{ upgrade = value;}
	}*/

	public string Upgrade
	{
		get{ return upgrade;}
		set{ upgrade = value;}
	}

	public string Mutate
	{
		get{ return mutate;}
		set{ mutate = value;}
	}

	public string Rebuild
	{
		get{ return rebuild;}
		set{ rebuild = value;}
	}
}
