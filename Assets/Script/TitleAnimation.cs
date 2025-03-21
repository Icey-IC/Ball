using UnityEngine;

public class TitleAnimation : MonoBehaviour
{
    public GameObject MenuPart;
    public GameObject PlayPart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        MenuPart.transform.position = new Vector3(-5.2f,-0.5f,0);
        PlayPart.transform.position = new Vector3(-5.2f,-2.2f,0);

    }

}
