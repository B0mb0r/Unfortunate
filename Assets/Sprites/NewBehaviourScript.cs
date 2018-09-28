using System.Collections;
using System.Collections.Generic;
using UnityEngine;



            
public class NewBehaviourScript : MonoBehaviour
{

    public string minecraft, ost, kurt;
    public float butler, angle, pieces;
    

    // Use this for initialization
    void Start()
    {
        Uppgift1();     
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5();
    }


    void Uppgift1()
    {

        Debug.Log(
            string.Format(
                "Uppgift 1: {0}",
                (963f * 421f) - (175463f / 87f)));


    }

    void Uppgift2()
    {
        
        sentence1();
        sentence2();
        sentence3();

    }

    void sentence1()
    {

        Debug.Log(string.Format(
            "uppgift2.1: {0}" ,
            (minecraft)));

        
    }

    void sentence2()
    {

        Debug.Log(string.Format(
            "Uppgift2.2 {0}",
            (ost)));

    }

    void sentence3()
    {

        Debug.Log(string.Format(
            "uppgift 2.3 {0}",
            (kurt)));


    }

    void Uppgift3()
    {

        Debug.Log(string.Format(
            "Uppgift3.1: {0}",
            Mathf.Pow(69f, 3f)));

        Debug.Log(string.Format(
            "Uppgift3.2: {0}",
            Mathf.Sqrt(69f)));

    }

    void Uppgift4()
    {

        Debug.Log(string.Format(
            "Uppgift4: {0}",
            8 * butler / 2 + "m^2"));

    }

    void Uppgift5()
    {

        Debug.Log(string.Format(
            "Uppgift5.1: {0}",
            360 / angle + "pieces"));

        Debug.Log(string.Format(
            "Uppgift5.2: {0}",
            360 / pieces + "degrees"));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
