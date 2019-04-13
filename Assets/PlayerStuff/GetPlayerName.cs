using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;

public class GetPlayerName : MonoBehaviour
{
    public InputField PlayerName;
    public Text ShowName;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        
    }
    public void WriteName()
    {
        string path = "Assets/Resources/Name.txt";
        if(path != null)
        {
            ClearName();
        }
        string nameToBeSaved = PlayerName.text;
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(nameToBeSaved);
        writer.Close();

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("Name");

        Debug.Log("name is : "+PlayerName.text);
    }
    public void DisplayName()
    {
        ShowName.text = PlayerName.text;
    }
    void ClearName()
    {
        string path = "Assets/Resources/Name.txt";
        File.WriteAllText(path, string.Empty);
    }
}
