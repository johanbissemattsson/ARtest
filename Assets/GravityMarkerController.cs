using UnityEngine;
using System.Collections;

public class GravityMarkerController : MonoBehaviour {

	private Quaternion TestDirection;
	private Vector3 TestDirectionDown;
	private Transform targetPosition;
	
	private float force = 9.81f;
	
	// Use this for initialization
	void Start () {
		//SensorHelper.ActivateRotation();
	}
	
	// Update is called once per frame
	void Update () {
		//TestDirection = SensorHelper.rotation;
		//TestDirectionDown = TestDirection * Vector3.down;
		this.transform.rotation = Quaternion.Inverse(SensorHelper.rotation);
		Physics.gravity = SensorHelper.rotation * Vector3.down * force;



		//this.gameObject.transform.localRotation = TestDirection;
		//this.gameObject.transform.localRotation = Quaternion.Inverse(SensorHelper.rotation);
		// Bra kodPhysics.gravity = transform.InverseTransformDirection (SensorHelper.rotation * Vector3.down) * force;
		//		Physics.gravity = transform.TransformDirection (Quaternion.Inverse(SensorHelper.rotation) * Vector3.down) * force;

	}
}