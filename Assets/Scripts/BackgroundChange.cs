using UnityEngine;
using System.Collections;

public class BackgroundChange : MonoBehaviour {

    public Sprite spriteTrans;
    public Sprite spriteNormal;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Transformacion.estadoMundo==1)
        {
            this.GetComponent<SpriteRenderer>().sprite = spriteTrans;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = spriteNormal;
        }
	
	}
}
