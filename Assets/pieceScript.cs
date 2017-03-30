using UnityEngine;
using System.Collections;

public class pieceScript : MonoBehaviour {

	public bool blue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}


	void OnCollisionEnter(Collision col){
		if (col.gameObject.GetComponent<pieceScript> ().blue != blue) {
			print ("hit");

		}
	}

}
