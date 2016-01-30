using UnityEngine;
using System.Collections;

public class Salto : MonoBehaviour {
	bool salto = true;
	public float speed;
	public GameObject bullet;
	float movingSpeed = 0;
	private Rigidbody2D rb2D;
	private BoxCollider2D bc2D;
	private Collider2D tierra;
	//Animator anim;
	bool allowFire = true;
	public float _timeHeld = 0.0f;
	public float _timeForFullJump = 2.0f;
	public float _minJumpForce;
	public float _maxJumpForce;
	public float _leftJumpForce = 1.0f;



	void Start()
	{
		//anim = GetComponent<Animator> ();
	}

	/*void Update()
	{
		
		bool saltar = Input.GetButton("Jump");
		bool saltarT = Input.GetKey("space");
		rb2D = GetComponent<Rigidbody2D> ();
	    bc2D = GetComponent<BoxCollider2D> ();
		bool bc2DOn = rb2D.IsTouching(tierra);
		if (saltarT && salto == true && bc2DOn== true){
			salto = false;
			bc2DOn = false; 
			//rb2D = GetComponent<Rigidbody2D> ();
			//rb2D.AddForce (Vector2.up * 10, ForceMode2D.Impulse);
			transform.position = new Vector2(transform.position.y*speed , transform.position.x);

		} 
		if (transform.position.y < (1)) {
			salto = true;
		}
		//if (Input.GetAxis ("Vertical") != 0 || Input.GetAxis ("Horizontal") != 0) {
		//	anim.SetBool ("isMoving", true);			
		//} else {
		//	anim.SetBool("isMoving", false);
		//}


	}

	void OnTriggerEnter2D() {
	}

	void FixedUpdate()
	{

		//limitar la rotacion a ejes XY
		//transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
		//GetComponent<Rigidbody2D>().angularVelocity = 0;

		//Movimiento en el mapa
		float input_y = Input.GetAxis("Vertical");
		float input_x = Input.GetAxis("Horizontal");

		transform.position = new Vector3(transform.position.x + input_x * speed, transform.position.y, transform.position.z);
		||Input.GetButtonDown(buttonName:Jump)
	}
	*/
	void Update ()
	{
		if (salto == true) {
			salto = false;
			if (Input.GetKeyDown (KeyCode.Space)) {
				_timeHeld = 0f;
			}
			if (Input.GetKey (KeyCode.Space)) {
				_timeHeld += Time.deltaTime;
			}
			if (Input.GetKeyUp (KeyCode.Space)) {
				Jump ();
			}
		} 
		if (transform.position.y < (1)) {
			salto = true;
		}
		float input_y = Input.GetAxis("Vertical");
		float input_x = Input.GetAxis("Horizontal");
		transform.position = new Vector3(transform.position.x + input_x * speed, transform.position.y, transform.position.z);
	}

	public void Jump()
	{	

		float verticalJumpForce = ((_maxJumpForce - _minJumpForce) * (_timeHeld / _timeForFullJump)) + _minJumpForce;
		if (verticalJumpForce > _maxJumpForce)
		{
			verticalJumpForce = _maxJumpForce;
		}
		Vector2 resolvedJump = new Vector2(0, verticalJumpForce);
		rb2D = GetComponent<Rigidbody2D> ();
		rb2D.AddForce(resolvedJump, ForceMode2D.Impulse);
		Debug.Log(resolvedJump.ToString());
	}
	
}
