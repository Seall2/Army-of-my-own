using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	public GameObject Base;
	public GameObject MessangeBox;
	public GameObject BuildingButton;
	public GameObject SelectedBuilding;
	private BaseUnitClass selectedUnit;

	public static GameManager me = null;
	void Awake()
	{
		if (me != null) {
			Debug.LogError ("Error");
		}
		me = this;
	}

	public BaseUnitClass SelectedUnit{get;set;}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
