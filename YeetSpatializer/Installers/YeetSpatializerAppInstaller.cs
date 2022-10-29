using YeetSpatializer.Patches;
using Zenject;

namespace YeetSpatializer.Installers
{
    internal class AppInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<DisableSpatializerPatch>().AsSingle();
        }
    }
}