using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Levels
{
    [CreateAssetMenu(fileName = "LevelRegister", menuName = "LevelManager/LevelRegister")]
    public class LevelsRegisters : ScriptableObject
    {
        [SerializeField]public List<Level> AllLevels = new List<Level>();
    } 
}
