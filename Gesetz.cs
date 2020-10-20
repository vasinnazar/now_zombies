using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gesetz : MonoBehaviour
{
    public GameObject texr;
    public TextMesh te;
    public int pol;
    public int id = 0;
    private SpriteRenderer spriteRenderer;
    public Sprite VolumeOn, VolumeOff;

    // Start is called before the first frame update
    void Start()
    {
        pol = PlayerPrefs.GetInt("pol");
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        SetVolume(PlayerPrefs.GetInt("volume", 50) != 50 ? true : false);
        pol += 20;
    }

    // Update is called once per frame
    void Update()
    {
       // if (te != null)
        //{
            te = GameObject.Find("Pol").GetComponent<TextMesh>();
            te.text = pol.ToString();
        //}
        if (isTouched())
        {
            if (pol >= 2)
            {
                if (id == 0)
                {
                    id = 1;
                    pol -= 2;
                }
                else
                {
                    id = 0;
                    pol += 2;
                }
            }
            SetVolume(PlayerPrefs.GetInt("volume", 50) != 50 ? true : false);
        }
    }
    /*public void OnMouse()
    {
        if(id == 0)
        {
            id = 1;
            pol -= 2;
        }
        else
        {
            id = 0;
            pol += 2;
        }
        
    }*/
    private void SetVolume(bool isOn)
    {
        if (isOn)
        {
           // spriteRenderer.sprite = VolumeOn;
            PlayerPrefs.SetInt("volume", 50);
        }
        else
        {
           // spriteRenderer.sprite = VolumeOff;
            PlayerPrefs.SetInt("volume", 0);
        }
        /*if (id == 0)
        {
            id = 1;
            pol -= 2;
        }
        else
        {
            id = 0;
            pol += 2;
        }*/
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
            if(GetComponent<Collider2D>() == Physics2D.OverlapPoint(mousePos))
            {
                result = true;
            }
        }
        return result;
    }
}
