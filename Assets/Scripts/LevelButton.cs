using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Levels
{
    public class LevelButton : MonoBehaviour
    {
        [SerializeField] private Text Number;
        [SerializeField] private Text Name;
        [SerializeField] private Image Score;
        private Level Level;
        public void Initialize(Level level, int lvlNumber)
        {
            Level = level;
            SetUI(lvlNumber);
        }
        private void SetUI(int lvlNumber)
        {
            Number.text = lvlNumber.ToString();
            Name.text = Level.Name;
        }

        public void SetNewLvl()
        {
            LevelManager.Instance.ChangeSelectedLvl(Level);
        }
    }
}
