using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class News : MonoBehaviour
{
    //public Transform gameObject;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(BroadCast());
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
    //private IEnumerator BroadCast()
    //{
       // yield return new WaitForSeconds(1.0f);
    //}
}
