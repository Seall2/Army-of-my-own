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

	private string isIt = GameInformation.Equipment2.ToString();

	// Use this for initialization
	void Start () 
	{
		newEquipment = new BaseEquipment ();
	}

	void OnGUI()
	{
		isCopperSword = GUILayout.Toggle (isCopperSword, "CopperSword");
		isIronSword = GUILayout.Toggle (isIronSword, "IronSword");
		isSteelSword = GUILayout.Toggle (isSteelSword, "SteelSword");
		isAirStone = GUILayout.Toggle (isAirStone, "AirStone");
		isFireStone = GUILayout.Toggle (isFireStone, "FireStone");
		
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

			newEquipment.BaseEquipmentName = newEquipment.EquipmentClass.BaseEquipmentName;
			StoreNewPlayerInfo();
			SaveInformation.SaveAllInformation();
		}
	}

	private string CreatedEquipment(string isIt)
	{
		string it = GameInformation.Equipment2.FindAll (isIt); 

		if (GameInformation.Equipment2 = "Copper Sword") 
		{
			BaseEquipmentClass temp = new BaseCopperSword();
			string tempName = "Equipment name: " + temp.BaseEquipmentName;

			return tempName;
		}

		return "";
	}

	// Update is called once per frame
	void Update () 
	{
		GUI.Label(new Rect(450, 100, 300, 300), CreatedEquipment(isIt));
	}

	private void StoreNewPlayerInfo()
	{
		//GameInformation.Equipment = newEquipment.BaseEquipmentName;
		//GameInformation.Equipment.Add (newEquipment.BaseEquipmentName);
		GameInformation.Equipment2.Add(newEquipment.BaseEquipmentName);
	}
}
