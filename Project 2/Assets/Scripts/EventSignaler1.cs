﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.IO;
using System.Text;
using System;

public class EventSignaler1 : MonoBehaviour {
    public int secPerBeat = 1;
    public UnityEvent Event1, Event2, Event3, Event4, Event5, Event6, Event7, Event8, Event9,
        EventA, EventB, EventC, EventD, EventE, EventF, EventG, EventH, EventI, EventJ, EventK;    //We can use this to signal to all platforms when theres a switch

    private int msTillLoopStarts = 0;
    private int bpm = 0;
    private string timeMeasure = "";
    private string notes = "";
    private bool paused = true;
    private int i = 0;

    // Use this for initialization
    void Start () {
		readFile("A_Fifth_of_Beethoven_Rhythm_File.txt");
        i = notes.Length - 1;
        Invoke("pause", msTillLoopStarts/1000);
	}
	
	// Update is called once per frame
	void Update () {
        if(!paused){
            paused = true;

            signal (notes[i]);
            if(i == notes.Length - 1) i = -1;
            i++;
            if(i == notes.Length - 1) i = 0;
            Debug.Log(i);
            signal (notes[i]);

            Invoke("pause", 2);
        }
    }

    void readFile(string fileName){
        try{
            StreamReader reader = new StreamReader("Assets/Files/" + fileName, Encoding.Default);
            using (reader){
                
                msTillLoopStarts = int.Parse(reader.ReadLine());
                bpm = int.Parse(reader.ReadLine());
                timeMeasure = reader.ReadLine();
                notes = reader.ReadLine();

                reader.Close();
            }
        } catch(Exception e){
            Debug.Log(e);
        }
    }

    void pause(){
        paused = !paused;
    }

    void signal(char c){
        switch (c){
            case '0':
                break;
            case '1':
                Debug.Log("got called?");
                Event1.Invoke();
                break;
            case '2':
                Event2.Invoke();
                break;
            case '3':
                Event3.Invoke();
                break;
            case '4':
                Event4.Invoke();
                break;
            case '5':
                Event5.Invoke();
                break;
            case '6':
                Event6.Invoke();
                break;
            case '7':
                Event7.Invoke();
                break;
            case '8':
                Event8.Invoke();
                break;
            case '9':
                Event9.Invoke();
                break;
            case 'a':
                EventA.Invoke();
                break;
            case 'b':
                EventB.Invoke();
                break;
            case 'c':
                EventC.Invoke();
                break;
            case 'd':
                EventD.Invoke();
                break;
            case 'e':
                EventE.Invoke();
                break;
            case 'f':
                EventF.Invoke();
                break;
            case 'g':
                EventG.Invoke();
                break;
            case 'h':
                EventH.Invoke();
                break;
            case 'i':
                EventI.Invoke();
                break;
            case 'j':
                EventJ.Invoke();
                break;
            case 'k':
                EventK.Invoke();
                break;
        }
    }
}