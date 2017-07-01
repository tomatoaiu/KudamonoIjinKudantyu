using UnityEngine;
using System.Collections;

public class ToSpeakOut : MonoBehaviour {

	private float rmd = 0.0f;

	public void toSpeakOut(){
		
		rmd = Random.Range(0.0f, 3.0f);
		if (rmd > 2.0f) {
			Application.LoadLevel ("EshashiKenji");
		} else if (rmd > 1.0f) {
			Application.LoadLevel ("IshikawaHaruka");
		} else {
			Application.LoadLevel ("GotoSuika");
		}
	}
}
