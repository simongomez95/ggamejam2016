using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float speed;
	public GameObject bullet;
	float movingSpeed = 0;
	Animator anim;
	bool allowFire = true;



	void Start()
	{
		anim = GetComponent<Animator> ();
	}

	IEnumerator Fire(){
		allowFire = false;
		Instantiate(bullet, transform.position, transform.rotation);
		yield return new WaitForSeconds (0.5f);
		allowFire = true;
	}

	void Update()
	{
		

		if (Input.GetAxis ("Vertical") != 0 || Input.GetAxis ("Horizontal") != 0) {
			anim.SetBool ("isMoving", true);			
		} else {
			anim.SetBool("isMoving", false);
		}
	}

	void OnTriggerEnter2D() {
	}

	void FixedUpdate()
	{

		//limitar la rotacion a ejes XY
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
		GetComponent<Rigidbody2D>().angularVelocity = 0;

		//Movimiento en el mapa
		float input_y = Input.GetAxis ("Vertical");
		float input_x = Input.GetAxis ("Horizontal");

		transform.position = new Vector3(transform.position.x + input_x * speed, transform.position.y, transform.position.z);


	}
}
