using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ReadName : MonoBehaviour
{

    public Text Name;

    void Start()
    {
        string path = "Assets/Resources/Name.txt";
        string lineRead = "";
        Name.text = "";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        while (!reader.EndOfStream)
        {
            //Debug.Log(reader.ReadLine());
            lineRead = reader.ReadLine();
            Debug.Log(lineRead);
            Name.text += lineRead + "\n"; // append and go to new line
        }
        reader.Close();


    }

}
