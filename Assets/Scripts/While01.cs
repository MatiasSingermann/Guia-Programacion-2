using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While01 : MonoBehaviour
{

    public int counter;
    public int countermax;

    // Start is called before the first frame update
    void Start()
    {
        while(counter <= countermax)
        {
            Debug.Log(counter);
            counter ++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
