using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
