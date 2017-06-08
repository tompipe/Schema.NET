namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A musical composition.
    /// </summary>
    [DataContract]
    public class MusicComposition : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MusicComposition";

        /// <summary>
        /// The type of composition (e.g. overture, sonata, symphony, etc.).
        /// </summary>
        [DataMember(Name = "musicCompositionForm")]
        public string MusicCompositionForm { get; set; }

        /// <summary>
        /// Smaller compositions included in this work (e.g. a movement in a symphony).
        /// </summary>
        [DataMember(Name = "includedComposition")]
        public MusicComposition IncludedComposition { get; set; }

        /// <summary>
        /// The person who wrote the words.
        /// </summary>
        [DataMember(Name = "lyricist")]
        public Person Lyricist { get; set; }

        /// <summary>
        /// An audio recording of the work.
        /// </summary>
        [DataMember(Name = "recordedAs")]
        public MusicRecording RecordedAs { get; set; }

        /// <summary>
        /// The date and place the work was first performed.
        /// </summary>
        [DataMember(Name = "firstPerformance")]
        public Event FirstPerformance { get; set; }

        /// <summary>
        /// An arrangement derived from the composition.
        /// </summary>
        [DataMember(Name = "musicArrangement")]
        public MusicComposition MusicArrangement { get; set; }

        /// <summary>
        /// The words in the song.
        /// </summary>
        [DataMember(Name = "lyrics")]
        public CreativeWork Lyrics { get; set; }

        /// <summary>
        /// The International Standard Musical Work Code for the composition.
        /// </summary>
        [DataMember(Name = "iswcCode")]
        public string IswcCode { get; set; }

        /// <summary>
        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        [DataMember(Name = "composer")]
        public object Composer { get; protected set; }

        /// <summary>
        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        [IgnoreDataMember]
        public Organization ComposerOrganization
        {
            get => this.Composer as Organization;
            set => this.Composer = value;
        }

        /// <summary>
        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        [IgnoreDataMember]
        public Person ComposerPerson
        {
            get => this.Composer as Person;
            set => this.Composer = value;
        }

        /// <summary>
        /// The key, mode, or scale this composition uses.
        /// </summary>
        [DataMember(Name = "musicalKey")]
        public string MusicalKey { get; set; }
    }
}