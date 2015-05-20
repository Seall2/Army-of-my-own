using UnityEngine;
using System.Collections;

public class BasePlayer
{
	private string playerName;

	private int playerLevel;
	private int exp;

	private int armyCost;

	public string PlayerName
	{
		get{ return playerName;}
		set{ playerName = value;}
	}

	public int PlayerLevel
	{
		get{ return playerLevel;}
		set{ playerLevel = value;}
	}

	public int EXP
	{
		get{ return exp;}
		set{ exp = value;}
	}

	public int ArmyCost
	{
		get{ return armyCost;}
		set{ armyCost = value;}
	}
}
