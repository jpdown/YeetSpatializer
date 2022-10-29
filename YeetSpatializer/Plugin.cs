using IPA;
using SiraUtil.Zenject;
using YeetSpatializer.Installers;
using IPALogger = IPA.Logging.Logger;

namespace YeetSpatializer
{
    [Plugin(RuntimeOptions.DynamicInit), NoEnableDisable]
    public class Plugin
    {
        [Init]
        public void Init(Zenjector zenjector, IPALogger logger)
        {
            zenjector.UseLogger(logger);
            zenjector.UseMetadataBinder<Plugin>();

            zenjector.Install<AppInstaller>(Location.App);
        }
    }
}