using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal jack = new Animal();
        jack.name = "JACK";
        jack.sound = "Bark";
        jack.weight = 4.5f;

        Animal cat = new Animal();
        cat.name = "NATE";
        cat.sound = "Nyaa Nyaa";
        cat.weight = 3.1f;

        cat = jack;

        cat.name = "Ä¹À» º¯°æ";

        Debug.Log(jack.name);
        Debug.Log(jack.sound);

        Debug.Log(cat.name);
        Debug.Log(cat.sound);

    }


}


public class Animal
{
    public string name;
    public string sound;

    public float weight;
}