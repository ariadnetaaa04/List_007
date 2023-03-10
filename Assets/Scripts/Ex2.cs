using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ex2 : MonoBehaviour
{
    public int counter;
    public int second = 1;
    public TextMeshProUGUI counterText;
    public GameObject CountdownPanel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Timer");
      
        
    }
    private IEnumerator Timer()
    {
        while (true)
       {
            yield return new WaitForSeconds(second);
            Counter();
        }
    }
    
    private void Counter()
    {
        counter++;
      counterText.text = $"Time: {counter}";
    }
    
}
