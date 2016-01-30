using UnityEngine;
using System.Collections;

public class TransformPj : MonoBehaviour {


    
    public GameObject aura;
    public GameObject bear;
    public GameObject squirrel;
    public GameObject wolf;

    GameObject animalInstance;

    bool allowTransform = true;



    public void CambiarForma(int forma)
    {
        switch (forma)
        {
            case 1:
                animalInstance = Instantiate(bear, transform.position, Quaternion.identity) as GameObject;
                break;
            case 2:
                animalInstance = Instantiate(squirrel, transform.position, Quaternion.identity) as GameObject;
                break;
            case 3:
                animalInstance = Instantiate(wolf, transform.position, Quaternion.identity) as GameObject;
                break;
        }
    }

    private void CheckTransformButtons()
    {
        if (Input.GetButton("TransformBear") && allowTransform == true)
        {
            //anim.SetTrigger("Attack");
            Transformar(1);
        }
        else if (Input.GetButton("TransformSquirrel") && allowTransform == true)
        {
            Transformar(2);
        }
        else if (Input.GetButton("TransformWolf") && allowTransform == true)
        {
            Transformar(3);
        }
    }

    void Transformar(int forma)
    {
        this.GetComponent<Salto>().enabled = false;
        this.GetComponent<Rigidbody2D>().isKinematic = true;
        this.GetComponent<BoxCollider2D>().enabled = false;
        CambiarForma(forma);
        // this.GetComponent<PlayerScript>().enabled = false;        
        allowTransform = false;
        Transformacion.estadoMundo = 1;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        CheckTransformButtons();
	    if(Transformacion.estadoMundo == 1)
        {
            aura.SetActive(true);
        }else
        {
            Destroy(animalInstance);
            this.GetComponent<Salto>().enabled = true;
            this.GetComponent<Rigidbody2D>().isKinematic = false;
            this.GetComponent<BoxCollider2D>().enabled = true;
            aura.SetActive(false);

        }
	}
}
