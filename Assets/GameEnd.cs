
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    private int levelToLoadEnd = 2;
    public Animator animator2;
    void Update()
    {
 
    }

    void OnTriggerEnter(Collider collider)
    {
        //change later
        FadeToLevel();
    }
    public void FadeToLevel()
    {
        animator2.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(2);
    }
}
