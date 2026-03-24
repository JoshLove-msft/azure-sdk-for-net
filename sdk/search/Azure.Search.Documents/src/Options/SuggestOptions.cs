// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.Search.Documents
{
    /// <summary>
    /// Options for <see cref="SearchClient.SuggestAsync"/> that
    /// allow specifying filtering, sorting, and other suggestions query
    /// behaviors.
    /// </summary>
    [CodeGenType("SuggestPostRequest")]
    [CodeGenSuppress(nameof(SuggestOptions), typeof(string), typeof(string))]
    public partial class SuggestOptions
    {
        /// <summary>
        /// Initializes new instance of <see cref="SuggestOptions"/>
        /// </summary>
        public SuggestOptions()
        {
        }

        /// <summary>
        /// The search text to use to suggest documents. Must be at least 1
        /// character, and no more than 100 characters.
        /// </summary>
        [CodeGenMember("Search")]
        internal string SearchText { get; set; }

        /// <summary>
        /// The name of the suggester as specified in the suggesters collection
        /// that's part of the index definition.
        /// </summary>
        [CodeGenMember("SuggesterName")]
        internal string SuggesterName { get; set; }

        /// <summary>
        /// An OData expression that filters the documents considered for
        /// suggestions.  You can use
        /// <see cref="SearchFilter.Create(FormattableString)"/> to help
        /// construct the filter expression.
        /// </summary>
        [CodeGenMember("Filter")]
        public string Filter { get; set; }

        /// <summary>
        /// The number of suggestions to retrieve. This must be a value between
        /// 1 and 100. The default is 5.
        /// </summary>
        [CodeGenMember("Top")]
        public int? Size { get; set; }

        /// <summary> A value indicating whether to use fuzzy matching for the suggestion query. Default is false. When set to true, the query will find suggestions even if there's a substituted or missing character in the search text. While this provides a better experience in some scenarios, it comes at a performance cost as fuzzy suggestion searches are slower and consume more resources. </summary>
        public bool? UseFuzzyMatching { get; set; }

        /// <summary> A string tag that is appended to hit highlights. Must be set with highlightPreTag. If omitted, hit highlighting of suggestions is disabled. </summary>
        public string HighlightPostTag { get; set; }

        /// <summary> A string tag that is prepended to hit highlights. Must be set with highlightPostTag. If omitted, hit highlighting of suggestions is disabled. </summary>
        public string HighlightPreTag { get; set; }

        /// <summary> A number between 0 and 100 indicating the percentage of the index that must be covered by a suggestion query in order for the query to be reported as a success. This parameter can be useful for ensuring search availability even for services with only one replica. The default is 80. </summary>
        public double? MinimumCoverage { get; set; }

        /// <summary>
        /// Creates a shallow copy of the SuggestOptions.
        /// </summary>
        /// <returns>The cloned SuggestOptions.</returns>
        internal SuggestOptions Clone() =>
            new SuggestOptions
            {
                SearchText = SearchText,
                SuggesterName = SuggesterName,
                Filter = Filter,
                SearchFields = SearchFields,
                Select = Select,
                Size = Size,
                OrderBy = OrderBy,
                HighlightPostTag = HighlightPostTag,
                HighlightPreTag = HighlightPreTag,
                MinimumCoverage = MinimumCoverage,
                UseFuzzyMatching = UseFuzzyMatching,
            };
    }
}
