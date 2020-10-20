using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu1 : MonoBehaviour
{

    public int lev;
    public TextMesh te;
    public int desunkt;
    public int indeks;
    public GameObject windowprop;
    // Start is called before the first frame update
    void Start()
    {
        lev = PlayerPrefs.GetInt("L");
        desunkt = PlayerPrefs.GetInt("D");
    }

    // Update is called once per frame
    void Update()
    {
        
            te = GameObject.Find("Punkt").GetComponent<TextMesh>();
            te.text = desunkt.ToString();
       
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
                if(lev == 1)
                {
                    Application.LoadLevel(1);
                }
                if (lev == 2)
                {
                    Application.LoadLevel(2);
                }
                if (lev == 3)
                {
                    Application.LoadLevel(3);
                }
                if (lev == 4)
                {
                    Application.LoadLevel(4);
                }
                if (lev == 5)
                {
                    Application.LoadLevel(5);
                }
                if (lev == 6)
                {
                    Application.LoadLevel(6);
                }
                if (lev == 7)
                {
                    Application.LoadLevel(7);
                }
                if (lev == 8)
                {
                    Application.LoadLevel(8);
                }
                if (lev == 9)
                {
                    Application.LoadLevel(9);
                }
                if (lev == 10)
                {
                    Application.LoadLevel(10);
                }
                if (lev == 11)
                {
                    Application.LoadLevel(11);
                }
                if (lev == 12)
                {
                    Application.LoadLevel(12);
                }
                if (lev == 13)
                {
                    Application.LoadLevel(13);
                }
                if (lev == 14)
                {
                    Application.LoadLevel(14);
                }
                if (lev == 15)
                {
                    Application.LoadLevel(15);
                }
                if (lev == 16)
                {
                    Application.LoadLevel(16);
                }
                if (lev == 17)
                {
                    Application.LoadLevel(17);
                }
                if (lev == 18)
                {
                    Application.LoadLevel(18);
                }
                if (lev == 19)
                {
                    Application.LoadLevel(19);
                }
                if (lev == 20)
                {
                    Application.LoadLevel(20);
                }
                if (lev == 21)
                {
                    Application.LoadLevel(21);
                }
                if (lev == 22)
                {
                    Application.LoadLevel(22);
                }
                if (lev == 23)
                {
                    Application.LoadLevel(23);
                }
                if (lev == 24)
                {
                    Application.LoadLevel(24);
                }
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
