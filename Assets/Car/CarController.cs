using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public List<AxleInfo> axleInfos; // �X�̎Ԏ��̏��
    public float maxMotorTorque; //�z�C�[���ɓK�p�\�ȍő�g���N
    public float brakeTorque;
    public float maxSteeringAngle; // �K�p�\�ȍő�n���h���p�x

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
    public bool motor; //���̃z�C�[�����G���W���ɃA�^�b�`����Ă��邩�ǂ���
    public bool steering; // ���̃z�C�[�����n���h���̊p�x�𔽉f���Ă��邩�ǂ���
    public bool brake;
}