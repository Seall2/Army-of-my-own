using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuildingScript : MonoBehaviour {

	public GameObject buildingWindow;
	public Sprite Frame1;
	public Sprite Building1;

	//public IList<GameObject> buildings;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//this.gameObject.GetComponent<>();

	
	}

	public void OpenBuildingWindow()
	{


		Debug.Log("logbug");
		if (buildingWindow == null) {
			GameManager.me.BuildingButton = this.gameObject;
			GameManager.me.MessangeBox.SetActive (true);
			GameManager.me.Base.SetActive(false);
			//Button bb = this.gameObject.GetComponent<Button>();
			//bb.image.sprite = Frame1;
			Debug.Log("f..k");


		} else {

			buildingWindow.SetActive(true);
			GameManager.me.Base.SetActive(false);
		}
	}
}
