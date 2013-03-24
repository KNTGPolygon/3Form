using UnityEngine;
using System.Collections;

abstract public class Bot : Pawn {
	
	public Pawn target;
	
	// Use this for initialization
	new void Start () {
	}
	
	// Update is called once per frame
	new void Update () {
	}
	
	abstract protected void behave();
}
