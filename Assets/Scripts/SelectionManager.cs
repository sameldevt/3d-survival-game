using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{
    public GameObject InfoUI;
    TextMeshProUGUI InteractionText;

    private void Start()
    {
        InteractionText = InfoUI.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            var selectionTransform = hit.transform;

            if (selectionTransform.GetComponent<InteractableObject>())
            {
                InteractionText.text = selectionTransform.GetComponent<InteractableObject>().GetItemName();
                InfoUI.SetActive(true);
            }
            else
            {
                InfoUI.SetActive(false);
            }

        }
    }
}
