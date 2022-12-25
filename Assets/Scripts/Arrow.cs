using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField]
    GameObject nextArrow, arrow;

    public bool isActive;

    Arrow arr;

    void Start()
    {
        arr = nextArrow.GetComponent<Arrow>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "hands")
        {
            nextArrow.SetActive(true);
        }
    }
}
