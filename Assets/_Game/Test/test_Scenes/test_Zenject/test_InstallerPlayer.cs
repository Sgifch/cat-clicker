using UnityEngine;
using Zenject;

public class test_InstallerPlayer : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<test_say>().AsSingle();
    }
}