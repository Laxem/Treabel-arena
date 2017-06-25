using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMouse
{
    void MouseMove(Vector3 pos);
}

public class MouseHandler : MonoBehaviour {

    private List<IMouse> _listMouse;

    private static MouseHandler _instance;

    public static MouseHandler GetInstance()
    {
        return _instance;
    }

    void Awake()
    {
        if (_instance != this) _instance = this;

        if (_listMouse == null) _listMouse = new List<IMouse>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CheckPos();
	}

    public void RegisterMe(IMouse mouse)
    {
        _listMouse.Add(mouse);
    }

    private void CheckPos()
    {

    }

}
