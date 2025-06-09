using UnityEngine;
using UnityEngine.SceneManagement;

public class GuiButtonHandler : MonoBehaviour
{
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
