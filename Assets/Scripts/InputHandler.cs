using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameInput
{
    void ButtonUp();
    void ButtonDown();
    void ButtonLeft();
    void ButtonRight();
}

public class InputHandler : MonoBehaviour {

    private List<IGameInput> _listGameInput;
    
    private static InputHandler _instance;

    public static InputHandler GetInstance()
    {
        return _instance;
    } 

    void Awake()
    {
        if (_instance != this) _instance = this;

        if (_listGameInput == null) _listGameInput = new List<IGameInput>();
    }
	
    void Start () {
		
	}
	
    void Update()
    {
        InputCheck();
    }

    /*    // i will finish that later ...
	public void RegisterMe(GameObject obj)
    {
        IGameInput gameIn = obj.GetComponents<Component>()
        if (gameIn != null) _listGameInput.Add(gameIn);
    }
    */

    public void RegisterMe(IGameInput gameIn)
    {
        _listGameInput.Add(gameIn);
    }

    private void ButtonUp()
    {
        for(int i = 0; i < _listGameInput.Count; ++i)
        {
            _listGameInput[i].ButtonUp();
        }
    }

    private void ButtonDown()
    {
        for (int i = 0; i < _listGameInput.Count; ++i)
        {
            _listGameInput[i].ButtonDown();
        }
    }

    private void ButtonLeft()
    {
        for (int i = 0; i < _listGameInput.Count; ++i)
        {
            _listGameInput[i].ButtonLeft();
        }
    }

    private void ButtonRight()
    {
        for (int i = 0; i < _listGameInput.Count; ++i)
        {
            _listGameInput[i].ButtonRight();
        }
    }

    private void InputCheck()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            ButtonUp();
            Debug.Log("up");
        }

        if (Input.GetKey(KeyCode.S))
            ButtonDown();

        if (Input.GetKey(KeyCode.Q))
            ButtonLeft();

        if (Input.GetKey(KeyCode.D))
            ButtonRight();
    }

}
