using UnityEngine;
using System.Collections;

public class Transformacion : MonoBehaviour {

    public int estadoMundo;
    bool allowTransform = true;

    void Transformar()
    {

    }

	// Use this for initialization
	void Start () {
        estadoMundo = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire2") && allowTransform == true)
        {
            //anim.SetTrigger("Attack");
            Transformar();
        }

    }
}
