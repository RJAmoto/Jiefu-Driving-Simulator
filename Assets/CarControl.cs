using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarControl : MonoBehaviour
{
    // NOTE: Companion script for wheel suspensions, attach to each wheel.

    // PUBLIC


    public bool driveable = false;
    public float drive;
    public float steer;
    public float brake;


    // Wheel Wrapping Objects
    public Transform frontLeftWheelWrapper;
    public Transform frontRightWheelWrapper;
    public Transform rearLeftWheelWrapper;
    public Transform rearRightWheelWrapper;

    // Wheel Meshes
    // Front
    public Transform frontLeftWheelMesh;
    public Transform frontRightWheelMesh;
    // Rear
    public Transform rearLeftWheelMesh;
    public Transform rearRightWheelMesh;

    // Wheel Colliders
    // Front
    public WheelCollider wheelFL;
    public WheelCollider wheelFR;
    // Rear
    public WheelCollider wheelRL;
    public WheelCollider wheelRR;

    public float maxTorque = 20f;
    public float brakeTorque = 100f;

    // max wheel turn angle;
    public float maxWheelTurnAngle = 30f; // degrees

    // car's center of mass
    public Vector3 centerOfMass = new Vector3(0f, 0f, 0f); // unchanged

    // GUI
    //...
    public float RO_speed; // READ ONLY (Debug)
    public float RO_EngineTorque; // READ ONLY (Debug)
    public float RO_SteeringAngleFL; // READ ONLY (Debug)
    public float RO_SteeringAngleFR; // READ ONLY (Debug)
    public float RO_BrakeTorque; // READ ONLY (Debug)

    // PRIVATE

    // acceleration increment counter
    private float torquePower = 200f;

    // turn increment counter
    private float steerAngle = 30f;

    // original wheel positions
    // Front Left
    private float wheelMeshWrapperFLx;
    private float wheelMeshWrapperFLy;
    private float wheelMeshWrapperFLz;
    // Front Right
    private float wheelMeshWrapperFRx; 
    private float wheelMeshWrapperFRy;
    private float wheelMeshWrapperFRz;
    // Rear Left
    private float wheelMeshWrapperRLx;
    private float wheelMeshWrapperRLy;
    private float wheelMeshWrapperRLz;
    // Rear Right
    private float wheelMeshWrapperRRx;
    private float wheelMeshWrapperRRy;
    private float wheelMeshWrapperRRz;


    void Start()
    {
        GameObject.Find("CivilianVehicle05").GetComponent<Rigidbody>().centerOfMass = centerOfMass;
    }
    // Setup initial values

    // Front Left
    // wheelMeshWrapperFLx = frontLeftWheelWrapper.localPosition.x;
    // wheelMeshWrapperFLy = frontLeftWheelWrapper.localPosition.y;
    // wheelMeshWrapperFLz = frontLeftWheelWrapper.localPosition.z;
    // Front Right
    // wheelMeshWrapperFRx = frontRightWheelWrapper.localPosition.x;
    // wheelMeshWrapperFRy = frontRightWheelWrapper.localPosition.y;
    // wheelMeshWrapperFRz = frontRightWheelWrapper.localPosition.z;
    // Rear Left
    // wheelMeshWrapperRLx = rearLeftWheelWrapper.localPosition.x;
    // wheelMeshWrapperRLy = rearLeftWheelWrapper.localPosition.y;
    // wheelMeshWrapperRLz = rearLeftWheelWrapper.localPosition.z;
    // Rear Right
    // wheelMeshWrapperRRx = rearRightWheelWrapper.localPosition.x;
    // wheelMeshWrapperRRy = rearRightWheelWrapper.localPosition.y;
    // wheelMeshWrapperRRz = rearRightWheelWrapper.localPosition.z;


    // Visual updates
    void Update()
    {
        if (!driveable)
        {
            return;
        }

        // SETUP WHEEL MESHES

        // Turn the mesh wheels
        frontLeftWheelWrapper.localEulerAngles = new Vector3(0, steerAngle, 0);
        frontRightWheelWrapper.localEulerAngles = new Vector3(0, steerAngle, 0);

        // Wheel rotation
        frontLeftWheelMesh.Rotate(wheelRL.rpm, 0 / 60 * 360 * Time.deltaTime, 0);
        frontRightWheelMesh.Rotate(wheelRL.rpm, 0 / 60 * 360 * Time.deltaTime, 0);
        rearLeftWheelMesh.Rotate(wheelRL.rpm, 0 / 60 * 360 * Time.deltaTime, 0);
        rearRightWheelMesh.Rotate(wheelRL.rpm, 0 / 60 * 360 * Time.deltaTime, 0);

        // Audio
        GetComponent<AudioSource>().pitch = (torquePower / maxTorque) + 0.5f;
    }

    // Physics updates
    void FixedUpdate()
    {
        if (!driveable)
        {
            return;
        }

        // CONTROLS - FORWARD & RearWARD
        if (brake == 1)
        {
            // BRAKE
            torquePower = 0f;
            wheelRL.brakeTorque = brakeTorque;
            wheelRR.brakeTorque = brakeTorque;

            Debug.Log("Brake Works");
        }
        else
        {
            torquePower = maxTorque * drive;
            wheelRL.brakeTorque = 0f;
            wheelRR.brakeTorque = 0f;
            // Apply torque
            wheelRR.motorTorque = torquePower;
            wheelRL.motorTorque = torquePower;

            Debug.Log("Drive value" + drive);
        }

        // CONTROLS - LEFT & RIGHT
        // apply steering to front wheels
        steerAngle = maxWheelTurnAngle * steer;
        wheelFL.steerAngle = steerAngle;
        wheelFR.steerAngle = steerAngle;

        // Debug info
        RO_BrakeTorque = wheelRL.brakeTorque;
        RO_SteeringAngleFL = wheelFL.steerAngle;               
        RO_SteeringAngleFR = wheelFR.steerAngle;
        RO_EngineTorque = torquePower;

        // SPEED
        // debug info
        RO_speed = GameObject.Find("CivilianVehicle05").GetComponent<Rigidbody>().velocity.magnitude;

        // KEYBOARD INPUT

        // FORWARD

    }

    public void Move(float drive, float steer, float brake)
    {
        this.drive = drive;
        this.steer = steer;
        this.brake = brake;
    }

    public void horn()
    {
        FindObjectOfType<AudioManager>().Play("Horn");
    }

    public void StopHorn()
    {
        FindObjectOfType<AudioManager>().Stop("Horn");
    }
}