using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4bDialogue : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public Text Char4name;
    public Text Char4speech;
    public GameObject dialogue;
    public GameObject ArtChar1;
    public GameObject ArtChar2;
    public GameObject ArtChar3;
    public GameObject ArtChar4;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
	public GameHandler gameHandlerObj;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtChar3.SetActive(false);
        ArtChar4.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
    }

    void FixedUpdate()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            dialogue.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Hey! I'm sorry I'm the last one here...";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "No worries man, I came a bit early. I think I’m just excited to get started!";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char4name.text = "Mr. Meep";
            Char4speech.text = "I hoped you’d have been here sooner, but I can’t say I’m upset. I haven’t used this guitar in years and it gave me time to dust the old boy off.";
        }
        else if (primeInt == 5)
        {

            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(true);
            ArtChar4.SetActive(false);
            Char2name.text = "";
            Char2speech.text = "";
           

		if (gameHandlerObj.WhatIsK4t() == true){
			Char1name.text = "";
            Char1speech.text = "";
		    Char3name.text = "K4t";
            Char3speech.text = "I don’t mind! It gave me plenty of time to feast on the snacks Eddy brought. Hurry and set up though, there’s nothing left to eat and I’m getting bored!!";
		}
		else{
            Char1name.text = "Jazz";
            Char1speech.text = "I'll try my best!";
			
			Char3name.text = "";
            Char3speech.text = "";
			}
			
			
			
            Char4name.text = "";
            Char4speech.text = "";

            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Just let me get the mic all set up and I think we’ll be ready to go.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 7)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(true);
            ArtChar4.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "We should start by picking what song we want to play.";
        }
        else if (primeInt == 8)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(true);
            ArtChar4.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "Something that everyone likes!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "Jazz";
            Char1speech.text = "Hmmm… what genre are we thinking?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "Mr. Meep";
            Char4speech.text = "Something smooth and nostalgic…";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "Something that has a lot of keyboard action!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 12)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Not to play too much off your name, Jazz, but how about something jazzy?";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 13)
        {
            Char1name.text = "Jazz";
            Char1speech.text = "That seems to tick all the boxes!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 14)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "Let's do it!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 15)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "Mr. Meep";
            Char4speech.text = "I'll be excited for that!";
           

        }
        else if (primeInt == 16)
        {
            Char1name.text = "Jazz";
            Char1speech.text = "Alright!!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 17)
        {
            Char1name.text = "Jazz";
            Char1speech.text = "The group plays their song";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 18)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Wow, that was fun! Not sure how we sounded, but the important part is that was a blast!";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 19)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "Mr. Meep";
            Char4speech.text = "I’ve played with many bands in the past, and I have to say, we sounded pretty good. Looks like I still got it in me after all these years.";
        }

        else if (primeInt == 20)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "Yeah! That was awesome!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 21)
        {
            Char1name.text = "Jazz";
            Char1speech.text = "I’m so glad. I was worried we wouldn’t be able to pull something off, but I think we still have a chance here!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
            NextScene1Button.SetActive(true);
            nextButton.SetActive(false);

        }

        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "Jazz";
            Char1speech.text = "Okay!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Eddy";
        Char2speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Eddy";
        Char2speech.text = "";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }


    public void SceneChange2a()
    {
        SceneManager.LoadScene("5b");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("Scene2b");
    }
}