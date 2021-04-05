using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveScript : MonoBehaviour
{

    private Rigidbody2D rb;
    Vector2 input;
    [SerializeField] GameObject NavePrefabs;
    [SerializeField] Vector3 Naveforce;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        input.y = Input.GetAxis("Vertical");
        //input.x = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = input * speed * Time.fixedDeltaTime;
    }

    void Shoot()
    {
        GameObject Lacer = Instantiate(NavePrefabs, transform.position, transform.rotation);
        Lacer.GetComponent<Rigidbody2D>().AddForce(Naveforce);

        Destroy(Lacer, 1.3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "topWall")
        {
            Destroy(this.gameObject);
        }
    }
}
