using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Comandos;
namespace Levels
{
    [CreateAssetMenu(fileName = "Level", menuName = "LevelManager/Level")]
    public class Level : ScriptableObject
    {
        //UI
        public string Name;
        public int Score;
        [SerializeField] private List<Commands> playercommands = new List<Commands>();
         public void Initialize()
        {
            //setear nivel
        }
    } 
}
