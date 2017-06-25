using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour,  IGameInput
{
    private CameraHandler _camH;

    private Transform _transf;

    private float _moveSpeed = 4f;
    
	void Start () {
        _camH = GameObject.FindObjectOfType<CameraHandler>();
        _transf = transform;

        InputHandler.GetInstance().RegisterMe(this);
	}
	
	void Update () {
		
	}

    private void Move(Vector3 dir)
    {
        _transf.position += dir * Time.deltaTime;

        _camH.PlayerMove(_transf.position);
    }

    public void ButtonUp()
    {        
        Move(Vector3.up * _moveSpeed);
    }

    public void ButtonDown()
    {
        Move(Vector3.down * _moveSpeed);
    }

    public void ButtonLeft()
    {
        Move(Vector3.left * _moveSpeed);
    }

    public void ButtonRight()
    {
        Move(Vector3.right * _moveSpeed);
    }

}
