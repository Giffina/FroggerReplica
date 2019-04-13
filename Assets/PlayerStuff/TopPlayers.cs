using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class TopPlayers : MonoBehaviour
{
    public Text Player;
    // Start is called before the first frame update
    void Update()
    {

        string path = "Assets/Resources/Player.txt";

        string lineRead = "";
        Player.text = "";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        while (!reader.EndOfStream)
        {
            //Debug.Log(reader.ReadLine());
            lineRead = reader.ReadLine();
            Debug.Log(lineRead);
            Player.text += lineRead + "\n"; // append and go to new line
        }
        reader.Close();

    
    }
    public string[] GetScores()
    {
        string path2 = "Assets/Resources/HiScores.txt";
        string[] players = new string[3];
        string line = "";
        using (StreamReader reader = new StreamReader(path2))
        {
            int lineNum = 0;
            while (!reader.EndOfStream)
            {
                players[lineNum] = line;
                ++lineNum;
            }
        }
        return players;
    }
    // Update is called once per frame


    public void ConcatenateNameAndScore()
    {
        string path = "Assets/Resources/Player.txt";
        if (path != null)
        {
            ClearName();
        }
        string[] file1 = File.ReadAllLines("Assets/Resources/Name.txt");
        string[] file2 = File.ReadAllLines("Assets/Resources/Score.txt");

        using (StreamWriter writer = File.CreateText(@"Assets/Resources/Player.txt"))
        {
            int lineNum = 0;
            while (lineNum < file1.Length || lineNum < file2.Length)
            {

                writer.WriteLine("{0}: {1}", file1[lineNum], file2[lineNum]);
                lineNum++;

            }
        }

    }

    void ClearName()
    {
        string path = "Assets/Resources/Player.txt";
        File.WriteAllText(path, string.Empty);
    }
}
