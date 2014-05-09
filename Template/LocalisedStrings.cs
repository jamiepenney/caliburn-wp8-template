using $safeprojectname$.Resources;

namespace $safeprojectname$
{
    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalisedStrings
    {
        private static readonly AppResources _localisedResources = new AppResources();

        public AppResources LocalisedResources { get { return _localisedResources; } }
    }
}