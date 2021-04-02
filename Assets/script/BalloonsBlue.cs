using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonsBlue : MonoBehaviour
{
    [SerializeField] Sprite[] balloonSprites;
    [SerializeField] Vector3 force;
    private UIManager UIMgr;

    private Rigidbody2D rbb;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        UIMgr = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();

        rbb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = balloonSprites[Random.Range(0, 1)];
        transform.position = new Vector3(Random.Range(-8.7f, 6.4f), transform.position.y, transform.position.z);
        if (UIMgr.scoret >=500)
        {
            force = new Vector3(0, Random.Range(500, 600), 0);
            rbb.AddForce(force);
        }
        else
        {
            force = new Vector3(0, Random.Range(155, 250), 0);
            rbb.AddForce(force);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "topWall")
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "Nave")
        {
            
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            UIMgr.AddScore10();
        }
    }
}
