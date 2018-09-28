using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{
    public bool ifbool;
    public int value;
    // Use this for initialization
    void Start()
    {
        
    }
    // != inte lika med
    // == lika med
    // < större än
    // > mindre än
    // >= större än eller lika med
    // <= mindre än eller lika med
    // && = och
    // || = eller
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Random.Range(0f, 10f);
            print("you suck");

        }
        if (ifbool == true)
        {
            print("ja");

        }
        else
        {
            print("nej");

        }
        if (value == 5)
        {
            print("dampbarn");
        }
        else if (value == 4)
        {
            print("flarnbarn");

        }
        else
        {
            print("lulrekt");
        }
    }
}
