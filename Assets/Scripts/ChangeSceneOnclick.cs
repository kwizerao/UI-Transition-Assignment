using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets
{
    public class ChangeSceneOnClick : MonoBehaviour
    {
        public void ChangeToNewScene()
        {
            SceneManager.LoadScene("Newscene");
        }
    }
}