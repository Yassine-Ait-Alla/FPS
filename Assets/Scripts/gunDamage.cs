using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunDamage : MonoBehaviour
{
	public int				damage = 5;
	public float			targetDistance;
	public float			AllowedRange = 15;

	void Start ()
	{
		
	}
	
	void Update ()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			RaycastHit		shot;
			if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
			{
				targetDistance = shot.distance;
				if (targetDistance < AllowedRange)
				{
					shot.transform.SendMessage("DeductPoints", damage);
				}
			}
		}	
	}
}
