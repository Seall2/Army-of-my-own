using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateUnitScript : MonoBehaviour {

	public Text Writting;
	private BaseUnitClass selectedUnit;

	public void CreateUnit()
	{
		if (GameManager.me.SelectedUnit != null)
		{
			selectedUnit = GameManager.me.SelectedUnit;
			BaseUnit bu = new BaseUnit();
			bu.UnitClass = selectedUnit;
			bu.SetAllStatsToUnitClass();

			Writting.text = "";
			GameManager.me.SelectedUnit = null;

		}

	}
}
