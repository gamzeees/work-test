using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    [SerializeField]
    private KeyCode keyCode = KeyCode.Space;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // This if statement will check the keyCode field if it is pressed down
        if (Input.GetKeyDown(keyCode))
        {
            // OnKeyDown method will be called when any specified key is pressed down
            Task1Example.instance.OnKeyDown();
        }
    }
}
