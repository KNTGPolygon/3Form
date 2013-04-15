using UnityEngine;
using System.Collections;

abstract public class Controller : MonoBehaviour {
	
	public Player player;
	
	void Start () {}
	
	void Update () {
		processFire ();
		processMove ();
		processTurn ();
	}	

	abstract protected void processMove();
	abstract protected void processTurn();
	abstract protected void processFire();
}
