using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuEn2 : MonoBehaviour
{
    public int ling;
    string infec;
    string poin;
    string srpoin;
    string neuig;
    string bomba;
    string propo;
    string extra;
    public GameObject menu;
    public GameObject exit;
    public GameObject next;
    public GameObject no;
    public GameObject yes;
    public GameObject learn;
    public TextMesh te1;
    public GameObject texter1;
    public TextMesh te2;
    public GameObject texter2;
    public TextMesh te3;
    public GameObject texter3;
    public TextMesh te4;
    public GameObject texter4;
    public TextMesh te5;
    public GameObject texter5;
    public TextMesh te6;
    public GameObject texter6;
    public TextMesh te7;
    public GameObject texter7;
    // Start is called before the first frame update
    void Start()
    {
        //ling = 2;
        ling = PlayerPrefs.GetInt("lin");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ling == 1)
        {
            infec = "Инфицированных:";
            poin = "Очки:";
            srpoin = "Заработанные очки:";
            neuig = "Сообщение о вспышке инфекции. Необходимо локализовать и ликвидировать угрозу распространения с использованием полиции и армии.";
            bomba = "Угроза бомбандировки";
            propo = "Выйти в меню?";
            extra = "Получить больше очков";
            menu.SetActive(false);
            //exit.SetActive(false);
            next.SetActive(false);
            //no.SetActive(false);
            //yes.SetActive(false);
            //learn.SetActive(false);
}
        if (ling == 2)
        {
             infec = "Infected:";
            poin = "Points:";
            srpoin = "Scored points:";
             neuig = "Report of an outbreak of infections. It is necessary to localize and eliminate the threat of proliferation with the use of police and army.";
            bomba = "Warning about bombing";
            propo = "Get to menu?";
            extra = "Get extra points";
            menu.SetActive(true);
            //exit.SetActive(true);
            next.SetActive(true);
            //no.SetActive(true);
            //yes.SetActive(true);
            //learn.SetActive(true);
        }
        //te1 = texter1.GetComponent<TextMesh>();
        //te1.text = infec.ToString();
        //te2 = texter2.GetComponent<TextMesh>();
        //te2.text = poin.ToString();
        te3 = texter3.GetComponent<TextMesh>();
        te3.text = srpoin.ToString();
        //te4 = texter4.GetComponent<TextMesh>();
        //te4.text = neuig.ToString();
        //te5 = texter5.GetComponent<TextMesh>();
        //te5.text = bomba.ToString();
        //te6 = texter6.GetComponent<TextMesh>();
        //te6.text = propo.ToString();
        te7 = texter7.GetComponent<TextMesh>();
        te7.text = extra.ToString();
    }
}
