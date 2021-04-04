using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using  UnityEngine.SceneManagement;

public class img_history : MonoBehaviour
{

    public Image uiImage;
    public comenzar cm;
    bool x = true;
    public Canvas cv;
    public Image img;
    public Canvas cvGame;


    private bool bandera = true;
    private int imgChange=1;
    private float contadorTime;
    
    void Start()
    {
        uiImage = GameObject.Find("img_cambiante").GetComponent<Image>();
        cvGame.gameObject.SetActive(false);
    }

  

    private void Update()
    {
        cambiarImagenes();
    }

    
    void cambiarImagenes()
    {
        contadorTime += Time.deltaTime;
        //Debug.Log(int.Parse( contadorTime.ToString("f0")));
        
        if (imgChange <= 3 &&int.Parse( contadorTime.ToString("f0")) % 5==0 && x && contadorTime>1)
        {
            x = false;
            uiImage.sprite = Resources.Load<Sprite>("Sprites/img_"+imgChange);
            imgChange++;
                
        }
        if (int.Parse(contadorTime.ToString("f0")) % 6==0)
        {
            x = true;
        }

        if (contadorTime > 20 && bandera)
        {
            Destroy(cv);
            Destroy(img); 
            cvGame.gameObject.SetActive(true);
            bandera = false;
        }

    

    }
}
