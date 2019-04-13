using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using UnityEngine.UI;
using System.Linq;
public class HiScores : MonoBehaviour
{
    string[] players;
    string path = "Assets/Resources/Player.txt";
    string path2 = "Assets/Resources/HiScores.txt";

    public Text Guy1;
    public Text Guy2;
    public Text Guy3;
    //string temp = "";

    //string[] scores = File.ReadLines("Assets/Resources/Player.txt").ToArray();
    // Start is called before the first frame update
    void Start()
    {
        //Splitter();
        //SaveScores();
        ShowScores();
    }


    public void Splitter()
    {
        string path = "Assets/Resources/Player.txt";

        string[] scores = File.ReadLines(path).ToArray();
        string PlayMan = scores[0];
        string[] name = PlayMan.Split(new char[] { ':' });
        
        Ranks(name);

    }
    public void ShowScores()
    {
        string path2 = "Assets/Resources/HiScores.txt";
        string[] inc = new string[2];

        string lineRead = "";
        Guy1.text = "";
        Guy2.text = "";
        Guy3.text = "";


        StreamReader reader = new StreamReader(path2);
        while (!reader.EndOfStream)
        {
            //Debug.Log(reader.ReadLine());
            lineRead = reader.ReadLine();
            
            //Guy1.text += lineRead + "\n"; // append and go to new line
            //Guy2.text += lineRead + "\n"; // append and go to new line
           // Guy3.text += lineRead + "\n"; // append and go to new line

        }
        reader.Close();
        string line;
        using (StreamReader sr = new StreamReader(path2))
            for (int i = 0; i < 4; i++)
            {

                line = sr.ReadLine();
                Guy1.text = line;
                line = sr.ReadLine();
                Guy2.text = line;
                line = sr.ReadLine();
                Guy3.text = line;
                line = sr.ReadLine();
               
                if (line == null) break;
            }




        
    }
    public void Ranks(string[] name)
    {


        string path2 = "Assets/Resources/HiScores.txt";

        string[] scores2 = File.ReadLines(path2).ToArray();

        string PlayMan2 = scores2[0];
        string[] name2 = PlayMan2.Split(new char[] { ':' });

        string PlayMan3 = scores2[1];
        string[] name3 = PlayMan3.Split(new char[] { ':' });

        string PlayMan4 = scores2[2];
        string[] name4 = PlayMan4.Split(new char[] { ':' });

        string player1 = name2[1].ToString();
        string player2 = name3[1].ToString();
        string player3 = name4[1].ToString();
        string newScore = name[1].ToString();

        int.TryParse(player1, out int p1);
        int.TryParse(player2, out int p2);
        int.TryParse(player3, out int p3);
        int.TryParse(newScore, out int ns);

        if (ns > p1)
        {
            
            name[1] = name[1];
            name2[1] = name2[1];
            name3[1] = name3[1];
            //name4[1] = name4[1];
           
            string[] lines = { name[0] +":"+ name[1] + Environment.NewLine + name2[0] +":"+ name2[1]  + Environment.NewLine + name3[0] +":"+ name3[1]  };
            File.WriteAllLines(path2, lines);

        }
        else if(ns > p2)
        {
            name2[1] = name2[1];
            name[1] = name[1];
            name3[1] = name3[1];
            //name2[1] = name[1];
            string[] lines = { name2[0] + ":" + name2[1]  + Environment.NewLine + name[0] + ":" + name[1]  + Environment.NewLine + name3[0] + ":" + name3[1] };
            File.WriteAllLines(path2, lines);
        }
        else if(ns > p3)
        {
            name2[1] = name2[1];
            name3[1] = name3[1];
            name[1] = name[1];
            //name[1] = name[1];

            string[] lines = { name2[0] + ":" + name2[1]  + Environment.NewLine + name3[0] + ":" + name3[1]  + Environment.NewLine + name[0] + ":" + name[1] };
            File.WriteAllLines(path2, lines);
        }
        else
        {
            name2[1] = name2[1];
            name3[1] = name3[1];
            name4[1] = name4[1];
            //name[1] = name[1];

            string[] lines = { name2[0] + ":" + name2[1]  + Environment.NewLine + name3[0] + ":" + name3[1]  + Environment.NewLine + name4[0] + ":" + name4[1] };
            File.WriteAllLines(path2, lines);
        }
        ShowScores();
    }
    public Button button1;
    public void DisableButtonOnClick()
    {
        button1.interactable = false;
    }


}
