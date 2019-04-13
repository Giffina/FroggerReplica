using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownSizeSelect1 : MonoBehaviour
{
    // this script is attached to the manager, but could be attached to any gameobject that has an update method.
    public Dropdown MyDropDown;
    public Text MyChoice;
    public static Vector2 frogSize;
    // Update is called once per frame
    public void Update()
    {
        switch (MyDropDown.value)
        {
            case 1:
                MyChoice.text = "Small";
                frogSize = new Vector2(.3f, .3f);
                break;
            case 2:
                MyChoice.text = "Medium";
                frogSize = new Vector2(.6f, .6f);
                break;
            case 3:
                MyChoice.text = "Large";
                frogSize = new Vector2(1f, 1f);
                break;
            default:
                MyChoice.text = "Please Select";
                frogSize = new Vector2(1f, 1f);
                break;
        }
    }

}
