using UnityEngine;
using System.Collections;

public class simpleBot : Bot
{

	// Use this for initialization
	new void Start ()
	{	
		model=gameObject.rigidbody;
	}
	
	// Update is called once per frame
	new void Update ()
	{	
	}
	
	
	#region implemented abstract members of Bot
	protected override void behave ()
	{
		throw new System.NotImplementedException ();
	}
	#endregion
}
