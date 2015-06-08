using UnityEngine;
using System.Collections;

public class ViewUnits : MonoBehaviour 
{
	public enum ViewUnitsStates
	{
		MAINMENU,
		VIEWUNIT,
		UNIT
	}

	private ViewUnitsFunctions viewFunctions = new ViewUnitsFunctions ();
	public static ViewUnitsStates currentstate;

	// Use this for initialization
	void Start () 
	{
		currentstate = ViewUnitsStates.MAINMENU;
	}
	
	// Update is called once per frame
	void Update () 
	{
		switch (currentstate) 
		{
		case(ViewUnitsStates.MAINMENU):
			break;
		case(ViewUnitsStates.VIEWUNIT):
			break;
		case(ViewUnitsStates.UNIT):
			break;
		}
	}

	void OnGUI()
	{
		viewFunctions.DisplayMainItems ();

		if (currentstate == ViewUnitsStates.MAINMENU) 
		{
		}
		
		if (currentstate == ViewUnitsStates.VIEWUNIT) 
		{
			viewFunctions.DisplayUnits();
		}
		if (currentstate == ViewUnitsStates.UNIT) 
		{
			viewFunctions.DisplayUnit();
		}
	}
}
