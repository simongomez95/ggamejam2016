using UnityEngine;
using System.Collections;

public class Arbol : MonoBehaviour {

    public Sprite sp;
    public static bool terminado = false;
    

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player" && Salto2.pickups > 0)
        {
            this.GetComponent<SpriteRenderer>().sprite = sp;
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
