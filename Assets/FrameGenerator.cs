using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FrameGenerator : MonoBehaviour
{
    [SerializeField] private Transform parentTransform;
    [SerializeField] private GameObject frame;
    [SerializeField] private Button generateNewButton;


    // Start is called before the first frame update
    void Start()
    {
        generateNewButton.onClick.AddListener(GenerateNewButtonClicked);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateNewButtonClicked() {
            Instantiate(frame, parentTransform.position - parentTransform.right * 0.7f, parentTransform.rotation);
        }
}
