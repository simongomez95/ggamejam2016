using UnityEngine;
using System.Collections;

public class Transformacion : MonoBehaviour {

    //public GameObject player;
    public TransformPj transPj;
    public Salto2 plyscr;

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
        //Debug.Log(Salto.enAura.ToString()); 

        if (tiempoTrans < 0)
        {
            if (Salto2.enAura == false)
            {

                Application.LoadLevel("ads");
            }
            else
            {
                
                estadoMundo = 0;
            }
        }
        if (estadoMundo == 1)
        {
            PararTiempo(0);
            tiempoTrans = tiempoTrans - Time.deltaTime;
        }
        else
        {
            PararTiempo(1);
            tiempoTrans = 10;
            allowTransform = true;
        }
    }

    void PararTiempo(int funcion)
    {
        GameObject[] objetos = GameObject.FindGameObjectsWithTag("Environment");
        if (funcion == 0)
        {
            foreach (GameObject objeto in objetos)
            {
                if (objeto.GetComponent<Rigidbody2D>() != null)
                {
                    objeto.GetComponent<Rigidbody2D>().isKinematic = true;
                }
            }
        }
        else if (funcion==1)
        {
            //Despara el tiempo?
            foreach (GameObject objeto in objetos)
            {
                if (objeto.GetComponent<Rigidbody2D>() != null)
                {
                    objeto.GetComponent<Rigidbody2D>().isKinematic = false;
                }
            }
        }
    }

   

    
    public void setEstadoMundo(int estado)
    {
        estadoMundo = estado;
    }
}
