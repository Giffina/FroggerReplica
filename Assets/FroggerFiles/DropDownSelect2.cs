using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownSelect2 : MonoBehaviour
{
    // this script is attached to the manager, but could be attached to any gameobject that has an update method.
    public Dropdown MyDropDown;
    public Text MyChoice;
    public static float spawnRate;
    // Update is called once per frame
    public void Update()
    {
        switch (MyDropDown.value)
        {
            case 1:
                MyChoice.text = "Slow";
                spawnRate = .4f;
                break;
            case 2:
                MyChoice.text = "Medium";
                spawnRate = .3f;
                break;
            case 3:
                MyChoice.text = "Fast";
                spawnRate = .2f;
                break;
            default:
                MyChoice.text = "Please Select";
                spawnRate = .5f;
                break;
        }
    }
}
