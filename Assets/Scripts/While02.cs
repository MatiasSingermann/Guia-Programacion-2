using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While02 : MonoBehaviour
{
    public int num1;
    public int num2;

    // Start is called before the first frame update
    void Start()
    {
        if(num2 >= num1)
        {
            Debug.Log("El primer número debe ser mayor al segundo");
        }

        else
        {
            while(num2 <= num1)
            {
                Debug.Log(num1);
                num1--;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
