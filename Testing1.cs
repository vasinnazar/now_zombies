using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing1 : MonoBehaviour
{
    private void Update()
    {
        if (Input.touchCount != 1) return;

        var wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        var touchPos = new Vector2(wp.x, wp.y);

        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
        {
            // Your code
            Debug.Log("Loche");
        }
    }
}
