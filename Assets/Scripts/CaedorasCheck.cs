using UnityEngine;
using System.Collections;

public class CaedorasCheck : MonoBehaviour {

    public GameObject piedras;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag=="Player")
        {
            piedras.SetActive(true);

        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
