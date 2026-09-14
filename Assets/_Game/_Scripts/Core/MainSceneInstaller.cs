using TMPro;
using UnityEngine;
using Zenject;

public class MainSceneInstaller : MonoInstaller
{
    public GameManager gameManàger;
    public HUDManager hudManager;
    //public Transform hit;
    //public TextMeshPro count;

    public override void InstallBindings()
    {
        //Container.BindInstance(hit).AsSingle();
        //Container.Bind<TextMeshPro>().WithId("Count").FromInstance(count).AsSingle();
        //Container.BindInstance(hit).AsSingle();

        Container.Bind<Value>().AsSingle();

        Container.BindInstance(hudManager).AsSingle();
        Container.BindInstance(gameManàger).AsSingle();
    }
}
