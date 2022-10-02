using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BigD;//big memory of data
using System;
using Random = UnityEngine.Random;//random


public class EcoManager : MonoBehaviour
{

    private float a, b, c, d, e, f, g, h, i ;
    BigDouble tempG, tempH, tempI;
    public GameObject unit, dozens, hundreds, thousands, tensOfThousands, hundredsOfThousands, millions, tensOfMillions, hundredsOfMillions, total;
    public static EcoManager Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        //variable for big memory
        tempG = new BigDouble(g);
        tempH = new BigDouble(h);
        tempI = new BigDouble(i);

        StartCoroutine(AddUnit());
        StartCoroutine(AddDozens());
        StartCoroutine(AddHundreds());
        StartCoroutine(AddThousands());
        StartCoroutine(AddTensOfThousands());
        StartCoroutine(AddHundredsOfThousands());
        StartCoroutine(AddMillions());
        StartCoroutine(AddTensOfMillions());
        StartCoroutine(AddHundredsOfMillions());
    }

    // Update is called once per frame
    void Update()
    {
        total.GetComponent<Text>().text = new BigDouble(a + b + c + d + e + f + tempG + tempH + tempI).ToString();
    }
    

    IEnumerator AddUnit()
    {
        a += Random.Range(1, 5);
        unit.GetComponent<Text>().text = a.ToString();
        yield return new WaitForSeconds(1);
        StartCoroutine(AddUnit());
    }
  
    IEnumerator AddDozens()
    {
        b += Random.Range(15, 30);
        dozens.GetComponent<Text>().text = b.ToString();
        yield return new WaitForSeconds(2);
        StartCoroutine(AddDozens());
    }
    
    IEnumerator AddHundreds()
    {
        c += Random.Range(123, 456);
        hundreds.GetComponent<Text>().text = c.ToString();
        yield return new WaitForSeconds(4);
        StartCoroutine(AddHundreds());
    }
   
    IEnumerator AddThousands()
    {
        d += Random.Range(1234,5678);
        thousands.GetComponent<Text>().text = d.ToString();
        yield return new WaitForSeconds(8);
        StartCoroutine(AddThousands());
    }
    
    IEnumerator AddTensOfThousands()
    {
        e += Random.Range(12345, 56789);
        tensOfThousands.GetComponent<Text>().text = e.ToString();
        yield return new WaitForSeconds(12);
        StartCoroutine(AddTensOfThousands());
    }
    
    IEnumerator AddHundredsOfThousands()
    {
        f += Random.Range(111234, 122345);
        hundredsOfThousands.GetComponent<Text>().text = f.ToString();
        yield return new WaitForSeconds(16);
        StartCoroutine(AddHundredsOfThousands());
    }
    
    IEnumerator AddMillions()
    {
        tempG += Random.Range(1000000, 12305000);
        millions.GetComponent<Text>().text = tempG.ToString();
        yield return new WaitForSeconds(20);
        StartCoroutine(AddMillions());
    }
    
    IEnumerator AddTensOfMillions()
    {
        tempH += Random.Range(10000000, 12000000);
        tensOfMillions.GetComponent<Text>().text = tempH.ToString();
        yield return new WaitForSeconds(24);
        StartCoroutine(AddTensOfMillions());
    }
    
    IEnumerator AddHundredsOfMillions()
    {
        tempI += Random.Range(100000000, 120200000);
        hundredsOfMillions.GetComponent<Text>().text = tempI.ToString();
        yield return new WaitForSeconds(30);
        StartCoroutine(AddHundredsOfMillions());
    }
    
}
