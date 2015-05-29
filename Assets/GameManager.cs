using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	public GameObject MessangeBox;
	public GameObject BuildingButton;
	public GameObject SelectedBuilding;

	public static GameManager me = null;
	void Awake()
	{
		if (me != null) {
			Debug.LogError ("Error");
		}
		me = this;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
