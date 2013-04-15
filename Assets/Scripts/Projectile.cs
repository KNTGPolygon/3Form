using UnityEngine;
using System.Collections;

abstract public class Projectile : MonoBehaviour {
	
	float lifeSpan = 5;
	
	protected virtual void Start() {
		Destroy (gameObject,lifeSpan);
	}
	
	protected abstract void OnCollisionEnter();
	
}
