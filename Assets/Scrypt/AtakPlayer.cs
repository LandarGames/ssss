using UnityEngine;
using UnityEngine.UI;
public class AtakPlayer : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    [SerializeField] private int _tipeMax;
    public GameManager _gm;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Atak();
        }
    }

    public void Atak()
    {
        switch (_gm.Tipe)
        {
            case 0:
                _anim.SetBool("Atak1", true);
                Invoke(nameof(AtakDown), 0.1f);
                break;
            case 1:
                _anim.SetBool("Atak2", true);
                Invoke(nameof(AtakDown), 0.1f);
                break;
            case 2:
                _anim.SetBool("Atak3", true);
                Invoke(nameof(AtakDown),0.1f);
                break;
        }
    }

    private void AtakDown()
    {
        _anim.SetBool("Atak1", false);
        _anim.SetBool("Atak2", false);
        _anim.SetBool("Atak3", false);
    }
}
