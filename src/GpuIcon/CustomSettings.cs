using System.Reflection;
using System.Drawing;
using TrayIconLibrary;

namespace GpuIcon
{
    class CustomSettings : Settings<CustomSettings>
    {
        public CustomSettings()
        {
            this.section = "gpu";
        }

        public Color foregroundColor
        {
            get { return GetValueByMethod_Color(MethodBase.GetCurrentMethod(), "#FFFF8800"); }
            set { SetValueByMethod(MethodBase.GetCurrentMethod(), value); }
        }

        public Color backgroundColor
        {
            get { return GetValueByMethod_Color(MethodBase.GetCurrentMethod(), "#00000000"); }
            set { SetValueByMethod(MethodBase.GetCurrentMethod(), value); }
        }

        public Color borderColor
        {
            get { return GetValueByMethod_Color(MethodBase.GetCurrentMethod(), "#99FFAA00"); }
            set { SetValueByMethod(MethodBase.GetCurrentMethod(), value); }
        }

        public int updateInterval
        {
            get { return GetValueByMethod(MethodBase.GetCurrentMethod(), 1000); }
            set { SetValueByMethod(MethodBase.GetCurrentMethod(), value); }
        }

    }
}
