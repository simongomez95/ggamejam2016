using UnityEngine;
using System.Collections;

public class Movibles : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Animal")
        {
            GetComponent<Rigidbody2D>().isKinematic = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        GetComponent<Rigidbody2D>().isKinematic = false;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
    }
}
