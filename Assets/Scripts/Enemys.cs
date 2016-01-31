using UnityEngine;
using System.Collections;

public class Enemys : MonoBehaviour {
	//public float speed; 
	//float input_x=10;
	// Use this for initialization
	private GameObject Enemy;
	private GameObject Player;
	private float Range;
	public float Speed;
	void Start () {
		Enemy = GameObject.FindGameObjectWithTag ("Enemy");
		Player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate(Vector2.MoveTowards (-Enemy.transform.position, Player.transform.position, Range) * Speed * Time.deltaTime);
		//while(input_x!=0){
		//	transform.position = new Vector3(transform.position.x - input_x * speed, transform.position.y, transform.position.z);
		//	input_x = -1;
		//}
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			Destroy (other.gameObject);
		}
	}

}
