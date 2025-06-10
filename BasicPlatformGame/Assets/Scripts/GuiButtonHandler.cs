using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuiButtonHandler : MonoBehaviour
{
    private GameManager gameManager;
    private void Start()
    {
        //Can only do this because the GameManager script is attached to the same object
        //as this script
        gameManager = GetComponent<GameManager>();
    }
    public void loadGame()
    {
        SceneManager.LoadScene("Level01");
    }
    public void exitGame()
    {
        //only works on a build
        Application.Quit();
    }
    public void displayMenu()
    {

    }
}
