using UnityEngine;
using System.Collections;

abstract public class Weapon : MonoBehaviour {
	
	public Projectile projectile;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public abstract void pushTrigger();
	public abstract void releaseTrigger();
	protected abstract void fire();
}
