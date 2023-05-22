using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    private Scene scene;

    // Start is called before the first frame update
   private void Start()
    {
        var parameters = new LoadSceneParameters(LoadSceneMode.Additive);

        scene = SceneManager.LoadScene("Level 2", parameters);
        Debug.Log("Load 1 of Level 2: " + scene.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
