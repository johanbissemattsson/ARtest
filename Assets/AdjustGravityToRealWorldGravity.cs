using UnityEngine;
using System.Collections;

public class AdjustGravityToRealWorldGravity : MonoBehaviour {

	public GameObject Target;
	public GameObject Gubbe;
	public GameObject GravityPointer;
	public Camera AugmentedRealityCamera;
	public GameObject ClosestGravityPointerMarker;
	public GameObject FarthestGravityPointerMarker;
	public Vector3 dir;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		GravityPointer.transform.rotation = Quaternion.identity;
		Gubbe.transform.position = transform.TransformPoint(AugmentedRealityCamera.transform.InverseTransformPoint (Target.transform.position));
		Gubbe.transform.rotation = transform.rotation * Quaternion.Inverse(AugmentedRealityCamera.transform.rotation) * Target.transform.rotation;
		//Physics.gravity = Quaternion.Inverse(SensorHelper.rotation) * Vector3.down * 9.82f;
		Vector3 dir = (ClosestGravityPointerMarker.transform.position - FarthestGravityPointerMarker.transform.position).normalized;
		//Physics.gravity = Quaternion.Inverse(Pil.transform.localRotation) * Vector3.down * 9.82f;
		Physics.gravity = dir * 9.82f;
		
	}
}