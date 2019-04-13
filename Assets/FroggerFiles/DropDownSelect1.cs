using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownSelect1 : MonoBehaviour
{
    // this script is attached to the manager, but could be attached to any gameobject that has an update method.
    public Dropdown MyDropDown;
    public Text MyChoice;
    public float carSpeed;
    public static float theMinSpeed;
    public static float theMaxSpeed;
    // Update is called once per frame
    void Update()
    {
        switch (MyDropDown.value)
        {
            case 1:
                MyChoice.text = "Slow";
                theMinSpeed = 6f;
                theMaxSpeed = 10f;
                break;
            case 2:
                MyChoice.text = "Medium";
                theMinSpeed = 8f;
                theMaxSpeed = 12f;
                break;
            case 3:
                MyChoice.text = "Fast";
                theMinSpeed = 10f;
                theMaxSpeed = 14f;
                break;
            default:
                MyChoice.text = "Please Select";
                theMinSpeed = 6f;
                theMaxSpeed = 10f;
                break;
        }
    }

}
