using System.Reflection;

namespace Paint
{
    public class ApplicationInfo
    {
        private readonly Assembly assemblyInfo = Assembly.GetExecutingAssembly();
        private object[] attributes;

        /// <summary>
        /// The name of the application.
        /// </summary>
        public string Name
        {
            get
            {
                attributes = assemblyInfo.GetCustomAttributes(typeof(AssemblyProductAttribute), false);

                if (attributes.Length == 0)
                    return string.Empty;

                return ((AssemblyProductAttribute)attributes[0]).Product;
            } // end get
        }

        /// <summary>
        /// The version of the application.
        /// </summary>
        public string Version
        {
            get
            {
                //return assemblyInfo.GetName().Version.ToString();

                attributes = assemblyInfo.GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false);

                if (attributes.Length == 0)
                    return string.Empty;

                return ((AssemblyFileVersionAttribute)attributes[0]).Version;
            } // end get
        }

        /// <summary>
        /// The copyright of the application.
        /// </summary>
        public string Copyright
        {
            get
            {
                attributes = assemblyInfo.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);

                if (attributes.Length == 0)
                    return string.Empty;

                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            } // end get
        }
    } // end class ApplicationInfo
} // end namespace Paint