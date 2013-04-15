using UnityEngine;
using System.Collections;

public class XPadController : Controller {
	bool isFire1Pushed = false;
	bool isFire2Pushed = false;
	
	protected override void processMove ()
	{
		float xAxis = Input.GetAxis("Horizontal");
		float zAxis = Input.GetAxis ("Vertical");
		Vector3 direction = new Vector3(xAxis,0,zAxis).normalized;
		player.setDesiredMoveDirection (direction);
	}
	
	protected override void processTurn ()
	{
		Vector3 direction = new Vector3(Input.GetAxis ("LookX"),0,Input.GetAxis ("LookY"));
		if (direction.magnitude != 0)
			player.setDesiredRotation (Quaternion.LookRotation(direction.normalized));
	}
	
	protected override void processFire ()
	{
		if (Input.GetAxis ("Fire1") > 0.5) {
			if (!isFire1Pushed) {
				player.weapons[1].pushTrigger ();
				isFire1Pushed = true;
			}
		}
		else isFire1Pushed = false;
		
		if (Input.GetAxis ("Fire2") > 0.5) {
			if (!isFire2Pushed) {
				player.weapons[0].pushTrigger ();
				isFire2Pushed = true;
			}
		}
		else isFire2Pushed = false;
	}
}
