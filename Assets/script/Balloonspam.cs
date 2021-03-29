using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloonspam : MonoBehaviour
{
    [SerializeField] GameObject balloonPrefab;

    void Start()
    {
        InvokeRepeating("Spam", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spam()
    {
        Instantiate(balloonPrefab, transform.position, transform.rotation);

    }
}
