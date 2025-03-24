using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenuPanel;  // Assign in Inspector
    public GameObject settingsPanel;  // Assign in Inspector

    public void OpenSettings()
    {
        mainMenuPanel.SetActive(false);  // Hide main menu
        settingsPanel.SetActive(true);   // Show settings panel
    }

    public void BackToMainMenu()
    {
        settingsPanel.SetActive(false);  // Hide settings
        mainMenuPanel.SetActive(true);   // Show main menu
    }

    public void ExitGame()
    {
        Debug.Log("Game is exiting..."); // This shows a message in the Console
        Application.Quit(); // Closes the game in a built version
    }
}
