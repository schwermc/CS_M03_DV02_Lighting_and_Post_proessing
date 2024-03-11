using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void goToProbes()
    {
        SceneManager.LoadScene("Probes");
    }

    public void goToBaked()
    {
        SceneManager.LoadScene("Baked");
    }
}
