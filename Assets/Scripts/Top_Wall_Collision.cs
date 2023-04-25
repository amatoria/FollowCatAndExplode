using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// learned from:
// https://www.youtube.com/watch?v=-7I0slJyi8g
public class Top_Wall_Collision : MonoBehaviour
{
    // Check SceneBuildIndex in Build Settings
    // If this is a public variable, we can set it in Unity.
    //public int sceneToLoad;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        // In our code, we want to make sure our player object,
        // "Luna",
        // has her tag set to "Player" (check Inspector window for more info.)
        //if (other.tag == "Player")
        //{
            // at some point, we can generalize the code to work for all scenes.
            //SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Single);
        //}
    }
}