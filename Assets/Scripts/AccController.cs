using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AccController : MonoBehaviour {

	//private float GyroRotationVector;		// Sensor.Activate(Sensor.Type.RotationVector);
	private double _lastCompassUpdateTime = 0;
	private Quaternion _correction = Quaternion.identity;
	private Quaternion _targetCorrection = Quaternion.identity;
	private Quaternion _compassOrientation = Quaternion.identity;
	
	
	
	private float GravityDirX;
	private float GravityDirY;
	private float GravityDirZ;

	private float AccX;
	private float AccY;
	private float AccZ;
	private float ARCameraX;
	private float ARCameraY;
	private float ARCameraZ;

	private float temp;

	private float force = 9.81f;
	private float movementScale = 1;
	private float GravityVector;
	private Quaternion GravityDirection;
	private Quaternion rotationQuaternion;

	public Text debugText;
	public GameObject cameraObject;

	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
		Input.compass.enabled = true;

		SensorHelper.ActivateRotation();

		// Sensor.Activate(Sensor.Type.RotationVector);

		//Sensor.Activate (Sensor.Type.RotationVector);
		DisplayDebugText ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		
		GravityDirX = SensorHelper.rotation.x;
		GravityDirY = SensorHelper.rotation.y;
		GravityDirZ = SensorHelper.rotation.z;
		GravityDirection = SensorHelper.rotation;

		//Physics.gravity = Camera.main.transform.TransformDirection(Vector3.down) * force;
		//Physics.gravity =  GravityDirection * Vector3.down * force;

		DisplayDebugText ();


		//		this.gameObject.transform.rotation = SensorHelper.rotation;
		//rotationQuaternion = 
		
		/*Quaternion gyroOrientation = Quaternion.Euler (90, 0, 0) * Input.gyro.attitude * Quaternion.Euler(0, 0, 90);
		if (Input.compass.timestamp > _lastCompassUpdateTime)
		{
			_lastCompassUpdateTime = Input.compass.timestamp;
			
			// Work out an orientation based primarily on the compass
			Vector3 gravity = Input.gyro.gravity.normalized;
			Vector3 flatNorth = Input.compass.rawVector -
				Vector3.Dot(gravity, Input.compass.rawVector) * gravity;
			_compassOrientation = Quaternion.Euler (180, 0, 0) * Quaternion.Inverse(Quaternion.LookRotation(flatNorth, -gravity)) * Quaternion.Euler (0, 0, 90);
			
			// Calculate the target correction factor
			_targetCorrection = _compassOrientation * Quaternion.Inverse(gyroOrientation);
		}
		
		// Jump straight to the target correction if it's a long way; otherwise, slerp towards it very slowly
		if (Quaternion.Angle(_correction, _targetCorrection) > 45)
			_correction = _targetCorrection;
		else
			_correction = Quaternion.Slerp(_correction, _targetCorrection, 0.02f);
		
		// Easy bit :)
		GravityDirection = _correction * gyroOrientation;
		*/

		//Physics.gravity = new Vector3(GyroPosX, GyroPosY * force, GyroPosZ);

		//Vector3 GyroPos = transform.position;
		//GravityVector = Vector3.Dot (Input.gyro.gravity, Vector3.down) ;
		//Physics.gravity = -(Input.acceleration.normalized);
		//GravityVector = GyroPos.y;

		/*
		Vector3 accDir = Vector3.zero;
		accDir.x = -Input.acceleration.x;
		accDir.y = Input.acceleration.y;
		accDir.z = Input.acceleration.z;
		
		if (accDir.sqrMagnitude > 1) {
			accDir.Normalize ();
		}

		AccX = accDir.x;
		AccY = accDir.y; //AccY = accDir.y * force;
		AccZ = accDir.z;

		Vector3 ARCameraDir = Vector3.zero;
		ARCameraDir.x = this.gameObject.GetComponent<RectTransform>().transform.rotation.eulerAngles.x;
		ARCameraDir.y = this.gameObject.GetComponent<RectTransform>().transform.rotation.eulerAngles.y;
		ARCameraDir.z = this.gameObject.GetComponent<RectTransform>().transform.rotation.eulerAngles.z;

		ARCameraX = ARCameraDir.x;
		ARCameraY = ARCameraDir.y;
		ARCameraZ = ARCameraDir.z;
		 */




		//Physics.gravity = -(Input.acceleration.normalized);

	}

	void DisplayDebugText ()
	{
		debugText.text = 
			"rotationQuaternion: " + rotationQuaternion.ToString()
			+ "\nGravityDirX: " + GravityDirX.ToString ()
			+ "\nGravityDirY: " + GravityDirY.ToString ()
			+ "\nGravityDirZ: " + GravityDirZ.ToString ()
			+ "\nARCameraX: " + ARCameraX.ToString ()
			+ "\nARCameraY: " + ARCameraY.ToString ()
			+ "\nARCameraZ: " + ARCameraZ.ToString ()
			+ "\nGravityVector: " + GravityVector.ToString ();
	}
}
