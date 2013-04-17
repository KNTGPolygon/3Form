using UnityEngine;
using System.Collections;

public class Player : Pawn
{
	public float upperBodyTurnRate = 20;
	
	Quaternion desiredRotation = Quaternion.identity;
	
	public void setDesiredRotation (Quaternion rotation)
	{ 
		desiredRotation = rotation;
	}
	
	protected override void Start ()
	{
		base.Start ();
	}
	
	protected override void FixedUpdate ()
	{
		base.FixedUpdate ();
		ProcessUpperBodyRotation ();
	}

	void ProcessUpperBodyRotation ()
	{
		Transform upperBodyTransform = transform.GetChild (0).transform;
		upperBodyTransform.rotation = Quaternion.Slerp (upperBodyTransform.rotation, desiredRotation, Time.deltaTime * upperBodyTurnRate);
	}
	
}
