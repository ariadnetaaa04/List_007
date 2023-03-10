using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
   
    public GameObject cube;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            float XRandom = Random.Range(-5, 5);
            float YRandom = Random.Range(-5, 5);
            float ZRandom = Random.Range(-5, 5);

            Vector3 position = new Vector3(XRandom, YRandom, ZRandom);

            GameObject myinst=Instantiate(cube, position, Quaternion.identity);
            myinst.transform.localScale = Vector3.one * Random.Range(0,5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
}
