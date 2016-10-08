using UnityEngine;
using System.Collections;

public class MainControl : MonoBehaviour {
    private int p1_hp;
    private int p2_hp;
    GameObject prefab;

    void Spawn_Full_Heart(GameObject heart1,GameObject heart2,GameObject heart3)
    {
        Vector3 heart_stacks_distance = new Vector3(0.5f,0f);
        heart2.transform.position = heart1.transform.position + heart_stacks_distance;
        heart3.transform.position = heart2.transform.position + heart_stacks_distance;
    }

	// Use this for initialization
	void Start () {
        prefab = Resources.Load("heart") as GameObject;
        p1_hp = 3;
        p2_hp = 3;
        GameObject p1_heart1 = Instantiate(prefab) as GameObject;
        GameObject p1_heart2 = Instantiate(prefab) as GameObject;
        GameObject p1_heart3 = Instantiate(prefab) as GameObject;
        Spawn_Full_Heart(p1_heart1, p1_heart2, p1_heart3);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
