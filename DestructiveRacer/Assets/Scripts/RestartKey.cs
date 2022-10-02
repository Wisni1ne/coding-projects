using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartKey : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R)) {  // When "R" is pressed, restart level.
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
