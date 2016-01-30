using UnityEngine;
using System.Collections;

public class Transformacion : MonoBehaviour {

    //public GameObject player;
    public TransformPj transPj;
    public Salto plyscr;

    public Transform player;

    double tiempoTrans;
    static public int estadoMundo = 0;
    bool allowTransform = true;

    

	// Use this for initialization
	void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        if (tiempoTrans < 0 || Salto.enAura == false)
        {
            Application.Quit();
        }
        tiempoTrans = tiempoTrans - Time.deltaTime;

    }

   

    
    public void setEstadoMundo(int estado)
    {
        estadoMundo = estado;
    }
}
