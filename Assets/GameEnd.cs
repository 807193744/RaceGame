
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

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
        StartCoroutine(CountDown());
    }

    private IEnumerator CountDown()
    {

            yield return new WaitForSeconds(3);
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
