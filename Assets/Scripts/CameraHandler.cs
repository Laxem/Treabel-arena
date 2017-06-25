using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour {

    private Transform _transf;

	// Use this for initialization
	void Start () {
        _transf = transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayerMove(Vector3 pos)
    {
        _transf.position = new Vector3(pos.x, pos.y, _transf.position.z);
    }
}
