namespace Digivance.Core.Models {
    /// <summary>
    /// OpenSourceProject represents an open source project that Digivance maintains or
    /// contributes to
    /// </summary>
    public class OpenSourceProject : BaseModel {
        /// <summary>
        /// Description is the short user friendly description of this project
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// DigivanceMaintained is true if this project is created by and or primarily
        /// maintained by Digivance Technologies
        /// </summary>
        public bool DigivanceMaintained { get; set; }

        /// <summary>
        /// DocumentationURL is the link to the official documentation page
        /// </summary>
        public string DocumentationURL { get; set; }

        /// <summary>
        /// IconImageFilename is used to point to the location in the Digivance CDN
        /// (or local file system when debugging) to the image file that should be used
        /// as the icon for this open source project
        /// </summary>
        public string IconImageFilename { get; set; }

        /// <summary>
        /// Name is the user friendly (and unique) name of this project
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// RepositoryURL is the link to where our visitors can obtain a copy from
        /// </summary>
        public string RepositoryURL { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public OpenSourceProject() : base() { }
    }
}
