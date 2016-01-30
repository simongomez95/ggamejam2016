using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	bool salto = true;
	public float speed;
	//public GameObject bullet;
	float movingSpeed = 0;
	private Rigidbody2D rb2D;  
	//Animator anim;
	bool allowFire = true;
    static public bool enAura = false;



	void Start()
	{
		//anim = GetComponent<Animator> ();
	}

	IEnumerator Fire(){
		allowFire = false;
		//Instantiate(bullet, transform.position, transform.rotation);
		yield return new WaitForSeconds (0.5f);
		allowFire = true;
	}

	void Update()
	{
		

		//if (Input.GetAxis ("Vertical") != 0 || Input.GetAxis ("Horizontal") != 0) {
		//	anim.SetBool ("isMoving", true);			
		//} else {
		//	anim.SetBool("isMoving", false);
		//}


	}

	void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag=="Aura")
        {
            enAura = true;
        }
	}

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Aura")
        {
            enAura = false;
        }
    }

	void FixedUpdate()
	{

		//limitar la rotacion a ejes XY
		//transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
		//GetComponent<Rigidbody2D>().angularVelocity = 0;

		//Movimiento en el mapa
		float input_y = Input.GetAxis("Vertical");
		float input_x = Input.GetAxis("Horizontal");
		if (Input.GetKeyDown ("space")&& salto == true){
			salto = false;
			rb2D = GetComponent<Rigidbody2D> ();
            // crear variable global para cambiar fuerza del salto
			rb2D.AddForce (Vector2.up * 10, ForceMode2D.Impulse);
		} 
		if (transform.position.y < (1)) {
			salto = true;
		}

		transform.position = new Vector3(transform.position.x + input_x * speed, transform.position.y, transform.position.z);

	}
}
