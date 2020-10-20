using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToTriggerOn : MonoBehaviour
{

    private BoxCollider2D bc;
    private Rigidbody2D rb;
    public string near;
    //public string near1;
    public int i;
    public int style;
    public int zom;
    private IEnumerator coroutine;
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
        coroutine = WaitAndPrint(1.0f);
        //gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("logo");
        ////gameObject.transform.Translate(4.0f, 0.0f, 0.0f);
        //gameObject.transform.localScale = new Vector2(2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        bc = GetComponent<BoxCollider2D>();
       if(style >= 1)
        {
            //eld return new WaitForSeconds(10);
        StartCoroutine(coroutine);
            //zom = Random.Range(0, 5);
        }
        //i = col.gameObject.GetComponent<ToTriggerOn>().i;
    }
   /* void OnMouseDown()
    {
 bc.size = new Vector2(10.0f, 10.0f); 
    }*/
    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            zom = Random.Range(0, 5);

        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        //spriteMove = -0.1f;
        near = col.gameObject.name + gameObject.name;
        //near1 = col.gameObject.name + gameObject.name + Time.time;
        i = col.gameObject.GetComponent<ToTriggerOn>().i;
        //return col.gameObject;
       
    }

}
