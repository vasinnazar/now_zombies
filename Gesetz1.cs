using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gesetz1 : MonoBehaviour
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
        pol = PlayerPrefs.GetInt("arm");
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        SetVolume(PlayerPrefs.GetInt("volume", 50) != 50 ? true : false);
        pol += 3;
    }

    // Update is called once per frame
    void Update()
    {
       // if (te != null)
       // {
            te = GameObject.Find("Arm").GetComponent<TextMesh>();
            te.text = pol.ToString();
        //}
        if (isTouched())
        {
            if (pol >= 1)
            {
                if (id == 0)
                {
                    id = 1;
                    pol -= 1;
                }
                else
                {
                    id = 0;
                    pol += 1;
                }
            }
            
            SetVolume(PlayerPrefs.GetInt("volume", 50) != 50 ? true : false);
        }
    }
    private void SetVolume(bool isOn)
    {
        if (isOn)
        {
            //spriteRenderer.sprite = VolumeOn;
            PlayerPrefs.SetInt("volume", 50);
        }
        else
        {
           // spriteRenderer.sprite = VolumeOff;
            PlayerPrefs.SetInt("volume", 0);
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
    /*public void OnMouseDown()
    {
        
        
    }*/
}
