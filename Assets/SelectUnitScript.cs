using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectUnitScript : MonoBehaviour {

	public BaseUnitClass unit;
	public Text writting;



	public void NullMagagerUnit()
	{
		GameManager.me.SelectedUnit = null;
		GameManager.me.Base.SetActive (true);
		writting.text = "";
	}

	public void SelectOrc()
	{
		unit = new BaseOrcClass ();
		GameManager.me.SelectedUnit = unit;
		writting.text = unit.BaseUnitName;
		Debug.Log ("orc");

	}

	public void SelectGoblin()
	{
		Debug.Log ("goblin");
		unit = new BaseGoblin ();
		GameManager.me.SelectedUnit = unit;
		writting.text = unit.BaseUnitName;

		
	}

	public void SelectTroll()
	{
		unit = new BaseTroll ();
		GameManager.me.SelectedUnit = unit;
		writting.text = unit.BaseUnitName;
		Debug.Log ("troll");
		
	}


}
