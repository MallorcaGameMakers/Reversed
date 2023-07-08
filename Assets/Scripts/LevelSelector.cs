using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Levels
{
    public class LevelSelector : MonoBehaviour
    {
        [SerializeField] private LevelsRegisters LevelRegister;
        [SerializeField] private GameObject ButtonPrefab;
        [SerializeField] private Transform PanelTransfrom;

        // cargar en pantalla de carga
        private void Initialize()
        {
            List<Level> alllevels = LevelRegister.AllLevels;
            for (int i = 0; i < alllevels.Count; i++)
            {
                GameObject go = Instantiate(ButtonPrefab, PanelTransfrom);
                LevelButton button = go.GetComponent<LevelButton>();
                button.Initialize(alllevels[i],i);
            }
        }


    }

}
