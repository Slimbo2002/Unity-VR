using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accolades : MonoBehaviour
{
    [SerializeField]
    GameObject accoladeOne, accoladeTwo, accoladeThree, usb;
    

    public bool collect1;

    public bool collect2;

    public bool collect3;

    USB usbScript;

    void Start()
    {
        usbScript = usb.GetComponent<USB>();
    }

    // Update is called once per frame
    void Update()
    {
         if (collect1&& collect2 && collect3)
         {
            Debug.Log("Win");
         } 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "accoladeOne")
        {
            collect1 = true;
            Destroy(accoladeOne);
        }
        else if (other.tag == "accoladeTwo")
        {
            collect2 = true;
            Destroy(accoladeTwo);
        }
        else if (other.tag == "accoladeThree")
        {
            collect3 = true;
            Destroy(accoladeThree);
        }
        else if (other.tag == "USB")
        {
            usbScript.TurnOnScreen();
        }
    }

}
