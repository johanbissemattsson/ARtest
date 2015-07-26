using UnityEngine;
using System.Collections;

public class ActivateGyroDroid : MonoBehaviour
{
	public SwitchableSensorCamera arCam;
	
	void OnTrackingFound() {
		arCam.enabled = false;
	}
	
	void OnTrackingLost() {
		arCam.enabled = true;
	}
}