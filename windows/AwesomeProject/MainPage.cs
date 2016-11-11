using ReactNative;
using ReactNative.Modules.Core;
using ReactNative.Modules.RNDeviceInfo;
using ReactNative.Shell;
using System.Collections.Generic;

namespace AwesomeProject
{
    class MainPage : ReactPage
    {
        public override string MainComponentName
        {
            get
            {
                return "AwesomeProject";
            }
        }

#if BUNDLE
        public override string JavaScriptBundleFile
        {
            get
            {
                return "ms-appx:///ReactAssets/index.windows.bundle";
            }
        }
#endif

        public override List<IReactPackage> Packages
        {
            get
            {
                return new List<IReactPackage>
                {
                    new MainReactPackage(),
                    new RNDeviceInfo(),
                };
            }
        }

        public override bool UseDeveloperSupport
        {
            get
            {
#if !BUNDLE || DEBUG
                return true;
#else
                return false;
#endif
            }
        }
    }

}
