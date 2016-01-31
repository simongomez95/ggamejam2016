using UnityEngine;
using System.Collections;

public class TransformPj : MonoBehaviour {


    
    public GameObject aura;
    public GameObject bear;
    public GameObject squirrel;
    public GameObject wolf;

    GameObject animalInstance = null;
    GameObject newAnimalInstance = null;

    bool allowTransform = true;


    IEnumerator esperar()
    {
        yield return new WaitForSeconds(1f);
        allowTransform = true;
    }

    public void CambiarForma(int forma)
    {
        switch (forma)
        {
            case 1:
                if (animalInstance == null)
                {
                    animalInstance = Instantiate(bear, transform.position, Quaternion.identity) as GameObject;
                }
                else
                {
                    newAnimalInstance = Instantiate(bear, animalInstance.transform.position, Quaternion.identity) as GameObject;
                    Destroy(animalInstance);
                    animalInstance = newAnimalInstance;
                    //Destroy(newAnimalInstance);
                    //newAnimalInstance = null;
                }
                break;
            case 2:
                if (animalInstance == null)
                {
                    animalInstance = Instantiate(squirrel, transform.position, Quaternion.identity) as GameObject;
                }
                else
                {
                    newAnimalInstance = Instantiate(squirrel, animalInstance.transform.position, Quaternion.identity) as GameObject;
                    Destroy(animalInstance);
                    animalInstance = newAnimalInstance;
                    //Destroy(newAnimalInstance);
                    //newAnimalInstance = null;
                }
                break;
            case 3:
                if (animalInstance == null)
                {
                    animalInstance = Instantiate(wolf, transform.position, Quaternion.identity) as GameObject;
                }
                else
                {
                    newAnimalInstance = Instantiate(wolf, animalInstance.transform.position, Quaternion.identity) as GameObject;
                    Destroy(animalInstance);
                    animalInstance = newAnimalInstance;
                    //Destroy(newAnimalInstance);
                    //newAnimalInstance = null;
                }
                break;
        }
    }

    private void CheckTransformButtons()
    {
        if (Input.GetButton("TransformBear") && allowTransform == true)
        {
            //anim.SetTrigger("Attack");
            Transformar(1);
            Debug.Log("Boton");
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
        this.GetComponent<Salto2>().enabled = false;
        this.GetComponent<Rigidbody2D>().isKinematic = true;
        this.GetComponent<BoxCollider2D>().enabled = false;
        CambiarForma(forma);
        CamaraSencilla.target = animalInstance.transform;
        // this.GetComponent<PlayerScript>().enabled = false;        
        allowTransform = false;
        StartCoroutine(esperar());
        Transformacion.estadoMundo = 1;
    }

    // Use this for initialization
    void Start () {
        Debug.Log("ENTRA");
	
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
            
            this.GetComponent<Salto2>().enabled = true;
            this.GetComponent<Rigidbody2D>().isKinematic = false;
            this.GetComponent<BoxCollider2D>().enabled = true;
            aura.SetActive(false);
            allowTransform = true;

        }
	}
}
