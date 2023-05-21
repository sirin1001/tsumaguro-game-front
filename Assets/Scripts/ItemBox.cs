using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemBox : MonoBehaviour
{
    [SerializeField] List<GameObject> items = new List<GameObject>();
    TextMeshProUGUI DisplayItem;

    private void Start()
    {
        DisplayItem = GameObject.Find("Item").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        transform.Rotate(0f, 0f, 100f * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        GetItem();
        UsedItemBox();
    }

    void GetItem()
    {
        var ItemNuber = Random.Range(0, items.Count);
        DisplayItem.text = "(" + ItemNuber + ")";
    }

    void UsedItemBox()
    {
        var Pos = transform.position;
        Pos.y = -100f;
        transform.position = Pos;
        Invoke("returnPos",3f);
    }

    void returnPos()
    {
        var Pos = transform.position;
        Pos.y = 1f;
        transform.position = Pos;
    }
}
