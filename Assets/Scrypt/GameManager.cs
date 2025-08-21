using UnityEngine;
using System;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int Tipe;

    [SerializeField] private GameObject[] _units;
    [SerializeField] private Transform _pos;
    [SerializeField] private int _atakMax;
    [SerializeField] private Image _image;

    private GameObject _object;

    public Action Smena;

    private void Start()
    {
        _object = Instantiate(_units[Tipe], _pos.transform.position, _pos.transform.rotation);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            NewAtak();
        }
    }

    public void NewAtak()
    {
        Tipe++;

        Destroy(_object);
        if (Tipe > _atakMax)
        {
            Tipe = 0;
        }
        _object = Instantiate(_units[Tipe], _pos.transform.position, _pos.transform.rotation);
        switch (Tipe)
        {
            case 0:
                _image.color = new Color(1f, 0f, 0f);
                break;
            case 1:
                _image.color = new Color(1f, 0f, 1f);
                break;
            case 2:
                _image.color = new Color(0f, 0f, 1f);
                _object.GetComponent<AtakPlayer>()._gm = GetComponent<GameManager>();
                break;
        }
    }
}
