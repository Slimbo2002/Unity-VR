using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor : MonoBehaviour
{
    public Material material;
    public Material black;

    void SetMaterial()
    {
        this.GetComponent<MeshRenderer>().material = black;
    }
}
