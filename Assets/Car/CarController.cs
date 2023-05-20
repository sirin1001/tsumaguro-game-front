using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public List<AxleInfo> axleInfos; // 個々の車軸の情報
    public float maxMotorTorque; //ホイールに適用可能な最大トルク
    public float brakeTorque;
    public float maxSteeringAngle; // 適用可能な最大ハンドル角度

    public float speed, turn;

    public void FixedUpdate()
    {
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {

        }

        foreach (AxleInfo axleInfo in axleInfos)
        {
            if (axleInfo.steering)
            {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            if (axleInfo.motor)
            {
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;
            }
            if (axleInfo.brake)
            {
                axleInfo.leftWheel.brakeTorque = brakeTorque;
                axleInfo.rightWheel.brakeTorque = brakeTorque;
            }
        }
    }
}

[System.Serializable]
public class AxleInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor; //このホイールがエンジンにアタッチされているかどうか
    public bool steering; // このホイールがハンドルの角度を反映しているかどうか
    public bool brake;
}
