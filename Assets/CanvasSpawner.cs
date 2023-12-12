using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class CanvasSpawner : MonoBehaviour
{
    [SerializeField] private ActiveStateSelector pose;
    [SerializeField] private GameObject frame;
    [SerializeField] private GameObject particles;
    // Start is called before the first frame update
    void Start()
    {
        pose.WhenSelected += () => SpawnCanvas();
        pose.WhenUnselected += () => SetParticles(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnCanvas()
    {
        Instantiate(frame, this.transform.position + 0.2f * this.transform.up + 0.1f * this.transform.right, this.transform.rotation * Quaternion.Euler(-90, -90, 0));
        SetParticles(true);
    }

    private void SetParticles(bool state)
    {
        particles.SetActive(state);
    }
}
