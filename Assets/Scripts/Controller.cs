using UnityEngine;
using System.Collections;

abstract public class Controller : MonoBehaviour {
	
	public Player player;
	
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		processMove ();
		processTurn ();
	}	

	abstract protected void processMove();
	abstract protected void processTurn();
}
