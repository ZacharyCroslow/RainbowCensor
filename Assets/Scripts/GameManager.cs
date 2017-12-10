using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    /* Redundant code
    Color Belief = new Color(255, 2, 39, 1);
    Color Education = new Color(0, 0, 0, 1);
    Color Information = new Color(0, 0, 0, 1);
    Color Science = new Color(0, 0, 0, 1);
    Color Media = new Color(0, 0, 0, 1);
    Color Arts = new Color(0, 0, 0, 1);
    Color Military = new Color(0, 0, 0, 1);
    */

    //want to add list of true bools below allowing average of their respective colour values given as the colour for the final stream

    bool bel = true;
    bool edu = true;
    bool info = true;
    bool sci = true;
    bool med = true;
    bool art = true;
    bool mil = true;
    bool cen = true;

    //Toggles

        //Belief
        public GameObject BeliefStream;

        //Education
        public GameObject EducationStream;

        //Information
        public GameObject InfoStream;

        //Science
        public GameObject ScienceStream;

        //Media
        public GameObject MediaStream;

        //Arts
        public GameObject ArtsStream;

        //Military
        public GameObject MilitaryStream;

        //Censorship
        public GameObject CensorStream;


    // Use this for initialization
    void Start () {

       

		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //switch fo
        toggleBel();
        toggleedu();
        toggleinfo();
        togglesci();
        togglemedia();
        toggleart();
        togglemil();
        togglecen();
    }
    //gaining the colour 
    public void FinalColour (Color Censor)
    {

    }

    //Toggle affects bool to supply colour change

    public void toggleBel()
    {
        if (BeliefStream.activeInHierarchy == true)
        {
            bel = true;
        }
        else bel = false;
    }

    public void toggleedu()
    {
        if (EducationStream.activeInHierarchy == true)
        {
            edu = true;
        }
        else edu = false;
    }

    public void toggleinfo()
    {
        if (InfoStream.activeInHierarchy == true)
        {
            info = true;
        }
        else info = false;
    }

    public void  togglesci()
    {
        if (ScienceStream.activeInHierarchy == true)
        {
            sci = true;
        }
        else sci = false;
    }    

    public void togglemedia()
    {
        if (MediaStream.activeInHierarchy == true)
        {
            med = true;
        }
        else med = false;
    }

    public void toggleart()
    {
        if(ArtsStream.activeInHierarchy == true)
        {
            art = true;
        }
        else art = false;
    }

    public void togglemil()
    {
        if (MilitaryStream == true)
        {
            mil = true;
        }
        else mil = false;
    }

    public void togglecen()
    {
        if (CensorStream == true)
        {
            cen = true;
        }
        else cen = false;
    }

    // Toggle turns streams visually on and off
    public void BeliefToggle(bool newvalue)
    {        
        BeliefStream.SetActive(newvalue);        
    }


    public void EduToggle(bool newvalue)
    {
        EducationStream.SetActive(newvalue);
        edu = !edu;
    }


    public void InfoToggle(bool newvalue)
    {
        InfoStream.SetActive(newvalue);
    }


    public void SciToggle(bool newvalue)
    {
        ScienceStream.SetActive(newvalue);
    }


    public void MediaToggle(bool newvalue)
    {
        MediaStream.SetActive(newvalue);
    }


    public void ArtToggle(bool newvalue)
    {
        ArtsStream.SetActive(newvalue);
    }


    public void MilitaryToggle(bool newvalue)
    {
        MilitaryStream.SetActive(newvalue);
    }

    public void CensorshipToggle(bool newvalue)
    {
        CensorStream.SetActive(newvalue);
    }
}
