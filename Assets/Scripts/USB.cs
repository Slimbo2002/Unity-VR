using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class USB : MonoBehaviour
{
    [SerializeField]
    TMP_Text timer;

    [SerializeField]
    GameObject shapes;

    Timer timerScript;
    void Start()
    {
        timerScript = timer.GetComponent<Timer>();
    }

    // Start is called before the first frame update
    public void TurnOnScreen()
    {
        timerScript.timerOn = true;
    }
}
