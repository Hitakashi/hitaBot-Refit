using System.Collections.Generic;
using System.Runtime.Serialization;

namespace hitaBot.Refit.Model
{
    [DataContract]
    public class Panel
    {
        /// <summary>
        /// Gets or Sets Panels
        /// </summary>
        [DataMember(Name = "panels", EmitDefaultValue = false)]
        public List<Panelobj> Panels { get; set; }
        /// <summary>
        /// Gets or Sets Sorted
        /// </summary>
        [DataMember(Name = "sorted", EmitDefaultValue = false)]
        public List<Sorted> Sorted { get; set; }
        /// <summary>
        /// Gets or Sets Preview
        /// </summary>
        [DataMember(Name = "preview", EmitDefaultValue = false)]
        public List<Preview> Preview { get; set; }
    }

    [DataContract]
    public class Preview
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }
        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name = "template", EmitDefaultValue = false)]
        public string Template { get; set; }
        /// <summary>
        /// Gets or Sets Headline
        /// </summary>
        [DataMember(Name = "headline", EmitDefaultValue = false)]
        public string Headline { get; set; }
        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public string Link { get; set; }
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }
        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public string Image { get; set; }
    }

    [DataContract]
    public class Sorted
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }
        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name = "template", EmitDefaultValue = false)]
        public string Template { get; set; }
        /// <summary>
        /// Gets or Sets Headline
        /// </summary>
        [DataMember(Name = "headline", EmitDefaultValue = false)]
        public string Headline { get; set; }
        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public string Link { get; set; }
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }
        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public string Image { get; set; }
    }

    [DataContract]
    public class Panelobj
    {
    }
}