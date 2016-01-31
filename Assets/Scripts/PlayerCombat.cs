using UnityEngine;
using System.Collections;

public class PlayerCombat : MonoBehaviour {
	private CircleCollider2D rangoAtaque;
	private Animator animator; 
	bool atacando = false;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Attack")) {
			atacando = true;
			animator.SetBool("atacando", true);
            Debug.Log("atacando");
		} else {
			atacando = false;
            animator.SetBool("atacando", false);
        }
	}
	void OnCollisionEnter2D(Collision2D other){
		if (atacando && other.gameObject.tag == "Enemy") {
			Destroy (other.gameObject);
		}
	}
}
