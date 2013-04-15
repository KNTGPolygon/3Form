using UnityEngine;
using System.Collections;

public class simpleWeapon : Weapon {

	public override void pushTrigger ()
	{
		fire ();
	}
	
	public override void releaseTrigger ()
	{
	}
	
	protected override void fire ()
	{
	    Projectile m = (Projectile) Instantiate (projectile, projectileSpawnLocation.transform.position, transform.rotation);
	    m.rigidbody.velocity = transform.TransformDirection(Vector3.forward * 30);
	}
}
