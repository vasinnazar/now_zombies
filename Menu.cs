using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public int lev;
    public int inde;
    public Text te;
    public int desunkt;
    public int indeks;
    public GameObject windowprop;
    // Start is called before the first frame update
    void Start()
    {
        inde = PlayerPrefs.GetInt("I");
       // lev = PlayerPrefs.GetInt("L");
        desunkt = PlayerPrefs.GetInt("D");
    }

    // Update is called once per frame
    void Update()
    {
        if (te != null)
        {
            te = GameObject.Find("Punkt").GetComponent<Text>();
            te.text = desunkt.ToString();
        }
        if (isTouched())
        {
            if(indeks == 1)
            {
                Application.LoadLevel(26);// Menu
            }
            if (indeks == 2)
            {
                //Application.LoadLevel(25);//proposal of menu
                windowprop.SetActive(true);
            }
            if (indeks == 3)
            {
                //Application.LoadLevel(26);//denial of menu
                windowprop.SetActive(false);
            }
            if (indeks == 4)
            {
                Application.LoadLevel(25);//forpaypoints
            }
            if (indeks == 5)
            {
                Application.LoadLevel(26);//forchoicegame
            }
            if (indeks == 6)
            {
                Application.Quit();//forgameexit
            }
            if(indeks == 7)
            {
                if( inde == 1)
                {
                    Application.LoadLevel(1);
                }
                if ( inde == 2)
                {
                    Application.LoadLevel(2);
                }
                if ( inde == 3)
                {
                    Application.LoadLevel(3);
                }
                if ( inde == 4)
                {
                    Application.LoadLevel(4);
                }
                if ( inde == 5)
                {
                    Application.LoadLevel(5);
                }
                if ( inde == 6)
                {
                    Application.LoadLevel(6);
                }
                if ( inde == 7)
                {
                    Application.LoadLevel(7);
                }
                if ( inde == 8)
                {
                    Application.LoadLevel(8);
                }
                if ( inde == 9)
                {
                    Application.LoadLevel(9);
                }
                if ( inde == 10)
                {
                    Application.LoadLevel(10);
                }
                if ( inde == 11)
                {
                    Application.LoadLevel(11);
                }
                if ( inde == 12)
                {
                    Application.LoadLevel(12);
                }
                if ( inde == 13)
                {
                    Application.LoadLevel(13);
                }
                if ( inde == 14)
                {
                    Application.LoadLevel(14);
                }
                if ( inde == 15)
                {
                    Application.LoadLevel(15);
                }
                if ( inde == 16)
                {
                    Application.LoadLevel(16);
                }
                if ( inde == 17)
                {
                    Application.LoadLevel(17);
                }
                if ( inde == 18)
                {
                    Application.LoadLevel(18);
                }
                if ( inde == 19)
                {
                    Application.LoadLevel(19);
                }
                if ( inde == 20)
                {
                    Application.LoadLevel(20);
                }
                if ( inde == 21)
                {
                    Application.LoadLevel(21);
                }
                if ( inde == 22)
                {
                    Application.LoadLevel(22);
                }
                if ( inde == 23)
                {
                    Application.LoadLevel(23);
                }
                if ( inde == 24)
                {
                    Application.LoadLevel(24);
                }
            }
            if (indeks == 8)
            {
                PlayerPrefs.SetInt("lin", 1);
                Application.LoadLevel(26);// Menu.ru
            }
            if (indeks == 9)
            {
                PlayerPrefs.SetInt("lin", 2);
                Application.LoadLevel(26);// Menu.en
            }
            if (indeks == 10)
            {
                Application.LoadLevel(27);// How
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
