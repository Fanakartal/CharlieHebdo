using UnityEngine;
using System.Collections;

public class GameOverWaiter : MonoBehaviour 
{

    public Camera camera;

    void OnLevelWasLoaded()
    {
        LoadNextLevel();
    }

    void LoadNextLevel()
    {
        if(Application.loadedLevel == 2)
            Invoke("SceneLoader", 5.0f);
        else if(Application.loadedLevel == 3)
            Invoke("SceneLoader", 15.0f);
        else if (Application.loadedLevel == 4)
            Invoke("SceneLoader", 6.0f);
    }

    void SceneLoader()
    {
        if (Application.loadedLevel == 2)
            Application.LoadLevel(3);
        else if(Application.loadedLevel == 3)
            Application.LoadLevel(4);
        else if (Application.loadedLevel == 4)
            Application.LoadLevel(5);
    }
    
    void Update()
    {
        if (camera != null && camera.orthographicSize > 110)
            camera.orthographicSize = Mathf.Lerp(camera.orthographicSize, camera.orthographicSize - 118, Time.deltaTime / 2);
    }

    /*IEnumerator WaitABit(float sec)
    {
        yield return new WaitForSeconds(sec);
        
    }*/
}
