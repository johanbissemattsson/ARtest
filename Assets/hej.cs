using UnityEngine;
using System.Collections;

public class hej : MonoBehaviour {

	public GameObject Target;
	public GameObject Gubbe;
	public GameObject Pil;
	public Camera ARcamera;
	public GameObject Boll1;
	public GameObject Boll2;
	public Vector3 dir;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		Pil.transform.rotation = Quaternion.identity;
		Gubbe.transform.position = transform.TransformPoint(ARcamera.transform.InverseTransformPoint (Target.transform.position));
		Gubbe.transform.rotation = transform.rotation * Quaternion.Inverse(ARcamera.transform.rotation) * Target.transform.rotation;
		//Physics.gravity = Quaternion.Inverse(SensorHelper.rotation) * Vector3.down * 9.82f;
		Vector3 dir = (Boll1.transform.position - Boll2.transform.position).normalized;
		//Physics.gravity = Quaternion.Inverse(Pil.transform.localRotation) * Vector3.down * 9.82f;
		Physics.gravity = dir * 9.82f;

	}
}
