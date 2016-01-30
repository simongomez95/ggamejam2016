using UnityEngine;
using System.Collections;

public class CamaraSencilla : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Desplaza la camara junto con el jugador
		this.transform.position = new Vector3 (target.position.x, this.transform.position.y, this.transform.position.z);
	}
}
