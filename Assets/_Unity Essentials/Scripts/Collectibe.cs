using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibe : MonoBehaviour
{
    public float RotationSpeed;
    public GameObject onCollectEffect;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, RotationSpeed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        Instantiate(onCollectEffect, transform.position, transform.rotation);
    }

}
