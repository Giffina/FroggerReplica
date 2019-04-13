using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using UnityEditor;

public class Frog : MonoBehaviour {

    public static int lives = 3;
    public Text AmtLives;

	public Rigidbody2D rb;

    public void Start()
    {
        AmtLives.text = "Lives: " + lives.ToString();

        
    }

    void Update () {
        transform.localScale = DropDownSizeSelect1.frogSize;

        if (Input.GetKeyDown(KeyCode.RightArrow))
			rb.MovePosition(rb.position + Vector2.right);
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
			rb.MovePosition(rb.position + Vector2.left);
		else if (Input.GetKeyDown(KeyCode.UpArrow))
			rb.MovePosition(rb.position + Vector2.up);
		else if (Input.GetKeyDown(KeyCode.DownArrow))
			rb.MovePosition(rb.position + Vector2.down);

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Car")
		{
			Debug.Log("WE LOST!");
			Score.CurrentScore = 0;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            lives -= 1;
            if(lives < 1)
            {
                SceneManager.LoadScene("Exit");
                WriteScore();
            }
		}
	}
    public Text PlayerScore;
    public void WriteScore()
    {
        string path = "Assets/Resources/Score.txt";
        if (path != null)
        {
            ClearScore();
        }
        string scoreToBeSaved = PlayerScore.text;
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(scoreToBeSaved);
        writer.Close();

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("Score");

        Debug.Log("score is : " + PlayerScore.text);
    }

    void ClearScore()
    {
        string path = "Assets/Resources/Score.txt";
        File.WriteAllText(path, string.Empty);
    }
}
