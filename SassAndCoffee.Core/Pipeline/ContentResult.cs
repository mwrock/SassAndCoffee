﻿namespace SassAndCoffee.Core.Pipeline {
    using System.Collections.Generic;

    public class ContentResult {
        public string Content { get; set; }
        public string MimeType { get; set; }
        public IEnumerable<string> CacheInvalidationFileList { get; set; }
        public int? MaxAgeSeconds { get; set; }
    }
}
