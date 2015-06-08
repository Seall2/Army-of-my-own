using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ViewUnitsFunctions
{
	private string unitName;
	private int unitSelection;
	private string[] units = new string[50];

	private string[] u = new string[]{"O1","O2","O1","O1","O2","O2","O1","O1C1","O1C1","O1","O1C1","O1","O2","O1","O1","O2","O2","O1","O1C1","O1C1","O1","O1C1"};

	public void DisplayUnits()
	{
		FindUnits ();

		//unitSelection =  GUILayout.SelectionGrid (50, units, 10, GUILayout.MinHeight(100), GUILayout.MinWidth(550));

		unitSelection = GUI.SelectionGrid (new Rect (270, 50, 550, 100),50, units, 10);

		if(unitSelection == 0)
		{
			ViewUnits.currentstate = ViewUnits.ViewUnitsStates.UNIT;
		}
		else if(unitSelection == 1)
		{
			ViewUnits.currentstate = ViewUnits.ViewUnitsStates.UNIT;
		}
		else if(unitSelection == 2)
		{
			ViewUnits.currentstate = ViewUnits.ViewUnitsStates.UNIT;
		}
		else if(unitSelection == 3)
		{
			ViewUnits.currentstate = ViewUnits.ViewUnitsStates.UNIT;
		}
		else if(unitSelection == 4)
		{
			ViewUnits.currentstate = ViewUnits.ViewUnitsStates.UNIT;
		}
		else if(unitSelection == 5)
		{
			ViewUnits.currentstate = ViewUnits.ViewUnitsStates.UNIT;
		}
		else if(unitSelection == 6)
		{
			ViewUnits.currentstate = ViewUnits.ViewUnitsStates.UNIT;
		}
		else if(unitSelection == 7)
		{
			ViewUnits.currentstate = ViewUnits.ViewUnitsStates.UNIT;
		}
		else if(unitSelection == 8)
		{
			ViewUnits.currentstate = ViewUnits.ViewUnitsStates.UNIT;
		}
		else if(unitSelection == 9)
		{
			ViewUnits.currentstate = ViewUnits.ViewUnitsStates.UNIT;
		}
	}

	public void DisplayUnit()
	{
		GUI.Label(new Rect(450, 100, 300, 300), FindUnitStats(unitSelection));
	}

	public string FindUnitStats(int unit)
	{
		string u = units [unit];

		if (u == "O1") 
		{
			BaseUnitClass tempClass = new BaseOrcClass();
			string tempStats = "Health: " + tempClass.Health + "\n" + "Attack: " + tempClass.Attack + "\n" +
				"Defence: " + tempClass.Defence + "\n" + "Speed: " + tempClass.Speed + "\n" + "\n" +
					"Fire Resistence: " + tempClass.FireResistence + "\n" + "Water Resistence: " + tempClass.WaterResistence + 
					"\n" + "Earth Resistence: " + tempClass.EarthResistence + "\n" + "Air Resistence: " + tempClass.AirResistence + 
					"\n" + "Shadow Resistence: " + tempClass.ShadowResistence + "\n" + "Light Resistence: " + tempClass.LightResistence; 

			unitName = tempClass.BaseUnitName;

			return tempStats;
		}
		if (u == "O2") 
		{
			BaseUnitClass tempClass = new BaseOrc2Class();
			string tempStats = "Health: " + tempClass.Health + "\n" + "Attack: " + tempClass.Attack + "\n" +
				"Defence: " + tempClass.Defence + "\n" + "Speed: " + tempClass.Speed + "\n" + "\n" +
					"Fire Resistence: " + tempClass.FireResistence + "\n" + "Water Resistence: " + tempClass.WaterResistence + 
					"\n" + "Earth Resistence: " + tempClass.EarthResistence + "\n" + "Air Resistence: " + tempClass.AirResistence + 
					"\n" + "Shadow Resistence: " + tempClass.ShadowResistence + "\n" + "Light Resistence: " + tempClass.LightResistence; 

			unitName = tempClass.BaseUnitName;

			return tempStats;
		}
		if (u == "O1C1") 
		{
			BaseUnitClass tempClass = new BaseOrc1Cyborg1();
			string tempStats = "Health: " + tempClass.Health + "\n" + "Attack: " + tempClass.Attack + "\n" +
				"Defence: " + tempClass.Defence + "\n" + "Speed: " + tempClass.Speed + "\n" + "\n" +
					"Fire Resistence: " + tempClass.FireResistence + "\n" + "Water Resistence: " + tempClass.WaterResistence + 
					"\n" + "Earth Resistence: " + tempClass.EarthResistence + "\n" + "Air Resistence: " + tempClass.AirResistence + 
					"\n" + "Shadow Resistence: " + tempClass.ShadowResistence + "\n" + "Light Resistence: " + tempClass.LightResistence; 
			
			unitName = tempClass.BaseUnitName;
			
			return tempStats;
		}

		return "";
	}

	public void FindUnits()
	{
		List<string> n = new List<string> (u);

		GameInformation.Units2 = n;

		units = GameInformation.Units2.ToArray();

		//GameInformation.Units = u;

		//units = GameInformation.Units;
	}

	public void DisplayMainItems()
	{
		if (ViewUnits.currentstate != ViewUnits.ViewUnitsStates.VIEWUNIT) 
		{
			if(ViewUnits.currentstate != ViewUnits.ViewUnitsStates.UNIT)
			{
				GUI.Label (new Rect (Screen.width / 2, 20, 250, 250), "Menu");
				if (GUI.Button (new Rect (470, 370, 100, 50), "View Units")) 
				{
					ViewUnits.currentstate = ViewUnits.ViewUnitsStates.VIEWUNIT;
				}
			}
		}

		if(ViewUnits.currentstate != ViewUnits.ViewUnitsStates.MAINMENU)
		{
			if(ViewUnits.currentstate != ViewUnits.ViewUnitsStates.UNIT)
			{
				GUI.Label (new Rect (Screen.width / 2, 20, 250, 250), "Your Units");
				if (GUI.Button (new Rect (470, 370, 100, 50), "Back")) 
				{
					ViewUnits.currentstate = ViewUnits.ViewUnitsStates.MAINMENU;
				}
			}
		}

		if(ViewUnits.currentstate != ViewUnits.ViewUnitsStates.VIEWUNIT)
		{
			if(ViewUnits.currentstate != ViewUnits.ViewUnitsStates.MAINMENU)
			{
				GUI.Label (new Rect (Screen.width / 2, 20, 250, 250), unitName);
				if (GUI.Button (new Rect (470, 370, 100, 50), "Back")) 
				{
					ViewUnits.currentstate = ViewUnits.ViewUnitsStates.VIEWUNIT; 
				}
			}
		}
	}
}
