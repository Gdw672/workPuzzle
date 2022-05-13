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
    [SerializeField]
    public void loadStore()
    {
        SceneManager.LoadScene(2);
    }

   public void restartLvlOrNext()
    {
        if(classLvlAndScore.isWasLvlDone)
        {
            classLvlAndScore.lvl += 1;
            saves save = new saves();
            save.saveLvl();
            print("lvl now " + save.loadLvl());
            loadGame();
        }
        if(classLvlAndScore.isWasLvlDone == false)
        {
            loadGame();
        }
    }

 public  void exitgame()
    {
        Application.Quit();
    }

}
