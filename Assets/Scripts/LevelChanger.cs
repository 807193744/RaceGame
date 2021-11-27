
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelChanger : MonoBehaviour
{
    private int levelToLoad;
    public Animator animator;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            FadeToLevel(1);
        }
    }
    public void FadeToLevel (int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
        timer.totalTime = 0;

    }
}
