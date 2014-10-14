using UnityEngine;
using System.Collections;

public class colour_change : MonoBehaviour {

	bool onFloor = false;

	// Use this for initialization
	void Start () {

	}
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "floor"){
			this.renderer.material.color = new Color(0,1,0);
			onFloor = true;
			GameObject.FindGameObjectWithTag("gui").SendMessage("increaseScore");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
