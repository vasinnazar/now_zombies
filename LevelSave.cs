using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSave : MonoBehaviour
{
    public GameObject tuer1;
    public GameObject tuer2;
    public GameObject tuer3;
    public GameObject tuer4;
    public GameObject tuer5;
    public GameObject tuer6;
    public GameObject tuer7;
    public GameObject tuer8;
    public GameObject tuer9;
    public GameObject tuer10;
    public GameObject tuer11;
    public GameObject tuer12;
    public GameObject tuer13;
    public GameObject tuer14;
    public GameObject tuer15;
    public GameObject tuer16;
    public GameObject tuer17;
    public GameObject tuer18;
    public GameObject tuer19;
    public GameObject tuer20;
    public GameObject tuer21;
    public GameObject tuer22;
    public GameObject tuer23;
    public GameObject tuer24;
    public int door;
    public int lev;
    // Start is called before the first frame update
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        lev = PlayerPrefs.GetInt("L");
        for(int i = 1; i <= lev; i++)
        {
            Debug.Log(i);
            if(i == 1)
            {
                tuer1.SetActive(false);
            }
            if (i == 2)
            {
                tuer2.SetActive(false);
            }
            if (i == 3)
            {
                tuer3.SetActive(false);
            }
            if (i == 4)
            {
                tuer4.SetActive(false);
            }
            if (i == 5)
            {
                tuer5.SetActive(false);
            }
            if (i == 6)
            {
                tuer6.SetActive(false);
            }
            if (i == 7)
            {
                tuer7.SetActive(false);
            }
            if (i == 8)
            {
                tuer8.SetActive(false);
            }
            if (i == 9)
            {
                tuer9.SetActive(false);
            }
            if (i == 10)
            {
                tuer10.SetActive(false);
            }
            if (i == 11)
            {
                tuer11.SetActive(false);
            }
            if (i == 12)
            {
                tuer12.SetActive(false);
            }
            if (i == 13)
            {
                tuer13.SetActive(false);
            }
            if (i == 14)
            {
                tuer14.SetActive(false);
            }
            if (i == 15)
            {
                tuer15.SetActive(false);
            }
            if (i == 16)
            {
                tuer16.SetActive(false);
            }
            if (i == 17)
            {
                tuer17.SetActive(false);
            }
            if (i == 18)
            {
                tuer18.SetActive(false);
            }
            if (i == 19)
            {
                tuer19.SetActive(false);
            }
            if (i == 20)
            {
                tuer20.SetActive(false);
            }
            if (i == 21)
            {
                tuer21.SetActive(false);
            }
            if (i == 22)
            {
                tuer22.SetActive(false);
            }
            if (i == 23)
            {
                tuer23.SetActive(false);
            }
            if (i == 24)
            {
                tuer24.SetActive(false);
            }
        }
    }
}
