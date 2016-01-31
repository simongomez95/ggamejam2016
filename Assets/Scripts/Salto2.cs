using UnityEngine;
using System.Collections;

public class Salto2 : MonoBehaviour {
	bool salto = true;
	int numSaltos=0;
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
    Animator anim;
	static public bool enAura = false;
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Aura" && this.gameObject.tag != "Player")
		{
			enAura = true;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Aura" && this.gameObject.tag != "Player")
		{
			enAura = false;
		}
	}

	void Start()
	{
		anim = GetComponent<Animator> ();
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
        

        salto = false;
			if (Input.GetButtonDown ("Jump")) {
				_timeHeld = 0f;
			}
			if (Input.GetButton ("Jump")) {
				_timeHeld += Time.deltaTime;
			}
			if (Input.GetButtonUp ("Jump")) {
				numSaltos += 1;
				if (numSaltos < 2) {
					Jump ();
                Debug.Log(numSaltos.ToString());
				}
			}
		//float input_y = Input.GetAxis("Vertical");
		float input_x = Input.GetAxis("Horizontal");
        if (input_x != 0)
        {
            if (input_x < 0)
            {
                //m_FacingRight = false;
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
            else
            {
                //m_FacingRight = true;
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            anim.SetBool("corriendo", true);
            Debug.Log("corriendo");

        }
        else
        {
            anim.SetBool("corriendo", false);
        }
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

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Environment")
        {
            numSaltos = 0;
        }
    }
}
