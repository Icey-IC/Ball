using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
        public GameObject Title;
        public GameObject Canvas;
        public AudioSource Exploded;
        public AudioSource Xiu;

    void BallAnimEnd()
    {
        Title.transform.localScale = new Vector3(10,10,10);
        Title.SetActive(true);
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
        Canvas.SetActive(false);
    }

    void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
