using UnityEngine;
using SimpleFPS;

[RequireComponent(typeof(AudioSource))]
public class SpringPlatform : MonoBehaviour
{
    [SerializeField] private int jumpForse;

    private new AudioSource audio;
    private float previusJumpForse;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            previusJumpForse = fps.m_JumpSpeed;

            fps.m_JumpSpeed += jumpForse;
            fps.m_Jump = true;

            audio.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed = previusJumpForse;
           
        }
    }
}
