using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song : MonoBehaviour
{
    private int bottles = 99;
    // Start is called before the first frame update
    void Start()
    {
        while (bottles >= 2)
        {
            Debug.Log($"{bottles} bottles of beer on the wall, {bottles} bottles of beer. ");
            bottles=bottles - 1;
            Debug.Log($"Take one down and pass it around, {bottles} bottles of beer on the wall.");

            if (bottles == 1)
            {
                Debug.Log("1 bottle of beer on the wall, one bottle of beer. Take one down, pass it around, 1 bottle of beer on the wall.");
                bottles = bottles - 1;
            }
            if(bottles == 0)
            {
                Debug.Log("No more bottles of beer on the wall, no more bottles of beer. Go to the store and buy some more, 99 bottles of beer on the wall.");
            }
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
