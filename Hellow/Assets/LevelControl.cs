using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelControl : MonoBehaviour
{
    private Enemy[] _enemy;
   private static int _nextLevelIndex=1;  
    // Start is called before the first frame update
    private void OnEnable() {
        _enemy = FindObjectsOfType<Enemy>();
         
    }
    void Update()
    {
        foreach(Enemy enemy in _enemy)
        {
            if(enemy!=null)
              return;

        }
        Debug.Log("You Killed all enemies");
        _nextLevelIndex++;
        string nextlevelName= "Level" + _nextLevelIndex;
        SceneManager.LoadScene(nextlevelName);

    }
}
