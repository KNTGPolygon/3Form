using UnityEngine;
using System.Collections;

public class KeyboardAndMouseController : Controller {
	
	protected override void processMove ()
	{
		float xAxis = Input.GetAxis("Horizontal");
		float zAxis = Input.GetAxis ("Vertical");
		Vector3 direction = new Vector3(xAxis,0,zAxis).normalized;
		player.setDesiredMoveDirection (direction);
	}
	protected override void processTurn ()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      	RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 100)) {
			Vector3 relativePos = hit.point - player.transform.position;
			player.setDesiredRotation (Quaternion.LookRotation(relativePos));
		}
	}
}
