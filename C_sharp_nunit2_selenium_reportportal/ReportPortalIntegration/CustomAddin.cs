using ReportPortal.NUnit;
using NUnit.Core.Extensibility;

namespace C_sharp_nunit2_selenium_reportportal.ReportPortalIntegration
{
    [NUnitAddin]
    public class CustomAddin: IAddin
    {
        public bool Install(IExtensionHost host)
        {
			if (ReportPortalAddin.InstalledAddin == null)
			{
				new ReportPortalAddin().Install(host);

				// subscribe on ReportPortalAddin.InstalledAddin events here
			}
			
            return true;
        }
    }
}
