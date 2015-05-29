using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectBuildingScript : MonoBehaviour {

	public GameObject Building;
	public Text Writting;



	public void SelectBuilding()
	{
		if (Building != null) {
			GameManager.me.SelectedBuilding = Building;
			CreateOrc bs = Building.GetComponent<CreateOrc>();
			Writting.text = bs.buildingClass.BuildingName;

		}
	}
}
