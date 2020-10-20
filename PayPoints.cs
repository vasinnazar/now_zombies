using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PayPoints : MonoBehaviour
{
    public int pol;
    public int arm;
    public int ident;
    public int deservedpoints;
    public TextMesh te1;
    public TextMesh te2;
    public TextMesh te3;
    public GameObject texter1;
    public GameObject texter2;
    public GameObject texter3;
    public int tosale;
    public GameObject other;
    public bool points;
    // Start is called before the first frame update
    void Start()
    {

        //pol = PlayerPrefs.GetInt("pol");
        //arm = PlayerPrefs.GetInt("arm");
         tosale = PlayerPrefs.GetInt("S");
            deservedpoints = PlayerPrefs.GetInt("D");
        tosale += deservedpoints;
        //tosale = points;
    }

    // Update is called once per frame
    void Update()
    {
        tosale = other.GetComponent<PayPoints>().tosale;
        pol = PlayerPrefs.GetInt("pol");
        arm = PlayerPrefs.GetInt("arm");
        deservedpoints = PlayerPrefs.GetInt("D");

        
        te1 = texter1.GetComponent<TextMesh>();
        te2 = texter2.GetComponent<TextMesh>();
        te3 = texter3.GetComponent<TextMesh>();
        te1.text = pol.ToString();
        te2.text = arm.ToString();
        te3.text = tosale.ToString();
        if (isTouched())
        {
            if(ident == 1)
            {
                if(tosale >= 100)
                {
                    pol += 2;
                    tosale -= 100;
        te1.text = pol.ToString();
        te3.text = tosale.ToString();
                    //PlayerPrefs.SetInt("pol", pol);
                    //PlayerPrefs.SetInt("D", deservedpoints);
                }
            }
            else if (ident == 2)
            {
                if (tosale >= 100)
                {
                    arm += 1;
                    tosale -= 100;
        te2.text = arm.ToString();
                    te3.text = tosale.ToString();
                    //PlayerPrefs.SetInt("arm", arm);
                    //PlayerPrefs.SetInt("D", deservedpoints);
                }
            }
        }
        if(points == true)
        {
            tosale += 100;
            points = false;
        }
         PlayerPrefs.SetInt("pol",pol);
         PlayerPrefs.SetInt("arm",arm);
         PlayerPrefs.SetInt("S",tosale);
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
    public void Money()
    {
        points = true;
    }
}
