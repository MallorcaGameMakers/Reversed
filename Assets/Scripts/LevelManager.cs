using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Comandos;


namespace Levels
{
    public class LevelManager : MonoBehaviour
    {
        public static LevelManager Instance;
        [SerializeField] private GameObject PlayerPrefab;
        private Level SelectedLvl;

        private void Awake()
        {
            Instance = this;
        }
        public void ChangeSelectedLvl(Level level)
        {
            SelectedLvl = level;
            //Cambiar escena y instanciar

        }
    } 
}
