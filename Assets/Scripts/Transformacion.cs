using UnityEngine;
using System.Collections;

public class Transformacion : MonoBehaviour {

    //public GameObject player;
    public TransformPj transPj;
    public PlayerScript plyscr;

    public GameObject bear;
    public GameObject squirrel;
    public GameObject wolf;

    public Transform player;

    double tiempoTrans;
    static public int estadoMundo = 0;
    bool allowTransform = true;

    public void CambiarForma(int forma)
    {
        switch (forma)
        {
            case 1:
                var bearInstance = Instantiate(bear, plyscr.gameObject.transform.position, plyscr.gameObject.transform.rotation) as GameObject;
                bearInstance.transform.position = player.position;
                //gameObject.GetComponent<PlayerScript>().enabled = false;                
                break;
            case 2:
                var squirrelInstance = Instantiate(squirrel, plyscr.gameObject.transform.position, plyscr.gameObject.transform.rotation) as GameObject;
                break;
            case 3:
                var wolfInstance = Instantiate(wolf, plyscr.gameObject.transform.position, plyscr.gameObject.transform.rotation) as GameObject;
                break;
        }
    }

    void Transformar(int forma)
    {
        CambiarForma(forma);
        plyscr.enabled = false;
        allowTransform = false;
        estadoMundo = 1;
    }

	// Use this for initialization
	void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        CheckTransformButtons();
        if (tiempoTrans < 0 || PlayerScript.enAura == false)
        {
            
        }
        tiempoTrans = tiempoTrans - Time.deltaTime;

    }

    private void CheckTransformButtons()
    {
        if (Input.GetButton("TransformBear") && allowTransform == true)
        {
            //anim.SetTrigger("Attack");
            Transformar(1);
        }
        else if (Input.GetButton("TransformSquirrel"))
        {
            Transformar(2);
        }
        else if (Input.GetButton("TransformWolf"))
        {
            Transformar(3);
        }
    }

    
    public void setEstadoMundo(int estado)
    {
        estadoMundo = estado;
    }
}
