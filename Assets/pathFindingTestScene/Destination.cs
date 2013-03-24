using UnityEngine;
using System.Collections;

public class Destination : MonoBehaviour {
	
	public GameObject target;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<NavMeshAgent>().destination = target.transform.position;
	}
	
//	 IEnumerator Do() {
//        while (true) {
//			GetComponent<NavMeshAgent>().destination = target.transform.position;
//        	yield return new WaitForSeconds(2);
//        	print("Do 2 seconds later");
//		}
//    }
}
