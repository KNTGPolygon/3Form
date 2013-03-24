using UnityEngine;
using System.Collections;

abstract public class Pawn : MonoBehaviour {
	
	protected double mass = 300;
	protected double hp = 100;
	
	// Use this for initialization
	protected void Start () {}	
	
	// Update is called once per frame
	protected void Update () {}
	
	public void takeDamage(float damage) {
		hp -= damage; }
	
	protected virtual void OnCollisionEnter(Collision collision) {
		//TODO: implement proper collision, this is bullcrap
        foreach (ContactPoint contact in collision.contacts) {
            Debug.DrawRay(contact.point, contact.normal, Color.white); }
		print(collision.impactForceSum); }
}
