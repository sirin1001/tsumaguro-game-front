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
        // 衝突対象がRigidbodyの配下であるかを調べる
        var rigidBody = other.GetComponentInParent<Rigidbody>();

        // Rigidbodyがついてないなら吹っ飛ばないの終わり
        if (rigidBody == null) return;

        // 爆風によって爆発中央から吹き飛ぶ方向のベクトルを作る
        var direction = (other.transform.position - transform.position).normalized;

        // 吹っ飛ばす
        // ForceModeを変えると挙動が変わる（今回は質量無視）
        rigidBody.AddForce(direction * futtobiPower, ForceMode.VelocityChange);
    }
}
