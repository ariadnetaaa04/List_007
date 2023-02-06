using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song : MonoBehaviour
{
    private int bottles = 99;
    // Start is called before the first frame update
    void Start()
    {
        while (bottles > 0)
        {
            Debug.Log($"{bottles} bottles of beer on the wall, {bottles} bottles of beer. Take one down and pass it around, {bottles - 1} bottles of beer on the wall.");
         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
