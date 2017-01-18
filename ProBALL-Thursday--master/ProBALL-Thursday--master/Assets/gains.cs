using UnityEngine;
using System.Collections;

public class gains : MonoBehaviour {
	

	
	// Update is called once per frame
	void Update () {
		
	transform.Rotate(new Vector3(30,45) * Time.deltaTime);
	
	}
}
