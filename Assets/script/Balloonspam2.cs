using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balloonspam2 : MonoBehaviour
{
    [SerializeField] GameObject balloonPrefab;

    private bool bandera = true;

    void Start()
    {
   //     InvokeRepeating("Spam", 0.0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && bandera)
        {
            bandera = false;
            InvokeRepeating("Spam", 0.0f, 1f);
            
        }

    }
    
    void Spam()
    {
        Instantiate(balloonPrefab, transform.position, transform.rotation);

    }
}
