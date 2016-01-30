using UnityEngine;
using System.Collections;

public class TransformPj : MonoBehaviour {


    public GameObject bear;

    public void CambiarForma(int forma)
    {
        switch (forma)
        {
            case 1:
                Instantiate(bear, this.transform.position, this.transform.rotation);
                //gameObject.GetComponent<PlayerScript>().enabled = false;
                break;
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
