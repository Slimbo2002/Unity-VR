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

    public string code = "123";
    public string input;

    private void Start()
    {
        buttonOne.GetComponent<Button>().PressButton.AddListener(ButtonOne);
    }

    void Update()
    {
        if (code == input)
        {
            Debug.Log("Win");
        }
    }

    void ButtonOne()
    {
        input = input + "1";
    }


}
