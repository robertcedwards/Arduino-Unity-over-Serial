using UnityEngine;
using System.Collections;

public class flashlight : MonoBehaviour {

	public bool on = false;
	
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.F))
			on = !on;
		if(on)
			GetComponent<Light>().enabled = true;
		else if(!on)
			GetComponent<Light>().enabled = false;
	}
}