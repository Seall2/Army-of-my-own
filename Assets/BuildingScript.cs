using UnityEngine;
using System.Collections;

public class BuildingScript : MonoBehaviour {

	public GameObject buildingWindow;

	//public IList<GameObject> buildings;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OpenBuildingWindow()
	{


		Debug.Log("logbug");
		if (buildingWindow == null) {
			GameManager.me.BuildingButton = this.gameObject;
			GameManager.me.MessangeBox.SetActive (true);


		} else {

			buildingWindow.SetActive(true);
		}
	}
}
