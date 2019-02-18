using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public GameObject Player;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.transform.position = new Vector3(Player.transform.position.x + 400, Player.transform.position.y + 400, Player.transform.position.z + 400);
	}
}
