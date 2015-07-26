using UnityEngine;
using System.Collections;

public class SwitchableSensorCamera : MonoBehaviour
{
	private Quaternion initialCameraRotation = Quaternion.identity;
	private Quaternion sensorFix;
	
	void Start () {  
		initialCameraRotation = Quaternion.identity;
		
		SensorHelper.ActivateRotation();
	}
	
	void Update () {
		
		sensorFix =  new Quaternion( SensorHelper.rotation.x,SensorHelper.rotation.y, -SensorHelper.rotation.z, -SensorHelper.rotation.w);
		
		transform.rotation = initialCameraRotation * sensorFix;
		
		
	}
	void OnEnable() {
		
		sensorFix =  new Quaternion( SensorHelper.rotation.x,SensorHelper.rotation.y, -SensorHelper.rotation.z, -SensorHelper.rotation.w);
		
		initialCameraRotation = transform.rotation * Quaternion.Inverse(sensorFix);
		
	}
}