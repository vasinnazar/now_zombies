using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChoice : MonoBehaviour
{
    public int inde = 1;
    public int todefer;
    public int lev;
    // Start is called before the first frame update
    void Start()
    {
        lev = PlayerPrefs.GetInt("L");
        if(lev == 0)
        {
            lev++;
            PlayerPrefs.SetInt("L", lev);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isTouched())
        {
            if(todefer == 1)
            {
                inde = 1;
                PlayerPrefs.SetInt("I",inde);
                //lev = 1;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(1);
            }
            if (todefer == 2)
            {
                inde = 2;
                PlayerPrefs.SetInt("I", inde);
                //lev = 2;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(2);
            }
            if (todefer == 3)
            {
                PlayerPrefs.SetInt("I",3);
               // lev = 3;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(3);
            }
            if (todefer == 4)
            {
                PlayerPrefs.SetInt("I",4);
                //lev = 4;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(4);
            }
            if (todefer == 5)
            {
                PlayerPrefs.SetInt("I",5);
               // lev = 5;
               // PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(5);
            }
            if (todefer == 6)
            {
                PlayerPrefs.SetInt("I",6);
                //lev = 6;
               // PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(6);
            }
            if (todefer == 7)
            {
                PlayerPrefs.SetInt("I",7);
               // lev = 7;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(7);
            }
            if (todefer == 8)
            {
                PlayerPrefs.SetInt("I",8);
                //lev = 8;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(8);
            }
            if (todefer == 9)
            {
                PlayerPrefs.SetInt("I",9);
                //lev = 9;
               // PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(9);
            }
            if (todefer == 10)
            {
                PlayerPrefs.SetInt("I",10);
                //lev = 10;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(10);
            }
            if (todefer == 11)
            {
                PlayerPrefs.SetInt("I",11);
                //lev = 11;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(11);
            }
            if (todefer == 12)
            {
                PlayerPrefs.SetInt("I",12);
                //lev = 12;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(12);
            }
            if (todefer == 13)
            {
                PlayerPrefs.SetInt("I",13);
                //lev = 13;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(13);
            }
            if (todefer == 14)
            {
                PlayerPrefs.SetInt("I",14);
                //lev = 14;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(14);
            }
            if (todefer == 15)
            {
                PlayerPrefs.SetInt("I",15);
                //lev = 15;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(15);
            }
            if (todefer == 16)
            {
                PlayerPrefs.SetInt("I",16);
                //lev = 16;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(16);
            }
            if (todefer == 17)
            {
                PlayerPrefs.SetInt("I",17);
                //lev = 17;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(17);
            }
            if (todefer == 18)
            {
                PlayerPrefs.SetInt("I",18);
                //lev = 18;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(18);
            }
            if (todefer == 19)
            {
                PlayerPrefs.SetInt("I",19);
                //lev = 19;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(19);
            }
            if (todefer == 20)
            {
                PlayerPrefs.SetInt("I",20);
                //lev = 20;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(20);
            }
            if (todefer == 21)
            {
                PlayerPrefs.SetInt("I",21);
                //lev = 21;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(21);
            }
            if (todefer == 22)
            {
                PlayerPrefs.SetInt("I",22);
                //lev = 22;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(22);
            }
            if (todefer == 23)
            {
                PlayerPrefs.SetInt("I",23);
                //lev = 23;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(23);
            }
            if (todefer == 24)
            {
                PlayerPrefs.SetInt("I",24);
                //lev = 24;
                //PlayerPrefs.SetInt("L", lev);
                Application.LoadLevel(24);
            }
            
        }
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
}
