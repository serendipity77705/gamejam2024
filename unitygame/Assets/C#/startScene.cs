// attach script to button
// change build settings?
// Replace with actual Scene name

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");  // Replace with actual Scene name
    }
}
