using TMPro;
using UnityEngine;
using Zenject;

public class MainSceneInstaller : MonoInstaller
{
    public GameManager gameManàger;
    public HUDManager hudManager;

    public BoxCollider2D area;
    public GameObject targetList;

    public override void InstallBindings()
    {

        Container.Bind<Value>().AsSingle();

        Container.BindInstance(area).AsSingle();
        Container.BindInstance(targetList).AsSingle();
        Container.BindInstance(hudManager).AsSingle();
        Container.BindInstance(gameManàger).AsSingle();

        hudManager.LoadUI();
    }
}
