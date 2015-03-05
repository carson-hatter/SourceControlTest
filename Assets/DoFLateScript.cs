using UnityEngine;
using UnityStandardAssets.ImageEffects;

using System.Collections;

public class DoFLateScript : MonoBehaviour {

	private DepthOfField dof;

	// Use this for initialization
	void Start () {
		dof = GetComponent < DepthOfField> ();
	}
	
	// Update is called once per frame
	void LateUpdate () {
		RaycastHit hit;
		Ray downRay = new Ray(transform.position, -Vector3.up);
		if (Physics.Raycast(downRay, out hit)) {
			dof.focalLength = (hit.distance > 100) ? 100 : hit.distance;
		}
	}
}
