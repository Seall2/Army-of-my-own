using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuildBuildingScript : MonoBehaviour {

	private GameObject Button; 
	private GameObject Building;
	public Text text;



	public void BuildBuilding()
	{
		if(GameManager.me.BuildingButton != null)
		{
			Button = GameManager.me.BuildingButton;
			if(GameManager.me.SelectedBuilding != null)
			{
				Building = GameManager.me.SelectedBuilding;
				if (Button != null && Building != null) {
					BuildingScript bs = Button.GetComponent<BuildingScript>();
					bs.buildingWindow = Building;
					Debug.Log("wtf");
					GameManager.me.BuildingButton = null;
					GameManager.me.SelectedBuilding = null;
					text.text = "";
					GameManager.me.MessangeBox.SetActive(false);

				}
			}
		}



	}
}
