using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private int CurrentLevel;

    public static GameManager GM;
    public GameObject Player;
    //public VRCameraFade ScreenFade;
    
    // prevent the game manager from being destroyed
    void Awake()
    {
        if (GM == null)
        {
            GM = this;
            DontDestroyOnLoad(GM);
        }
        else if (GM != this)
        {
            Destroy(GM);
        }
    }

	// Use this for initialization
	void Start () {
        CurrentLevel = -1;
    }

    // sets the location and rotation of the player each time they go through a specific door
    public void SetPlayerPositionOnSceneTransition(int toNextLevel, int triggerNum)
    {
        CurrentLevel = triggerNum;
        SceneManager.LoadScene(toNextLevel);

        // event system that executes after the scene has finished loading
        SceneManager.sceneLoaded += SceneManager_sceneLoaded;
    }

    private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Debug.Log ("Level has been loaded");
        Player = GameObject.Find("FPSController");

        //ScreenFade.LevelLoaded();
        
        // use a switch case
        switch (CurrentLevel)
        {
            // door to basement
            case 0:
                Player.transform.position = new Vector3(2.3f, 1.5f, -3.2f);
                Player.transform.Rotate(new Vector3(0, 180, 0));
                break;
            // basement stairs to 1st floor
            case 1:
                Player.transform.position = new Vector3(2.45f, 1f, 5.7f);
                Player.transform.Rotate(new Vector3(0, 0, 0));
                break;
            // stairs from 1st floor to 2nd floor
            case 2:
                Player.transform.position = new Vector3(9, 1, -10);
                Player.transform.Rotate(new Vector3(0, 0, 0));
                break;
            // stairs from 2nd floor to 1st floor
            case 3:
                Player.transform.position = new Vector3(2.45f, 1.8f, -2.2f);
                Player.transform.Rotate(new Vector3(0, 180, 0));
                break;
            case 4:
                Player.transform.position = new Vector3(9.5f, 1, 10);
                Player.transform.Rotate(new Vector3(0, 180, 0));
                break;
        }
    }
}
