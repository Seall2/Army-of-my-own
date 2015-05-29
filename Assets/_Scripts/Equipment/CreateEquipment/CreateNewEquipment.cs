using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateNewEquipment : MonoBehaviour 
{
	private BaseEquipment newEquipment;
	private bool isCopperSword;
	private bool isIronSword;
	private bool isSteelSword;
	private bool isAirStone;
	private bool isFireStone;
	
	private string tempName;

	// Use this for initialization
	void Start () 
	{
		newEquipment = new BaseEquipment ();
		GameInformation.Equipment2 = new List<string>();
	}

	void OnGUI()
	{
		isCopperSword = GUILayout.Toggle (isCopperSword, "CopperSword");
		isIronSword = GUILayout.Toggle (isIronSword, "IronSword");
		isSteelSword = GUILayout.Toggle (isSteelSword, "SteelSword");
		isAirStone = GUILayout.Toggle (isAirStone, "AirStone");
		isFireStone = GUILayout.Toggle (isFireStone, "FireStone");

		GUI.Label(new Rect(100, 100, 100, 500), tempName);
		
		if (GUILayout.Button ("Create")) 
		{
			if(isCopperSword)
			{
				newEquipment.EquipmentClass = new BaseCopperSword();
			}
			else if(isIronSword)
			{
				newEquipment.EquipmentClass = new BaseIronSword();
			}
			else if(isSteelSword)
			{
				newEquipment.EquipmentClass = new BaseSteelSword();
			}
			else if(isAirStone)
			{
				newEquipment.EquipmentClass = new BaseAirStone();
			}
			else if(isFireStone)
			{
				newEquipment.EquipmentClass = new BaseFireStone();
			}
			GameInformation.Equipment2.Add(newEquipment.BaseEquipmentName);
			if (GameInformation.Equipment2.Count > 0) {
				foreach (string s in GameInformation.Equipment2) {
					Debug.Log ("stuff" +s);
				}
			}
			newEquipment.BaseEquipmentName = newEquipment.EquipmentClass.BaseEquipmentName;
			StoreNewPlayerInfo();
			tempName = GameInformation.Equip;
			//SaveInformation.SaveAllInformation();
		}
	}

	/*private string CreatedEquipment()
	{
		if(GameInformation.Equipment2.Contains("Copper Sword"))
		{
			BaseEquipmentClass tempClass = new BaseCopperSword();
			string tempName = "Item Name: " + tempClass.BaseEquipmentName;

			return tempName;
		}

		return "";
	}*/

	// Update is called once per frame
	void Update () 
	{

		/*if (GameInformation.Equipment2.Contains ("Copper Sword")) 
		{
			BaseEquipmentClass tempClass = new BaseCopperSword ();
			tempName = "Item Name: " + tempClass.BaseEquipmentName;
		} 
		else 
		{
			tempName = "";
		}*/
	}

	private void StoreNewPlayerInfo()
	{
		//GameInformation.Equipment = newEquipment.BaseEquipmentName;
		//GameInformation.Equipment.Add (newEquipment.BaseEquipmentName);
		//GameInformation.Equipment2.Add(newEquipment.BaseEquipmentName);
		GameInformation.Equip = newEquipment.BaseEquipmentName;
	}
}

