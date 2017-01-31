using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunFire : MonoBehaviour
{
	private AudioSource				son;

	void Start ()
	{
		son = this.GetComponent<AudioSource>();
	}
	
	void Update ()
	{
		if (Input.GetButton("Fire1"))
		{
			son.Play();
			GetComponent<Animation>().Play("gunShot");
		}	
	}
}
