using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro : MonoBehaviour
{
    // Int = heltal
    // public = syns i unity
    // penne_pasta = namnet
    public int penne_pasta;

    // float = 7 precision
    public float george;

    // string = text 
    public string minecraft;

    // Double = 15 precision
    public double bush;

    // bool = true or false
    public bool john;

    // char = ett tecken
    public char mander;

    /* "multi line comment"
     * 
     * fsdafsafsad
     * fsaf
     * saf
     * sadfsafd
     */


    // Use this for initialization
    void Start()
    {


        //PrintText();
        //Calculate();
        Debug.Log("hej" + "då" + minecraft + " " + bush);
        Debug.Log(string.Format("hej då!{0} {1}", minecraft, bush));


    }


    void PrintText()
    {
        print(minecraft);
        print(penne_pasta + george);
        Calculate();
        Debug.Log(5);
        //Debug.LogError(
        //    Mathf.Sqrt(54343253532) +
        //    Mathf.Sqrt(319203));
    }

    void Calculate()
    {
        print(5 + 5);
        print(9 / 2f);

    }


    // Update is called once per frame
    void Update()
    {

    }
}
