using UnityEngine;
using System.Collections;

public class Salto2 : MonoBehaviour {
	bool salto = true;
	public float tope;
	public static  int numSaltos=0;
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
	void Update ()
	{
        if(transform.rotation.z < -45)
        {
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, -45.0f);
        }
        if (transform.rotation.z > 45)
        {
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, 45.0f);
        }
        if (Input.GetButton ("Jump")) {
			numSaltos += 1;
			if (numSaltos == 1 ||numSaltos == 2) {
				Jump ();
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

		float verticalJumpForce = (_maxJumpForce - _minJumpForce) + _minJumpForce;
		if (verticalJumpForce < tope) {
			Vector2 resolvedJump = new Vector2 (0, verticalJumpForce);
			rb2D = GetComponent<Rigidbody2D> ();
			rb2D.AddForce (resolvedJump, ForceMode2D.Impulse);
			Debug.Log (resolvedJump.ToString ());
		} else {
			Vector2 resolvedJump = new Vector2 (0, 0);
			rb2D = GetComponent<Rigidbody2D> ();
			rb2D.AddForce (resolvedJump, ForceMode2D.Impulse);
			Debug.Log (resolvedJump.ToString ());
			tope = 0;
		}
		//if (verticalJumpForce > _maxJumpForce)
		//{
		//	verticalJumpForce = _maxJumpForce;
		//}
		/*Vector2 resolvedJump = new Vector2(0, verticalJumpForce);
		rb2D = GetComponent<Rigidbody2D> ();
		rb2D.AddForce(resolvedJump, ForceMode2D.Impulse);
		Debug.Log(resolvedJump.ToString());*/
	}


    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Environment")
        {
            numSaltos = 0;
        }
    }
}
