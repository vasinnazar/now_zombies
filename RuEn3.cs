using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuEn3 : MonoBehaviour
{
    public int ling;
    string infec;
    string civil;
    string sepol;
    string areapol;
    string searm;
    string areaarm;
    string points;
    public GameObject inf;
    public GameObject civ;
    public GameObject sep;
    public GameObject arp;
    public GameObject sea;
    public GameObject ara;
    public GameObject poi;
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
        StartCoroutine(Learning());
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ling == 1)
        {
            infec = "Здесь вы можете видеть количество \n" +
                "инфицированных.";
            civil = "Это количество гражданских, когда район заражён люди\n" +
                " будут проподать или бежать из него.";
            sepol = "Выберете участок, чтобы применить\n" +
                " полицию.";
            areapol = "Выберете район, чтобы \n" +
                "перекрыть его нарядом полиций.";
            searm = "Выберете военную базу, чтобы\n" +
                " применть армию.";
            areaarm = "Выберете район который \n" +
                "хотите зачистить от инфицированных.";
            points = "Чем больше здоровых граждан,\n" +
                " тем больше очков вы получите.";
            
}
        if (ling == 2)
        {
            infec = "Here you can see the number\n" +
                " of infected people.";
            civil = "This is the number of civilians. when an area \n" +
                "is infected, people will disappear or flee it.";
            sepol = "Select a police station \n" +
                "to apply the police.";
            areapol = "Select an area to block \n" +
                "the area with a police squad.";
            searm = "Select a military base\n" +
                " to apply the army.";
            areaarm = "Select the area that you want\n" +
                " to clear of infected.";
            points = "The more healthy citizens,\n" +
                " the more points you will get.";
      
        }
        te1 = texter1.GetComponent<TextMesh>();
        te1.text = infec.ToString();
        te2 = texter2.GetComponent<TextMesh>();
        te2.text = civil.ToString();
        te3 = texter3.GetComponent<TextMesh>();
        te3.text = sepol.ToString();
        te4 = texter4.GetComponent<TextMesh>();
        te4.text = areapol.ToString();
        te5 = texter5.GetComponent<TextMesh>();
        te5.text = searm.ToString();
        te6 = texter6.GetComponent<TextMesh>();
        te6.text = areaarm.ToString();
        te7 = texter7.GetComponent<TextMesh>();
        te7.text = points.ToString();
    }
    private IEnumerator Learning()
    {
        yield return new WaitForSeconds(2.0f);
        inf.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        civ.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        sep.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        arp.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        sea.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        ara.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        poi.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        Application.LoadLevel(26);
    }
}
