using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButton : MonoBehaviour
{
    public Button nextButton;
    
   private GameManager gameManager;

    // Start is called before the first frame update
   void Start()
    {
        Button = GetComponent<Button>();
        Button.onClick.AddListener(StartOnClick);
        gameManager = GameObject.Find("GameManager").GetComponent<GamaManager>();
    }

    // Update is called once per frame
    void StartOnClick()
    {
        Debug.Log("Next button was clicked");
        gameManager.StartGame();
    }

    public void MoveToScreen(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }
}
