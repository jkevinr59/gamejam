using UnityEngine;
using System.Collections;

public class Player_Control : MonoBehaviour {

	// Use this for initialization
    GameObject prefab;
    float FireRate = 0.5f;
    float timestamp = 0f;
	void Start () {
        prefab = Resources.Load("proj1") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
        float speed = 1.00f;
        if(Input.GetKey(KeyCode.W))
            {
                Vector3 move = new Vector3(0f,7f);
                this.transform.position += move * speed * Time.deltaTime;
            }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 move = new Vector3(0f, -7f);
            this.transform.position += move * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.D) && Time.time>=timestamp)
        {
            GameObject projectile_1 = Instantiate(prefab) as GameObject;
            timestamp = Time.time + FireRate;
            projectile_1.transform.position = this.transform.position + new Vector3(2.5f,-0.4f);
            Vector2 shoot = new Vector2(180f, 0f);
            Rigidbody2D rb = projectile_1.GetComponent<Rigidbody2D>();
            rb.AddForce(shoot,ForceMode2D.Force);
            Destroy(projectile_1, 3f);
        }
	}
}
