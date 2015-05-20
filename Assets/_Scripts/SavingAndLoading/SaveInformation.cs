using UnityEngine;
using System.Collections;

public class SaveInformation
{
	public static void SaveAllInformation()
	{
		PlayerPrefs.SetString ("PLAYERNAME", GameInformation.PlayerName);
		PlayerPrefs.SetInt ("PLAYERLEVEL", GameInformation.PlayerLevel);
		PlayerPrefs.SetInt ("EXP", GameInformation.Exp);
		PlayerPrefs.SetInt ("ARMYCOST", GameInformation.ArmyCost);

		PlayerPrefsX.SetStringArray ("UNITS", GameInformation.ArmyCost);
		PlayerPrefsX.SetStringArray ("EQUIPMENT", GameInformation.Equipment);
	}
}
