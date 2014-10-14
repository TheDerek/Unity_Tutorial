using UnityEngine;
using System.Collections;

public class char_control : MonoBehaviour {
	bool onFloor = false;
	float speed = 3;
	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
	}
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "floor"){
			onFloor = true;
		}
	}
	// Update is called once per frame
	void Update () {
		float y = Input.GetAxis ("Mouse X");
		float x = -Input.GetAxis ("Mouse Y");

		transform.Rotate(0,y,0);
		Camera.main.transform.Rotate (x, 0, 0);

		if (Input.GetKey ("w")) {
			this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
		if (Input.GetKey ("s")) {
			this.transform.Translate(Vector3.back * speed * Time.deltaTime);
		}
		if (Input.GetKey ("a")) {
			this.transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
		if (Input.GetKey ("d")) {
			this.transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
		if (Input.GetKey ("space")) {
			if(onFloor)
			{
				this.rigidbody.AddForce(Vector3.up*2000);
				onFloor = false;
			}
		}
	}
}
