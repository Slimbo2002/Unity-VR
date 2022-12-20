using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    public Monitor monitor;
    public Material black;

    bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {
        monitor = monitor.GetComponent<Monitor>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cable")
        {
            monitor.SetMaterial();

        }
    }
}
