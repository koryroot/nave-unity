using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloonspam2 : MonoBehaviour
{
    [SerializeField] GameObject balloonPrefab;

    void Start()
    {
        InvokeRepeating("Spam", 0.0f, 1f);
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
