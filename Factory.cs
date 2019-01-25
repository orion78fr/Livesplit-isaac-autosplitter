using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;

namespace LiveSplit.UI.Components
{
    public class Factory : IComponentFactory
    {
        public ComponentCategory Category
        {
            get { return ComponentCategory.Control; }
        }
        public string Description
        {
            get { return "Auto splitter for TBOI:R by Guillaume Turchini (orion78fr)"; }
        }
        public string ComponentName
        {
            get { return "TBOI:R Auto Splitter"; }
        }

        public IComponent Create(LiveSplitState state)
        {
            return new Component();
        }

        public string UpdateName
        {
            get { return ComponentName; }
        }

        public string XMLURL
        {
#if RELEASE_CANDIDATE
            get { return "http://livesplit.org/update_rc_sdhjdop/Components/update.LiveSplit.TheBindingOfIsaacRebirth.xml"; }
#else
            get { return "http://livesplit.org/update/Components/update.LiveSplit.TheBindingOfIsaacRebirth.xml"; }
#endif
        }

        public string UpdateURL
        {
#if RELEASE_CANDIDATE
            get { return "http://livesplit.org/update_rc_sdhjdop/"; }
#else
            get { return "http://livesplit.org/update/"; }
#endif
        }

        public Version Version
        {
            get { return Version.Parse("1.6.2"); }
        }
    }
}
