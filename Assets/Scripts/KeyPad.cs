using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : MonoBehaviour
{
    public GameObject buttonOne;
    public GameObject buttonTwo;
    public GameObject buttonThree;
    public GameObject buttonFour;
    public GameObject buttonFive;
    public GameObject buttonSix;
    public GameObject buttonSeven;
    public GameObject buttonEight;
    public GameObject buttonNine;

    Button button;

    public string code = "123";
    public string input = "123";

    private void Start()
    {
        button.GetComponent<Button>();
    }

    void Update()
    {
        if (code == input)
        {
            Debug.Log("Win");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == buttonOne)
        {
            button.ButtonClicked("1");
        }
    }


}
