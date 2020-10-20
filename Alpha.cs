using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alpha : MonoBehaviour
{
    private Renderer rend;
    [SerializeField]
    private Color colorToTurnTo = Color.white;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = colorToTurnTo;
        //StartCoroutine(ForAlpha());
    }
    /*private IEnumerator ForAlpha()
    {
        
        yield return new WaitForSeconds(0.3f);
        Debug.Log("Colour");
        colorToTurnTo = new Color(0.8f, 0.7f, 0.4f, 1);
        yield return new WaitForSeconds(0.1f);
        Debug.Log("Colour");
        colorToTurnTo = new Color(0.8f, 0.6f, 0.6f, 1);
        yield return new WaitForSeconds(0.1f);
        Debug.Log("Colour");
        colorToTurnTo = new Color(0.7f, 0.5f, 0.5f, 1);
        yield return new WaitForSeconds(0.1f);
        Debug.Log("Colour");
        colorToTurnTo = new Color(0.6f, 0.3f, 0.3f, 1);
        yield return new WaitForSeconds(0.1f);
        Debug.Log("Colour");
        colorToTurnTo = new Color(0.5f, 0, 0, 1);
        yield return new WaitForSeconds(0.1f);
        Debug.Log("Colour");
        colorToTurnTo = new Color(0.4f, 0, 0, 1);
        yield return new WaitForSeconds(0.1f);
        Debug.Log("Colour");
        colorToTurnTo = new Color(0.3f, 0, 0, 1);
        yield return new WaitForSeconds(0.3f);
        Debug.Log("Colour");
        colorToTurnTo = new Color(0.2f, 0, 0, 1);
        yield return new WaitForSeconds(0.1f);
        Debug.Log("Colour");
        colorToTurnTo = new Color(0.1f, 0, 0, 1);
        yield return new WaitForSeconds(0.1f);
        Debug.Log("Colour");
        colorToTurnTo = new Color(0, 0, 0, 1);
    }*/
    // Update is called once per frame
    void Update()
    {
        rend.material.color = colorToTurnTo;
    }
}
