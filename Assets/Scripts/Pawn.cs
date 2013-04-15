using UnityEngine;
using System.Collections;

abstract public class Pawn : MonoBehaviour
{
	public float maxSpeed = 10;
	public float timeToMaxSpeed = 3;
	public Weapon[] weapons;
	public ParticleSystem collisionParticleSystem;
	protected float hp = 100;
	protected float armor = 0;
	Vector3 desiredMoveDirection = Vector3.zero;
	float accelerationRate;
	
	public void takeDamage (float damage)
	{
		damage -= armor;
		if (damage > 0)
			hp -= damage;	
	}
	
	public void setDesiredMoveDirection (Vector3 direction)
	{ 
		desiredMoveDirection = direction;
	}
		
	public virtual void OnCollisionEnter (Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts) {
			collisionParticleSystem.transform.position = contact.point;
			collisionParticleSystem.Play ();
		}
		//TODO: implement proper collision, this is bullcrap
		//collision damage! takeDamage()
	}
	
	protected virtual void Start ()
	{
		accelerationRate = maxSpeed / timeToMaxSpeed + collider.material.dynamicFriction * Physics.gravity.magnitude * 2;
	}
	
	protected virtual void Update ()
	{
	}
	
	protected virtual void FixedUpdate ()
	{
		ProcessMove ();
	}
		
	void ProcessMove ()
	{
		float acceleration;
		if (rigidbody.velocity.magnitude > maxSpeed)
			acceleration = 0;
		else
			acceleration = this.accelerationRate;
		rigidbody.AddForce (desiredMoveDirection * acceleration, ForceMode.Acceleration);
	}
}
