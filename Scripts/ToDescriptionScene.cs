using UnityEngine;
using System.Collections;

public class ToDescriptionScene : MonoBehaviour {

	private float time = 0.0f;
	
	// Update is called once per frame
	void Update () {
		time = time + Time.deltaTime;
		if(time >= 5.5f){
			time = 0;
			Application.LoadLevel ("DescriptionScene");
		}
	}
}
