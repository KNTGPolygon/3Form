using UnityEngine;
using System.Collections;

public class Player : Pawn {
	
	Vector3 desiredMoveDirection = new Vector3(0,0);
	public float maxSpeed = 10;
	public float timeToMaxSpeed = 3;
	private float accelerationRate;
	//public float directionToForceRatio = 10;
	
	protected override void Start ()
	{
		base.Start ();
		accelerationRate = maxSpeed/timeToMaxSpeed + collider.material.dynamicFriction*Physics.gravity.magnitude*2;
	}
	
	
	public void setDesiredMoveDirection(Vector3 direction) { 
		//TODO: implement proper inertia movement
		desiredMoveDirection = direction;
	}
	
	public void setDesiredRotation(Quaternion rotation) { 
		//TODO: implement proper inertia movement
	}
	
	void FixedUpdate() {
		float acceleration;
		if (rigidbody.velocity.magnitude > maxSpeed) acceleration = 0;
		else acceleration = this.accelerationRate;
		rigidbody.AddForce(desiredMoveDirection*acceleration, ForceMode.Acceleration);
		//float force = enginePower / rigidbody.velocity.magnitude;
		//rigidbody.AddForce(desiredMoveDirection*force, ForceMode.Force);
		print(rigidbody.velocity);
	}
}
