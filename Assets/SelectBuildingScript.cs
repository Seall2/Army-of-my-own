using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectBuildingScript : MonoBehaviour {

	public GameObject Building;
	public Text Writting;



	public void SelectGoblinoidBarrack()
	{
		if (Building != null) {
			GameManager.me.SelectedBuilding = Building;
			BaseGoblinoidBuildingClass b = new BaseGoblinoidBuildingClass();
			Writting.text = b.BuildingName;

		}
	}
}
