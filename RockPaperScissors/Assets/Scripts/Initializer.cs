
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    public UIController uiController;

	void Start ()
    {
        Utility.uiController = uiController;
        uiController.Initialize();

        Destroy(gameObject);
	}
}
