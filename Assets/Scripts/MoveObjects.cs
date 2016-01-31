using UnityEngine;
using System.Collections;

public class MoveObjects : MonoBehaviour {
	public int pushPower;
	ControllerColliderHit puja;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		
	}

	/*void OnControllerColliderHit(Collider2D hit) {
		Rigidbody2D body = hit.GetComponent<Collider>();
		if (body == null || body.isKinematic)
			return;

		if (hit.moveDirection.y < -0.3F)
			return;
		body.AddForce(hit.GetComponent<Rigidbody2D>().velocity.normalized*pushPower);
		//Vector3 pushDir = new Vector3(hit.moveDirection.x, 0,0);
		body.velocity = pushDir * pushPower;
	}*/
	void OnTriggerEnter2D(Collider2D coll) {
		//Rigidbody2D rb2D = GetComponent<Rigidbody2D> ();
		//rb2D.AddForce (coll.attachedRigidbody);
		//Vector2 pushDir = new Vector2(rb2D.MovePosition, 0);
		//rb2D.velocity = pushDir * pushPower;
	}
}
