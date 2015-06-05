using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuildBuildingScript : MonoBehaviour {

	private GameObject button; 
	private GameObject building;
	public Text text;



	public void BuildBuilding()
	{
		if(GameManager.me.BuildingButton != null)
		{
			button = GameManager.me.BuildingButton;
			if(GameManager.me.SelectedBuilding != null)
			{
				building = GameManager.me.SelectedBuilding;
				if (button != null && building != null) {
					BuildingScript bs = button.GetComponent<BuildingScript>();
					bs.buildingWindow = building;
					Button b = button.GetComponent<Button>();
					b.image.sprite = bs.Building1;
					//Button bb = this.gameObject.GetComponent<Button>();
					//bb.image.sprite = Frame1;
					Debug.Log("wtf");
					GameManager.me.BuildingButton = null;
					GameManager.me.SelectedBuilding = null;
					text.text = "";
					GameManager.me.MessangeBox.SetActive(false);
					GameManager.me.Base.SetActive(true);

				}
			}
		}



	}

	public void NullManager()
	{
		GameManager.me.BuildingButton = null;
		GameManager.me.SelectedBuilding = null;
		text.text = "";
		GameManager.me.Base.SetActive(true);

	}
}
