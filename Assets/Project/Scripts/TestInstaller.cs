using Fusion;
using UnityEngine;
using Zenject;

public class TestInstaller : MonoInstaller
{
    [SerializeField]
    private Object somePrefab;

    public override void InstallBindings()
    {
        Container.Bind<NetworkRunner>().FromComponentInNewPrefab(somePrefab).AsSingle().NonLazy();
    }
}