using UnityEngine;
using Mirror;

public class PlayerSetup : NetworkBehaviour
{
    [SerializeField]
    Behaviour[] componentToDisable;

    [SerializeField]
    Camera SceneCamera;

    private void Start()
    {
        if (!isLocalPlayer)
        {
            //Nous bouclons sur les différents composants renseignés et les désactiver si ce joueur n'est pas le notre
            for (int i = 0; i < componentToDisable.Length; i++)
            {
                componentToDisable[i].enabled = false;
            }
        }
        else
        {
            SceneCamera = GameObject.Find("SceneCamera").GetComponent<Camera>();

            if(SceneCamera == null)
            {
                SceneCamera.gameObject.SetActive(false);
            }
        }
    }

    private void OnDisable()
    {
        if (SceneCamera != null)
        {
            SceneCamera.gameObject.SetActive(true);
        }
    }
}
