using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Drag and drop connection for Hierarchy
    public GameObject pauseMenu;
    
    // Update is called once per frame
    private void Update()
    {
        pauseButtonPress();
    }
    public void pauseButtonPress()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            showPauseMenu();
            pauseGame();
        }
    }
    public void pauseGame()
    {
        Time.timeScale = 1;
    }
    public void resumeGame()
    {
        Time.timeScale = 1;
        hidePauseMenu();
    }
    public void showPauseMenu()
    {
        pauseMenu.SetActive(true);
    }
    public void hidePauseMenu()
    {
        //not finsished, i don't think he showed this part in the video
        //come back later to finish this
    }
}
