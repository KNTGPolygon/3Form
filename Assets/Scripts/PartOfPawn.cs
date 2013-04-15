using UnityEngine;
using System.Collections;

public class PartOfPawn : MonoBehaviour {
	
	public Pawn playerOrBot;
	
	void OnCollisionEnter (Collision collision) {
		playerOrBot.OnCollisionEnter(collision);
	}			
}
