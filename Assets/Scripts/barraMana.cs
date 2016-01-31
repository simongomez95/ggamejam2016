using UnityEngine;
using System.Collections;

public class barraMana : Transformacion {


	public float maxHealth = 10;
	public float curHealth = 10;

	public Texture2D bgImage; 
	public Texture2D fgImage; 

	public float healthBarLength;

	public Transformacion pasoMundo;
	double tiempoTrans = 10; 

	// Use this for initialization
	void Start () {   
		healthBarLength = Screen.width /3;    
	}

	// Update is called once per frame
	void Update () {
		if (Transformacion.estadoMundo == 1) {
			tiempoTrans = tiempoTrans - Time.deltaTime;
			AddjustCurrentHealth(tiempoTrans);
		}
	}

	void OnGUI () {
		// Create one Group to contain both images
		// Adjust the first 2 coordinates to place it somewhere else on-screen
		GUI.BeginGroup (new Rect (0,0, healthBarLength,32));

		// Draw the background image
		GUI.Box (new Rect (0,0, healthBarLength,32), bgImage);

		// Create a second Group which will be clipped
		// We want to clip the image and not scale it, which is why we need the second Group
		GUI.BeginGroup (new Rect (0,0, curHealth / maxHealth * healthBarLength, 32));

		// Draw the foreground image
		GUI.Box (new Rect (0,0,healthBarLength,32), fgImage);

		// End both Groups
		GUI.EndGroup ();

		GUI.EndGroup ();
	}

	public void AddjustCurrentHealth(double adj){

		curHealth += (float)adj;

		if(curHealth <0)
			curHealth = 0;

		if(curHealth > maxHealth)
			curHealth = maxHealth;

		if(maxHealth <1)
			maxHealth = 1;

		healthBarLength =(Screen.width /3) * (curHealth / maxHealth);
	}
}
