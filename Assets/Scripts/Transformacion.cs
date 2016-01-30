using UnityEngine;
using System.Collections;

public class Transformacion : MonoBehaviour {

    //public GameObject player;
    public TransformPj transPj;
    public PlayerScript plyscr;

    int estadoMundo;
    bool allowTransform = true;
    

    void Transformar()
    {
        transPj.CambiarForma(1);
        plyscr.enabled = false;
        allowTransform = false;
    }

	// Use this for initialization
	void Start () {
        //transPj = player.GetComponent<TransformPj>;
        //plyscr = player.GetComponent<PlayerScript>;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1") && allowTransform == true)
        {
            //anim.SetTrigger("Attack");
            Transformar();
        }

    }

    public void setEstadoMundo(int estado)
    {
        estadoMundo = estado;
    }
}
