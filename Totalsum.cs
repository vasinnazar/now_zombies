using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Totalsum : MonoBehaviour
{
    public GameObject menubutton;
    public GameObject news;
    public int district;
    public GameObject exp;
    public GameObject expRock;
    public GameObject nosignal;
    //public GameObject loss;
    public int timer;
    //public GameObject win;
    public GameObject texttoloss;
    public int lev;
    public int points;
    public int inde;
    public int deservedpoints;
    private IEnumerator coroutine;
    public int onetou;
    public int deadp;
    public int livep;
    public int deadp1;
    public int livep1;
    public int deadp2;
    public int livep2;
    public int deadp3;
    public int livep3;
    public int deadp4;
    public int livep4;
    public int deadp5;
    public int livep5;
    public int deadp6;
    public int livep6;
    public int deadp7;
    public int livep7;
    public int deadp8;
    public int livep8;
    public int deadp9;
    public int livep9;
    public int deadp10;
    public int livep10;
    public int deadp11;
    public int livep11;
    public int deadp12;
    public int livep12;
    public int deadp13;
    public int livep13;
    public int deadp14;
    public int livep14;
    public int deadp15;
    public int livep15;
    public int deadp16;
    public int livep16;
    public int deadp17;
    public int livep17;
    public int deadp18;
    public int livep18;
    public int deadp19;
    public int livep19;
    public int deadp20;
    public int livep20;
    public int deadp21;
    public int livep21;
    public int deadp22;
    public int livep22;
    public int deadp23;
    public int livep23;
    public int deadp24;
    public int livep24;
    public int deadp25;
    public int livep25;
    public int deadp26;
    public int livep26;
    public int deadp27;
    public int livep27;
    public int deadp28;
    public int livep28;
    public int deadp29;
    public int livep29;
    public int deadp30;
    public int livep30;
    public TextMesh texd;
    public TextMesh texl;
    public GameObject de;
    public GameObject li;
    bool bulbul = true;
    bool furfur = true;
    public int kiek = 0;
    public GameObject other;
    public int foradds;
    // Start is called before the first frame update
    void Start()
    { 

        foradds = PlayerPrefs.GetInt("AD");
        foradds += 1;
        coroutine = WaitAndPrint(2.0f);
        StartCoroutine(coroutine);
        lev = PlayerPrefs.GetInt("L");
        inde = PlayerPrefs.GetInt("I");
        points = PlayerPrefs.GetInt("P");
        StartCoroutine(Copy());
        //lev = 1;
        if(inde == lev)
        {
            kiek = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        deadp = deadp1 + deadp2 + deadp3 + deadp4 + deadp5 + deadp6 + deadp7 + deadp8 + deadp9 + deadp10 + deadp11 + deadp12 + deadp13 + deadp14 + deadp15 + deadp16 + deadp17 + deadp18 + deadp19 + deadp20 + deadp21 + deadp22 + deadp23 + deadp24 + deadp25 + deadp26 + deadp27 + deadp28 + deadp29 + deadp30;
        livep = livep1 + livep2 + livep3 + livep4 + livep5 + livep6 + livep7 + livep8 + livep9 + livep10 + livep11 + livep12 + livep13 + livep14 + livep15 + livep16 + livep17 + livep18 + livep19 + livep20 + livep21 + livep22 + livep23 + livep24 + livep25 + livep26 + livep27 + livep28 + livep29 + livep30;
       // deadp = deadp + deadp;
         texd = de.GetComponent<TextMesh>();
        texd.text = deadp.ToString();
        texl = li.GetComponent<TextMesh>();
        texl.text = onetou.ToString();
        if(deadp <= 0)
        {
            if (furfur == true)
            {
                deservedpoints += onetou;
            //PlayerPrefs.SetInt("P", points);
            PlayerPrefs.SetInt("D", deservedpoints);
                
                StartCoroutine(Death());
                furfur = false;
            }
        }
        
        if(deadp > livep)
        {
            //exp.SetActive(true);
            if(bulbul == true)
            {
            StartCoroutine(Explose());
            points += 150;
        bulbul = false;
            }
            //PlayerPrefs.SetInt("P", points);
        }
    }
    private IEnumerator Death(){

        yield return new WaitForSeconds(2.0f);
            
            //lev += kiek;
        //inde += kiek;
        
        lev += 1;
        inde += 1;
        if(inde != lev)
        {
            lev--;
            Debug.Log("Minus");
        }
        /*if (timer >= 0 && timer < 10)
        {
            points += 150;
            deservedpoints = 150;
            PlayerPrefs.SetInt("P", points);
            PlayerPrefs.SetInt("D", deservedpoints);
        }
        if (timer >= 10 && timer < 30)
        {
            points += 200;
            deservedpoints = 200;
            PlayerPrefs.SetInt("P", points);
            PlayerPrefs.SetInt("D", deservedpoints);
        }
        if (timer >= 30 && timer < 40)
        {
            points += 250;
            deservedpoints = 250;
            PlayerPrefs.SetInt("P", points);
            PlayerPrefs.SetInt("D", deservedpoints);
        }
        if (timer >= 40 && timer < 50)
        {
            points += 300;
            deservedpoints = 300;
            PlayerPrefs.SetInt("P", points);
            PlayerPrefs.SetInt("D", deservedpoints);
        }
        if (timer >= 50 && timer < 60)
        {
            points += 350;
            deservedpoints = 350;
            PlayerPrefs.SetInt("P", points);
            PlayerPrefs.SetInt("D", deservedpoints);
        }
        if (timer >= 60)
        {
            points += 400;
            deservedpoints = 400;
            PlayerPrefs.SetInt("P", points);
            PlayerPrefs.SetInt("D", deservedpoints);
        }*/
        //win
        //win.SetActive(true);
        //points += onetou;
        //deservedpoints = onetou;
        PlayerPrefs.SetInt("I", inde) ;
        PlayerPrefs.SetInt("L", lev);
        if(foradds == 3)
        {
        other.SetActive(true);
            foradds = 0;
            PlayerPrefs.SetInt("AD", foradds);
        }
        else { 

            PlayerPrefs.SetInt("AD", foradds);
        Application.LoadLevel(25);
        }
            //Application.LoadLevel(25);
        }
    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            //timer++;
            
            if(nosignal.activeSelf == true)
            {
            PlayerPrefs.SetInt("AD", foradds);
            yield return new WaitForSeconds(5.0f);
                //Application.LoadLevel(25);//loss
            }
        }
    }
    private IEnumerator Copy()
    {
        yield return new WaitForSeconds(0.5f);
        news.SetActive(true);
        yield return new WaitForSeconds(9.0f);
        news.SetActive(false);
    }
    private IEnumerator Explose()
    {
            texttoloss.SetActive(true);
        yield return new WaitForSeconds(10.0f);
        if (deadp > livep)
        {
            expRock.SetActive(true);
            menubutton.SetActive(false);
            de.SetActive(false);
            li.SetActive(false);
            //texttoloss.SetActive(false);
            //points += 150;
            PlayerPrefs.SetInt("P", points);
            yield return new WaitForSeconds(0.2f);
            expRock.SetActive(false);
            exp.SetActive(true);
            yield return new WaitForSeconds(1.0f);
            nosignal.SetActive(true);

        }
    }
}
