// add loading background
// add UI slider
// add text

// CHATGPT SCRIPT BELOW: CHECK BEFORE RUNNING/ATTACHING

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class LoadingManager : MonoBehaviour
{
    public Slider progressBar;
    public Text progressText; // Optional

    public void LoadScene(string sceneName)
    {
        StartCoroutine(LoadSceneAsync(sceneName));
    }

    private IEnumerator LoadSceneAsync(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        
        // Disable automatic scene activation until the loading is complete
        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            // Update the progress bar (normalize progress from 0 to 1)
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            progressBar.value = progress;

            // Optional: Update progress text
            if (progressText != null)
            {
                progressText.text = $"Loading... {progress * 100:F0}%";
            }

            // Activate the scene once the loading is almost done
            if (operation.progress >= 0.9f)
            {
                progressText.text = "Press any key to continue...";
                
                if (Input.anyKeyDown) // Optional: Wait for user input
                {
                    operation.allowSceneActivation = true;
                }
            }

            yield return null;
        }
    }
}
