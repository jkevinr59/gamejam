using UnityEngine;
using System.Collections;

public class P2_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float speed = 1.00f;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 move = new Vector3(0f, 7f);
            if (this.transform.position.y < 3.5f)
            {
                this.transform.position += move * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 move = new Vector3(0f, -7f);
            if (this.transform.position.y > -3.5f)
            {
                this.transform.position += move * speed * Time.deltaTime;
            }
        }
	}
}
