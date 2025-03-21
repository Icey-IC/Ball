using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
        public GameObject Title;
        public AudioSource Exploded;
        public AudioSource Xiu;

    void BallAnimEnd()
    {
        Title.SetActive(true);
        gameObject.SetActive(false);
    }
    void BallFly()
    {
        Xiu.Play();
    }
    void BallExploded()
    {
        Exploded.Play();
    }

    void Transition()
    {
        Title.SetActive(false);
    }

    void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
