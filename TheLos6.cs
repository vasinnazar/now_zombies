using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheLos6 : MonoBehaviour
{
    public int inter;
    /*GameObject[] enemy;
    GameObject closest = null;
    GameObject secondclosest = null;
    GameObject thirdclosest = null;
    GameObject fourthclosest = null;
    GameObject fifthclosest = null;
    GameObject sixthclosest = null;
    GameObject seventhclosest = null;
    GameObject eighthclosest = null;
    GameObject ninthclosest = null;
    GameObject tenthclosest = null;
    GameObject elevenclosest = null;
    GameObject twelveclosest = null;
    GameObject thirteenclosest = null;
    GameObject fourteenclosest = null;
    GameObject fifteenclosest = null;
    GameObject sixteenclosest = null;
    GameObject eighteenclosest = null;
    GameObject ninteenclosest = null;
    GameObject twentyclosest = null;
    GameObject twentyoneclosest = null;
    GameObject twentytwoclosest = null;
    GameObject twentythreeclosest = null;
    GameObject twentyfourclosest = null;
    GameObject twentyfiveclosest = null;
    GameObject twentysixclosest = null;
    GameObject twentysevenclosest = null;
    GameObject twentyeightclosest = null;
    GameObject twentynineclosest = null;
    GameObject thirtyoneclosest = null;
    GameObject thirtytwoclosest = null;
    GameObject thirtythreeclosest = null;
    GameObject thirtyfourclosest = null;
    GameObject thirtyfiveclosest = null;
    GameObject thirtysixclosest = null;
    GameObject thirtysevenclosest = null;
    GameObject thirtyeightclosest = null;
    GameObject thirtynineclosest = null;
    GameObject fortyclosest = null;
    GameObject fortyoneclosest = null;
    GameObject fortytwoclosest = null;
    GameObject fortythreeclosest = null;
    GameObject fortyfourclosest = null;
    GameObject fortyfiveclosest = null;
    GameObject fortysixclosest = null;
    GameObject fortysevenclosest = null;
    GameObject fortyeightclosest = null;
    GameObject fortynineclosest = null;
    GameObject fiftyclosest = null;*/


    
    // Start is called before the first frame update
    void Awake()
    {
        inter = Random.Range(1, 16);
        /*enemy = GameObject.FindGameObjectsWithTag("Enemy");
        int i = Random.Range(1, 31);
        switch (i)
        {
            case 1:
                FindClosestEnemy()[1].GetComponent<Common1>().zom = 1;
                break;
            case 2:
                FindClosestEnemy()[2].GetComponent<Common1>().zom = 1;
                break;
            case 3:
                FindClosestEnemy()[3].GetComponent<Common1>().zom = 1;
                break;
            case 4:
                FindClosestEnemy()[4].GetComponent<Common1>().zom = 1;
                break;
            case 5:
                FindClosestEnemy()[5].GetComponent<Common1>().zom = 1;
                break;
            case 6:
                FindClosestEnemy()[6].GetComponent<Common1>().zom = 1;
                break;
            case 7:
                FindClosestEnemy()[7].GetComponent<Common1>().zom = 1;
                break;
            case 8:
                FindClosestEnemy()[8].GetComponent<Common1>().zom = 1;
                break;
            case 9:
                FindClosestEnemy()[9].GetComponent<Common1>().zom = 1;
                break;
            case 10:
                FindClosestEnemy()[10].GetComponent<Common1>().zom = 1;
                break;
            case 11:
                FindClosestEnemy()[11].GetComponent<Common1>().zom = 1;
                break;
            case 12:
                FindClosestEnemy()[12].GetComponent<Common1>().zom = 1;
                break;
            case 13:
                FindClosestEnemy()[13].GetComponent<Common1>().zom = 1;
                break;
            case 14:
                FindClosestEnemy()[14].GetComponent<Common1>().zom = 1;
                break;
            case 15:
                FindClosestEnemy()[15].GetComponent<Common1>().zom = 1;
                break;
            case 16:
                FindClosestEnemy()[16].GetComponent<Common1>().zom = 1;
                break; 
            case 17:
                FindClosestEnemy()[17].GetComponent<Common1>().zom = 1;
                break;
            case 18:
                FindClosestEnemy()[18].GetComponent<Common1>().zom = 1;
                break;
            case 19:
                FindClosestEnemy()[19].GetComponent<Common1>().zom = 1;
                break;
            case 20:
                FindClosestEnemy()[20].GetComponent<Common1>().zom = 1;
                break;
            case 21:
                FindClosestEnemy()[21].GetComponent<Common1>().zom = 1;
                break;
            case 22:
                FindClosestEnemy()[22].GetComponent<Common1>().zom = 1;
                break;
            case 23:
                FindClosestEnemy()[23].GetComponent<Common1>().zom = 1;
                break;
            case 24:
                FindClosestEnemy()[24].GetComponent<Common1>().zom = 1;
                break;
            case 25:
                FindClosestEnemy()[25].GetComponent<Common1>().zom = 1;
                break;
            case 26:
                FindClosestEnemy()[26].GetComponent<Common1>().zom = 1;
                break;
            case 27:
                FindClosestEnemy()[27].GetComponent<Common1>().zom = 1;
                break;
            case 28:
                FindClosestEnemy()[28].GetComponent<Common1>().zom = 1;
                break;
            case 29:
                FindClosestEnemy()[29].GetComponent<Common1>().zom = 1;
                break;
            case 30:
                FindClosestEnemy()[30].GetComponent<Common1>().zom = 1;
                break;

        }*/
    }
    /*GameObject[] FindClosestEnemy()
    {
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in enemy)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                sixthclosest = fifthclosest;
                seventhclosest = sixthclosest; 
                eighthclosest =  seventhclosest;
                ninthclosest =  eighthclosest;
                tenthclosest =  ninthclosest;
                elevenclosest =  tenthclosest;
                twelveclosest =  elevenclosest;
                thirteenclosest =  twelveclosest;
                fourteenclosest =  thirdclosest;
                fifteenclosest = fourthclosest;
                sixteenclosest = fifthclosest;
                eighteenclosest = sixteenclosest;
                ninteenclosest = eighteenclosest;
                twentyclosest = ninteenclosest;
                twentyoneclosest =  twentyclosest;
                twentytwoclosest =  twentyoneclosest;
                twentythreeclosest = twentytwoclosest;
                twentyfourclosest =  twentythreeclosest;
                twentyfiveclosest =  twentyfourclosest;
                twentysixclosest = twentyfiveclosest;
                twentysevenclosest =  twentysixclosest;
                twentyeightclosest =  twentysevenclosest;
                twentynineclosest = twentyeightclosest;
                thirtyoneclosest =  twentynineclosest;
                thirtytwoclosest =  thirtyoneclosest;
                thirtythreeclosest =  thirtytwoclosest;
                thirtyfourclosest =  thirtythreeclosest;
                thirtyfiveclosest = thirtyfourclosest;
                thirtysixclosest = thirtyfiveclosest;
                thirtysevenclosest =  thirtysixclosest;
                thirtyeightclosest = thirtysevenclosest;
                thirtynineclosest =  thirtyeightclosest;
                fortyclosest =  thirtynineclosest;
                fortyoneclosest =  fortyclosest;
                fortytwoclosest =  fortyoneclosest;
                fortythreeclosest = fortytwoclosest;
                fortyfourclosest = fortythreeclosest;
                fortyfiveclosest =  fortyfourclosest;
                fortysixclosest =  fortyfiveclosest;
                fortysevenclosest = fortysixclosest;
                fortyeightclosest =  fortysevenclosest;
                fortynineclosest =  fortyeightclosest;
                fiftyclosest = fortynineclosest;
                fifthclosest = fourthclosest;
                fourthclosest = thirdclosest;
                thirdclosest = secondclosest;
                secondclosest = closest;
                closest = go;
                distance = curDistance;
            }
        }
        //return closest;
        return new GameObject[] { closest, secondclosest, thirdclosest, fourthclosest, fifthclosest , sixthclosest, seventhclosest ,eighthclosest , ninthclosest , tenthclosest , elevenclosest , twelveclosest , thirteenclosest , fourteenclosest , fifteenclosest ,
        sixteenclosest , eighteenclosest ,ninteenclosest ,twentyclosest ,twentyoneclosest , twentytwoclosest , twentythreeclosest , twentyfourclosest , twentyfiveclosest , twentysixclosest 
       , twentysevenclosest , twentyeightclosest , twentynineclosest , thirtyoneclosest , thirtytwoclosest , thirtythreeclosest , thirtyfourclosest , thirtyfiveclosest ,
        thirtysixclosest,thirtysevenclosest , thirtyeightclosest , thirtynineclosest , fortyclosest , fortyoneclosest , fortytwoclosest , fortythreeclosest , fortyfourclosest 
        , fortyfiveclosest , fortysixclosest , fortysevenclosest , fortyeightclosest , fortynineclosest , fiftyclosest };
    }*/
    // Update is called once per frame
    void Update()
    {
        
    }
}
