using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Accolades : MonoBehaviour
{
    [SerializeField]
    GameObject accoladeOne, accoladeTwo, accoladeThree, usb, timerText, winText, loseText;

    [SerializeField]
    TMP_Text timer;

    [SerializeField]
    GameObject displayOne, displayTwo, displayThree, puzzleOne;

    public Material green;
    public bool collect1;

    public bool collect2;

    public bool collect3;

    Timer timerScript;

    void Start()
    {
        timerScript = timer.GetComponent<Timer>();

    }

    // Update is called once per frame
    void Update()
    {
         if (collect1&& collect2 && collect3)
         {
            Win();
         } 
         else if (timerScript.timerDone)
         {
            SceneManager.LoadScene("SampleScene");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "accoladeOne")
        {
            collect1 = true;
            displayOne.GetComponent<MeshRenderer>().material = green;
            Destroy(accoladeOne);
        }
        else if (other.tag == "accoladeTwo")
        {
            collect2 = true;
            displayTwo.GetComponent<MeshRenderer>().material = green;
            Destroy(accoladeTwo);
        }
        else if (other.tag == "accoladeThree")
        {
            collect3 = true;
            displayThree.GetComponent<MeshRenderer>().material = green;
            Destroy(accoladeThree);
        }
        else if (other.tag == "hand")
        {

            TurnOnScreen();
        }
    }
    public void TurnOnScreen()
    {
        displayOne.SetActive(true);
        displayTwo.SetActive(true);
        displayThree.SetActive(true);
       
        timerScript.timerOn = true;

        puzzleOne.SetActive(true);
    }
    void Win()
    {
        timerScript.timerOn = false;
    }
    void Lose()
    {
        LoseRun();
    }
    IEnumerator LoseRun()
    {
        loseText.SetActive(true);
        timerText.SetActive(false);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("SampleScene");
    }

}
