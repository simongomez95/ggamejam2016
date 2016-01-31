using UnityEngine;
using System.Collections;

public class CamaraSencilla : MonoBehaviour {

	public Transform realTarget;
    public static Transform target;

	// Use this for initialization
	void Start () {
        target = realTarget;
	}
	
	// Update is called once per frame
	void Update () {
        //Desplaza la camara junto con el jugador
        if (target != null)
        {
            if (Transformacion.estadoMundo == 0 && target != realTarget)
            {
                target = realTarget;
            }
            this.transform.position = new Vector3(target.position.x, this.transform.position.y, this.transform.position.z);
        }
        else
        {
            target = realTarget;
        }

        
    }
}
