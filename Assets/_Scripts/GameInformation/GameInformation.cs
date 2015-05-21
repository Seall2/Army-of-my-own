using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameInformation : MonoBehaviour
{
	void Awake()
	{
		DontDestroyOnLoad (transform.gameObject);
	}

	public static string PlayerName{ get; set; }

	public static int PlayerLevel{ get; set; }
	public static int Exp{ get; set; }

	public static int ArmyCost{ get; set; }

	public static string[] Units{ get; set; }
	public static string[] Equipment{ get; set; }

	public static List<string> Equipment2{ get; set; }
}
