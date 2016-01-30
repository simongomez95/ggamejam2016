using UnityEngine;
using System.Collections;

public class Transformacion : MonoBehaviour {

    //public GameObject player;
    public TransformPj transPj;
    public Salto plyscr;

    public Transform player;

    double tiempoTrans = 10;
    static public int estadoMundo = 0;
    bool allowTransform = true;

    

	// Use this for initialization
	void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(tiempoTrans.ToString());
        Debug.Log(Salto.enAura.ToString()); 

        if (tiempoTrans < 0 && Salto.enAura == false)
        {
            Debug.Log("WTF");
            Application.Quit();
        }
        if (estadoMundo == 1)
        {
            tiempoTrans = tiempoTrans - Time.deltaTime;
        }
    }

   

    
    public void setEstadoMundo(int estado)
    {
        estadoMundo = estado;
    }
}
