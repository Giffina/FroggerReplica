using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownSizeSelect2 : MonoBehaviour
{
    // this script is attached to the manager, but could be attached to any gameobject that has an update method.
    public Dropdown MyDropDown;
    public Text MyChoice;
    public static Vector2 carSize;
    // Update is called once per frame
    public void Update()
    {
        switch (MyDropDown.value)
        {
            case 1:
                MyChoice.text = "Small";
                carSize = new Vector2(.3f, .3f);
                break;
            case 2:
                MyChoice.text = "Medium";
                carSize = new Vector2(.6f, .6f);
                break;
            case 3:
                MyChoice.text = "Large";
                carSize = new Vector2(1f, 1f);
                break;
            default:
                MyChoice.text = "Please Select";
                carSize = new Vector2(1f, 1f);
                break;
        }
    }
}
