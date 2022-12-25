using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject patternGame;
    public string value;

    public Material green;
    public Material yellow;

    PatternGame game;


    void Start()
    {
        game = patternGame.GetComponent<PatternGame>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "hand")
        {
            game.AddToString(value);
            //StartCoroutine(PressButton());
        }
    }
    public IEnumerator PressButton()
    {
        this.GetComponent<MeshRenderer>().material = green;
        yield return new WaitForSeconds(1);
        this.GetComponent<MeshRenderer>().material = yellow;
    }

}
