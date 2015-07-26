using UnityEngine;
using System.Collections;

public class Blaaaa : MonoBehaviour
{
	private Quaternion initialCameraRotation = Quaternion.identity;
	
	void Start () {    
		initialCameraRotation = Quaternion.identity;
		
		SensorHelper.ActivateRotation();
	}
	
	void Update () {
		transform.rotation = initialCameraRotation * SensorHelper.rotation;
	}
	
	void OnEnable() {
		initialCameraRotation = transform.rotation * Quaternion.Inverse(SensorHelper.rotation);
	}
}