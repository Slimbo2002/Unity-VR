using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PatternGame : MonoBehaviour
{
    [SerializeField]
    GameObject buttonOne, buttonTwo, buttonThree, moderator;
    public GameObject accolade;

    public Material start;
    public Material green;
    public Material red;

    public TMP_Text text;

    string setSequence = "321";
    public string sequence;

    void Start()
    {

    }
    void Update()
    {
        text.text = sequence;
        if (sequence.Length == 3 && sequence != setSequence)
        {
            //DisplayColour(red);
            sequence = "";
        }
        else if (sequence == setSequence)
        {
            moderator.GetComponent<MeshRenderer>().material = green;
            accolade.SetActive(true);
        }
    }
    public void AddToString(string value)
    {
        
        sequence += value;
    }
    IEnumerator DisplayColour(Material colour)
    {
        moderator.GetComponent<MeshRenderer>().material = colour;
        yield return new WaitForSeconds(2);
        moderator.GetComponent<MeshRenderer>().material = start;
    }

}
