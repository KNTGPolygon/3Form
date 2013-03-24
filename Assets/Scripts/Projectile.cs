using UnityEngine;
using System.Collections;

abstract public class Projectile : MonoBehaviour {
	
	public Weapon weapon;
	protected double mass;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	protected abstract void OnCollisionEnter();
	
}
