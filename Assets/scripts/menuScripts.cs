using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuScripts : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] public void loadGame()
    {
        SceneManager.LoadScene(1);
    }

    [SerializeField] public void loadMenuFromStore()
    {
        SceneManager.LoadScene(0);
    }
   
}
