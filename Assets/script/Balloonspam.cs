using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balloonspam : MonoBehaviour
{
    [SerializeField] GameObject balloonPrefab;
    private bool bandera = true;
    public Text txt;
    void Start()
    {
//        InvokeRepeating("Spam", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space) && bandera)
        {
            bandera = false;
            InvokeRepeating("Spam", 1f, 2f);
            txt.gameObject.SetActive(false );
        }
    }
    void Spam()
    {
        Instantiate(balloonPrefab, transform.position, transform.rotation);

    }
}
