using UnityEngine;
using System.Collections;

public class Transformacion : MonoBehaviour {

    public TransformPj transPj;
    public PlayerScript playerScr;

    int estadoMundo;
    bool allowTransform = true;
    

    void Transformar()
    {
        transPj.Transformar(1);
        transPj.enabled = false;
        allowTransform = false;
    }

	// Use this for initialization
	void Start () {
        
	
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
