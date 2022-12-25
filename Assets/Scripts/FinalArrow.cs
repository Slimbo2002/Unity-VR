using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalArrow : MonoBehaviour
{
    [SerializeField]
    GameObject accolade, previousArrow, arrow;

    public bool isActive;

    Arrow preArrow;

    void Start()
    {
        preArrow = previousArrow.GetComponent<Arrow>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "hand" && preArrow.isActive == true)
        {
            isActive = true;
            arrow.SetActive(true);
            accolade.SetActive(true);
        }
    }

}
