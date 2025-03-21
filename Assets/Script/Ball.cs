using UnityEngine;

public class Ball : MonoBehaviour
{
        public GameObject Title;
        public AudioSource Exploded;

    void BallAnimEnd()
    {
        Title.SetActive(true);
        gameObject.SetActive(false);
    }

    void BallExploded()
    {
        Exploded.Play();
    }
}
