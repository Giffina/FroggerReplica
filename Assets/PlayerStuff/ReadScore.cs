using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ReadScore : MonoBehaviour
{

    public Text Score;

    void Start()
    {
        string path = "Assets/Resources/Score.txt";
        string lineRead = "";
        Score.text = "";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        while (!reader.EndOfStream)
        {
            //Debug.Log(reader.ReadLine());
            lineRead = reader.ReadLine();
            Debug.Log(lineRead);
            Score.text += lineRead + "\n"; // append and go to new line
        }
        reader.Close();

    }

}
