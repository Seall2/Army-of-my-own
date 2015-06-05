using UnityEngine;
using UnityEditor.Events;
using System.Collections;

public class CreateOrc : MonoBehaviour {

	// Use this for initialization

	public BaseBuildingClass goblins = new BaseGoblinoidBuildingClass();


	public void MakeCharlie()
	{

		BaseUnit bu = new BaseUnit ();
		bu.UnitClass = new BaseOrcClass ();
		bu.UnitName = "Bob";
		bu.Health = bu.UnitClass.Health;
		bu.Attack = bu.UnitClass.Attack;
		bu.Defence = bu.UnitClass.Defence;
		bu.Speed = bu.UnitClass.Speed;


		
		bu.FireResistence = bu.UnitClass.FireResistence;
		bu.EarthResistence = bu.UnitClass.EarthResistence;
		bu.WaterResistence = bu.UnitClass.WaterResistence;
		bu.AirResistence = bu.UnitClass.AirResistence;
		bu.ShadowResistence = bu.UnitClass.ShadowResistence;
		bu.LightResistence = bu.UnitClass.LightResistence;

		GameInformation.UnitName = bu.UnitName;

		
		Debug.Log ("UnitName: " +bu.UnitName);
		Debug.Log ("UnitClass: " + bu.UnitClass.BaseUnitName);
		Debug.Log ("Health: " + bu.Health);
	    Debug.Log ("Attack: " +bu.Attack);
		Debug.Log ("Defense: " +bu.Defence);
		Debug.Log ("Speed: " +bu.Speed);
		Debug.Log ("FireResistence: " +bu.FireResistence);
		Debug.Log ("EarthResistence: " +bu.EarthResistence);
		Debug.Log ("WaterResistence: " +bu.WaterResistence);
		Debug.Log ("AirResistence: " +bu.AirResistence);
		Debug.Log ("ShadowResistence: " +bu.ShadowResistence);
		Debug.Log ("LightResistence: " +bu.LightResistence);

		Debug.Log ("Saved Name: " + GameInformation.UnitName);


	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
