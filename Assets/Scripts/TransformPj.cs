using UnityEngine;
using System.Collections;

public class TransformPj : MonoBehaviour {


    
    public GameObject aura;

    //public void CambiarForma(int forma)
    //{
    //    switch (forma)
    //    {
    //        case 1:
    //            Instantiate(bear, this.transform.position, this.transform.rotation);
    //            bearInstance.transform.position = this.transform.position;
    //            //gameObject.GetComponent<PlayerScript>().enabled = false;
    //            break;
    //    }
    //}

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Transformacion.estadoMundo == 1)
        {
            aura.SetActive(true);
        }else
        {
            aura.SetActive(false);
        }
	}
}
