using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextMan : MonoBehaviour {
    public Text question;
    private int counter;
    public GameObject cop;
    public GameObject button;
    public GameObject evidence;
    public GameObject hiddenObjGame;

    // Use this for initialization
    void Start () {
        question.text = "So, you drive a truck for a living, James?";
	}

    public void countUp()
    {
        counter++;
    }
	
	// Update is called once per frame
	void Update () {
        if (counter == 1)
        {
            question.text = "Sure, but you haven't answered my question, James.";
        }

        if (counter == 2)
        {
            question.text = "Alright. Want a cigarette meanwhile, James?";
        }

        if (counter == 3)
        {
            question.text = "For fuck's sake. Let's be reasonable, help me, help you.";
        }

        if (counter == 4)
        {
            question.text = "Eat. A. Dick. You. Little. Shit. There's no time for your crap.";
        }
        if (counter == 5)
        {
            cop.SetActive(false);
            button.SetActive(false);
            evidence.SetActive(true);
            question.text = " ";
        }
    }

    public void SwitchScreen()
    {
            hiddenObjGame.SetActive(true);
            evidence.SetActive(false);
    }
}
