using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;


public class Common19 : MonoBehaviour
{
    //private AudioSource audioS;
    //private AudioSource audioS1;
    bool trend = false;
    public int iriri = 0;
    private BoxCollider2D bc;
    private Rigidbody2D rb;
    public string near;
    //public string near1;
    public int i;
    public int style;
    public int tocompare;
    private int toin;
    private int toin1;
    private int toin2;
    public int zom0;
    public int zom1;
    public int _zom;
    public int zom;
    public int cit;
    public int pol;
    public int _zom1;
    public int _zom2;
    public int zombi;
    public int dead;
    public int arm;
    public int idd;
    public int idr;
    bool boolean = false;
    public GameObject texter1;
    public GameObject texter2;
    public GameObject texter3;
    public GameObject fire;
    public GameObject outbreak;
    public GameObject rocket;
    //public GameObject med;
    public int ids;
    public int obsh;
    GameObject[] enemy;
    GameObject closest = null;
    GameObject secondclosest = null;
    GameObject thirdclosest = null;
    GameObject fourthclosest = null;
    GameObject fifthclosest = null;

    public string nearest;
    public string nearest1;
    public string nearest2;
    public string nearest3;
    public string nearest4;
    public TextMesh tex1;
    public TextMesh tex2;
    public TextMesh tex3;
    private IEnumerator coroutine;
    private IEnumerator coroutine1;
    private IEnumerator coroutine2;
    private IEnumerator coroutine3;
    private IEnumerator coroutine4;
    private IEnumerator coroutine5;
    //private IEnumerator coroutine6;
    private IEnumerator coroutine7;
    private IEnumerator coroutine9;
    private IEnumerator coroutine10;
    public GameObject shoot;
    bool bulbul = true;
    bool furr = true;
    void Awake()
    {


        //bc = gameObject.AddComponent<BoxCollider2D>() as BoxCollider2D;
        //bc.size = new Vector2(1.3f, 1.3f);
        //bc.isTrigger = true;

        rb = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
        rb.bodyType = RigidbodyType2D.Kinematic;
    }
    void Start()
    {

        toin = GameObject.Find("Field").GetComponent<TheLos10>().inter;
        toin1 = GameObject.Find("Field").GetComponent<TheLos10>().inter1;
        toin2 = GameObject.Find("Field").GetComponent<TheLos10>().inter2;
        if (toin == tocompare || toin1 == tocompare || toin2 == tocompare)
        {
            zom = 1;
        }


        cit = Random.Range(500, 701);
        // enemy = GameObject.FindGameObjectsWithTag("Enemy");
        coroutine = WaitAndPrint(0.8f);
        StartCoroutine(coroutine);
        coroutine1 = WaitAndPrint1(0.7f);
        StartCoroutine(coroutine1);
        coroutine2 = WaitAndPrint2(0.5f);
        StartCoroutine(coroutine2);
        coroutine3 = WaitAndPrint3(0.5f);
        StartCoroutine(coroutine3);
        coroutine4 = WaitAndPrint4(1.0f);
        StartCoroutine(coroutine4);
        //coroutine5 = WaitAndPrint5(1.0f);
        //StartCoroutine(coroutine5);
        //coroutine6= WaitAndPrint6(4.0f);
        //coroutine7= WaitAndPrint7(4.0f);
        coroutine7 = WaitAndPrint7(1.7f);
        StartCoroutine(coroutine7);
        coroutine9 = WaitAndPrint9(4.0f);
        coroutine10 = WaitAndPrint10(0.1f);
    }

    /* GameObject[] FindClosestEnemy()
       {
           float distance = Mathf.Infinity;
           Vector3 position = transform.position;
           foreach (GameObject go in enemy)
           {
               Vector3 diff = go.transform.position - position;
               float curDistance = diff.sqrMagnitude;
               if (curDistance < distance)
               {
                   fifthclosest = fourthclosest;
                   fourthclosest = thirdclosest;
                   thirdclosest = secondclosest;
                   secondclosest = closest;
                   closest = go;
                   distance = curDistance;
               }
           }
           //return closest;
           return new GameObject[] { closest, secondclosest, thirdclosest, fourthclosest, fifthclosest };
       }*/

    void Update()
    {
        //audioS = GetComponent<AudioSource>();
        //audioS1 = GetComponent<AudioSource>();
        ids = GameObject.Find("Depart").GetComponent<Gesetz>().id;
        idd = GameObject.Find("Military").GetComponent<Gesetz1>().id;
        //idr = GameObject.Find("Hospital").GetComponent<Gesetz2>().id;
        bc = GetComponent<BoxCollider2D>();
        if (style >= 1)
        {
            //ield return new WaitForSeconds(10);
            //  StartCoroutine(coroutine6);
            //zom = Random.Range(0, 5);
            boolean = true;
        }
        else
        {
            boolean = false;
        }
        if(boolean == true)
        {
            StartCoroutine(WaitAndPrint6());
            style = 0;
            boolean = false;
        }
      if (zom >= 9)
        {
            i = 1;

        }
        if (zom >= 10)
        {
            //StartCoroutine(coroutine7);
            
                Local();
           
        }
      if (tocompare == 1)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep1 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp1 = zom;
        }
        if (tocompare == 2)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep2 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp2 = zom;
        }
        if (tocompare == 3)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep3 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp3 = zom;
        }
        if (tocompare == 4)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep4 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp4 = zom;
        }
        if (tocompare == 5)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep5 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp5 = zom;
        }
        if (tocompare == 6)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep6 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp6 = zom;
        }
        if (tocompare == 7)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep7 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp7 = zom;
        }
        if (tocompare == 8)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep8 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp8 = zom;
        }
        if (tocompare == 9)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep9 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp9 = zom;
        }
        if (tocompare == 10)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep10 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp10 = zom;
        }
        if (tocompare == 11)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep11 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp11 = zom;
        }
        if (tocompare == 12)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep12 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp12 = zom;
        }
        if (tocompare == 13)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep13 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp13 = zom;
        }
        if (tocompare == 14)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep14 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp14 = zom;
        }
        if (tocompare == 15)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep15 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp15 = zom;
        }
        if (tocompare == 16)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep16 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp16 = zom;
        }
        if (tocompare == 17)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep17 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp17 = zom;
        }
        if (tocompare == 18)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep18 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp18 = zom;
        }
        if (tocompare == 19)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep19 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp19 = zom;
        }
        if (tocompare == 20)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep20 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp20 = zom;
        }
        if (tocompare == 21)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep21 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp21 = zom;
        }
        if (tocompare == 22)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep22 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp22 = zom;
        }
        if (tocompare == 23)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep23 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp23 = zom;
        }
        if (tocompare == 24)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep24 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp24 = zom;
        }
        if (tocompare == 25)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep25 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp25 = zom;
        }
        if (tocompare == 26)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep26 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp26 = zom;
        }
        if (tocompare == 27)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep27 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp27 = zom;
        }
        if (tocompare == 28)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep28 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp28 = zom;
        }
        if (tocompare == 29)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep29 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp29 = zom;
        }
        if (tocompare == 30)
        {
            GameObject.Find("Field").GetComponent<Totalsum>().livep30 = cit;
            GameObject.Find("Field").GetComponent<Totalsum>().deadp30 = zom;
        }


        obsh = pol + arm;
        if (zom > cit)
        {
            fire.SetActive(true);
        }
        else
        {
            fire.SetActive(false);
        }
        if (pol > 0 )
        {
            texter3.SetActive(false);
            texter1.SetActive(true);
            if (zom > 0)
            {
                texter2.SetActive(true);
            }
        }
        else
        {
            texter3.SetActive(true);
        }
        tex1 = texter1.GetComponent<TextMesh>();
        tex1.text = obsh.ToString();
        //tex1 = texter1.GetComponent<TextMesh>();
        //tex1.text = arm.ToString();
        tex2 = texter2.GetComponent<TextMesh>();
        tex2.text = zom.ToString();
        tex3 = texter3.GetComponent<TextMesh>();
        tex3.text = cit.ToString();
        if (cit <= 0)
        {
            StopCoroutine(coroutine7);
        }
        /*nearest = FindClosestEnemy()[0].name;
            nearest1 = FindClosestEnemy()[1].name;
            nearest2 = FindClosestEnemy()[2].name;
            nearest3 = FindClosestEnemy()[3].name;
            nearest4 = FindClosestEnemy()[4].name;
            _zom1 = FindClosestEnemy()[1].GetComponent<Common>().zom;
            _zom2 = FindClosestEnemy()[2].GetComponent<Common>().zom;
            zom0 = FindClosestEnemy()[3].GetComponent<Common>().zom;
            zom1 = FindClosestEnemy()[4].GetComponent<Common>().zom;
            // _zom2 = FindClosestEnemy()[2].GetComponent<ForSec>().zom;
            _zom = zom0 + zom1;
            zombi = _zom1 + _zom2;
            dead = _zom1 + _zom2 + zom0 + zom1;
            dead = dead / 4;*/
        if (isTouched())
        {
            if (ids == 1)
            {
                pol += 2;
                GameObject.Find("Depart").GetComponent<Gesetz>().id = 0;
            }
            if (idd == 1)
            {
                arm += 1;
                GameObject.Find("Military").GetComponent<Gesetz1>().id = 0;
            }

            //SetVolume(PlayerPrefs.GetInt("volume", 50) != 50 ? true : false);
        }
        if (cit <= 0)
        {
            if (bulbul == true)
            {
                StartCoroutine(coroutine10);
                bulbul = false;
            }
        }
    }
    private IEnumerator WaitAndPrint1(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            // print("WaitAndPrint " + Time.time);
            if (pol >= 1)
            {
                texter1.SetActive(true);
                //texter3.SetActive(false);
                if (zom >= 5)
                {
                    shoot.SetActive(true);
                    //audioS.Play();
                    texter2.SetActive(true);
                    //SpriteRenderer sprite = GetComponent<SpriteRenderer>();
                    //if (sprite != null) { sprite.color = Color.white; }
                    pol -= 1;
                    zom -= 5;
                    print("pol" + pol);
                    print("zom" + zom);
                    yield return new WaitForSeconds(0.2f);
                    shoot.SetActive(false);
                    yield return new WaitForSeconds(0.2f);
                    shoot.SetActive(true);
                    //audioS.Play();
                    yield return new WaitForSeconds(0.2f);
                    shoot.SetActive(false);
                    yield return new WaitForSeconds(0.2f);
                    shoot.SetActive(true);
                    //audioS.Play();
                    yield return new WaitForSeconds(0.2f);
                    shoot.SetActive(false);
                }
                else if (zom >= 1 && zom < 5)
                {
                    shoot.SetActive(true);
                    //audioS.Play();
                    texter2.SetActive(true);
                    //SpriteRenderer sprite = GetComponent<SpriteRenderer>();
                    //if (sprite != null) { sprite.color = Color.white; }
                    zom -= 1;
                    print("zom" + zom);
                    yield return new WaitForSeconds(0.2f);
                    shoot.SetActive(false);
                    yield return new WaitForSeconds(0.2f);
                    shoot.SetActive(true);
                    //audioS.Play();
                    yield return new WaitForSeconds(0.2f);
                    shoot.SetActive(false);
                    yield return new WaitForSeconds(0.2f);
                    shoot.SetActive(true);
                    //audioS.Play();
                    yield return new WaitForSeconds(0.2f);
                    shoot.SetActive(false);
                }
                else
                {   
                    shoot.SetActive(false);
                }
                //texter1.SetActive(false);
                //texter2.SetActive(false);
            }
            else
            {
                texter1.SetActive(false);
                texter2.SetActive(false);
                //texter3.SetActive(true);
            }

        }
    }
    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            // print("WaitAndPrint " + Time.time);
            if (cit >= 1)
            {
               // cit += 2;
                if (zom >= 1)
                {

                    zom += 1;
                    cit -= 1;

                }
                else
                {
                    Debug.Log("Okey");
                }
               // yield return new WaitForSeconds(1.0f);
               // cit -= 2;
            }
        }
    }
    private IEnumerator WaitAndPrint7(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            cit += 2;
            yield return new WaitForSeconds(1.7f);
            cit -= 2;
            if (cit >= 300)
                GameObject.Find("Field").GetComponent<Totalsum>().onetou++;

        }
    }
    private IEnumerator WaitAndPrint2(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            // print("WaitAndPrint " + Time.time);
            if (cit >= 1)
            {
                if (cit >= 30)
                {
                    if (zom >= 10 && zom < 20)
                    {
                        cit -= 30;
                        //GameObject.Find("Cubick").GetComponent<Percent>()._cit += 10; 
                    }
                    if (zom >= 20)
                    {
                        if (cit >= 60)
                        {
                            cit -= 60;
                        }
                        else
                        {
                            cit = 0;
                        }

                        // GameObject.Find("Cubick").GetComponent<Percent>()._cit += 30;
                    }
                }
            }
            else
            {
                cit = 0;
            }
        }
    }
    private IEnumerator WaitAndPrint3(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            // print("WaitAndPrint " + Time.time);

            if (trend == true)
            {
                cit += 50;
                iriri++;
                if (iriri == 6)
                {
                    StopCoroutine(coroutine3);
                }
                //GameObject.Find("Cubick").GetComponent<Percent>()._cit += 10; 
            }

        }
    }
    private IEnumerator WaitAndPrint4(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            // print("WaitAndPrint " + Time.time);
            if (arm >= 1)
            {
                //texter1.SetActive(true);
                //texter3.SetActive(false);
                if (zom >= 20)
                {

                    rocket.SetActive(true);
                    //audioS1.Play();
                    texter2.SetActive(true);
                    arm -= 1;
                    zom -= zom;
                    print("pol" + arm);
                    print("zom" + zom);
                    yield return new WaitForSeconds(0.2f);
                    outbreak.SetActive(true);
                }
                else if (zom >= 10 && zom < 20)
                {
                    rocket.SetActive(true);
                    //audioS1.Play();
                    texter2.SetActive(true);
                    arm -= 1;
                    zom -= zom;
                    print("pol" + arm);
                    print("zom" + zom);
                    yield return new WaitForSeconds(0.2f);
                    outbreak.SetActive(true);
                }
                else if (zom >= 1 && zom < 10)
                {
                    rocket.SetActive(true);
                    //audioS1.Play();
                    texter2.SetActive(true);

                    zom -= zom;

                    print("zom" + zom);
                    yield return new WaitForSeconds(0.2f);
                    outbreak.SetActive(true);
                }
                else
                {
                    rocket.SetActive(true);
                    texter2.SetActive(false);
                    arm -= 1;
                    yield return new WaitForSeconds(0.2f);
                    outbreak.SetActive(true);
                }
                //outbreak.SetActive(false);
                //texter1.SetActive(false);
                //texter2.SetActive(false);
            }
            else
            {
                rocket.SetActive(false);
                texter2.SetActive(false);
                texter1.SetActive(false);
                //texter3.SetActive(true);
                outbreak.SetActive(false);
            }
        }
    }
    /*ivate IEnumerator WaitAndPrint5(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            // print("WaitAndPrint " + Time.time);
            if (dead >= 10 && dead < 30)
            {
                zombi = Random.Range(0, 2);
                zom += zombi;
                //GameObject.Find("Cubick").GetComponent<Percent>()._cit += 10; 
            }
            if (dead >= 30&& dead < 50)
            {
                zombi = Random.Range(2, 5);
                zom += zombi;
                //GameObject.Find("Cubick").GetComponent<Percent>()._cit += 10; 
            }
            if (dead >= 50)
            {
                zombi = Random.Range(5, 21);
                zom += zombi;
                //GameObject.Find("Cubick").GetComponent<Percent>()._cit += 10; 
            }

        }
    }*/
    private IEnumerator WaitAndPrint6()
    {
        while (true)
        {
            yield return new WaitForSeconds(4.0f);
            zom += Random.Range(0, 5);
        }
    }
    void Local()
    {
        if (furr == true)
        {
            if (pol == 0)
            {
                StartCoroutine(coroutine9);
                furr = false;
            }
        }
        //bc.size = new Vector2(5.0f, 5.5f);
        // bc.size = new Vector2(3.0f, 3.0f);

    }
    /*private IEnumerator WaitAndPrint7(float waitTime)
    {
        while (true)
        {

            bc.size = new Vector2(10.0f, 10.0f);
            yield return new WaitForSeconds(0.5f);
            bc.size = new Vector2(3.0f, 3.0f);

        }
    }*/
    private IEnumerator WaitAndPrint10(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            if (zom >= 1)
            {
                zom--;
            }

        }
    }
    private IEnumerator WaitAndPrint9(float waitTime)
    {
        while (true)
        {
            bc.size = new Vector2(5.0f, 5.5f);
            if (zom >= 10)
            {
                zom -= Random.Range(0, 5);
            }
            yield return new WaitForSeconds(waitTime);
            bc.size = new Vector2(3.5f, 3.0f);
            if (zom >= 10)
            {
                zom -= Random.Range(0, 5);
            }
            yield return new WaitForSeconds(4.0f);
            bc.size = new Vector2(5.0f, 5.5f);
            if (zom >= 10)
            {
                zom -= Random.Range(0, 5);
            }

        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        //spriteMove = -0.1f;
        near = col.gameObject.name + gameObject.name;
        //near1 = col.gameObject.name + gameObject.name + Time.time;
  style= col.gameObject.GetComponent<Common19>().i;
        //return col.gameObject;
        //style += i;
        if (zom <= 6)
        { trend = true; }
    }
    public bool isTouched()
    {
        bool result = false;
        if (Input.touchCount == 1)
        {
            if (Input.touches[0].phase == TouchPhase.Ended)
            {
                Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                Vector2 touchPos = new Vector2(wp.x, wp.y);
                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {
                    result = true;
                }
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos = new Vector2(wp.x, wp.y);
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(mousePos))
            {
                result = true;
            }
        }
        return result;
    }
    /*public void OnMouseDown()
    {
        if (ids == 1)
        {
            pol += 2;
            GameObject.Find("Depart").GetComponent<Gesetz>().id = 0;
        }
        if (idd == 1)
        {
            arm += 1;
            GameObject.Find("Military").GetComponent<Gesetz1>().id = 0;
        }
        if (idr == 1)
        {
            med.SetActive(true);
            GameObject.Find("Hospital").GetComponent<Gesetz2>().id = 0;
        }
    }*/
    /*public void Army()
    {
        
    }*/

}