using UnityEngine;
using System.Collections;

public class PlayerCombat : MonoBehaviour {
	public GameObject Enemy;
	private CircleCollider2D rangoAtaque;
	private Animator animator; 
	bool atacando = false;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Q)) {
			atacando = true;
			animator.SetTrigger ("golpear");
		} else {
			atacando = false;
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if (atacando && other.tag == "Enemy") {
			Destroy (other.gameObject);
		}
	}
}
