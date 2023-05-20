using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public float futtobiPower;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.2f);
    }

    private void OnTriggerEnter(Collider other)
    {
        // �ՓˑΏۂ�Rigidbody�̔z���ł��邩�𒲂ׂ�
        var rigidBody = other.GetComponentInParent<Rigidbody>();

        // Rigidbody�����ĂȂ��Ȃ琁����΂Ȃ��̏I���
        if (rigidBody == null) return;

        // �����ɂ���Ĕ����������琁����ԕ����̃x�N�g�������
        var direction = (other.transform.position - transform.position).normalized;

        // ������΂�
        // ForceMode��ς���Ƌ������ς��i����͎��ʖ����j
        rigidBody.AddForce(direction * futtobiPower, ForceMode.VelocityChange);
    }
}
