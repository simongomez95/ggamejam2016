using UnityEngine;
using System.Collections;

public class Movibles : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bear")
        {
            GetComponent<Rigidbody2D>().isKinematic = false;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        GetComponent<Rigidbody2D>().isKinematic = true;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
    }
}
