using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccoladeCollect : MonoBehaviour
{

    Accolades collect;

    // Update is called once per frame
    void Update()
    {
        collect = this.GetComponent<Accolades>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "accoladeOne")
        {
            collect.collect1 = true;
        }
    }
    
}
